Imports IBM.Data.DB2

Public Class FrmEmployee
    Private DBConn As Common.DbConnection
    Private VEmpID As Integer

    'Button Close
    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        DBConn.Close()
        Me.Close()
    End Sub

    'EmployeeFrm Load
    Private Sub FrmEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DBConn = New DB2Connection("server=localhost;database=dmpccs5;" + "uid=db2admin;password=db2admin;")
            DBConn.Open()

            With Me.DGVEmployeeList
                .ColumnCount = 3
                .Columns(0).Name = "EmpID"
                .Columns(1).Name = "EmpName"
                .Columns(2).Name = "EmpType"
                .Columns(0).Width = 200
                .Columns(1).Width = 200
                .Columns(2).Width = 200
            End With

            'CB EmpType
            cbEmpType.Items.Add("Cashier (P)")
            cbEmpType.Items.Add("Cook (C)")
            cbEmpType.Items.Add("Inventory Custodian (I)")
            'cbEmpType.SelectedIndex = 0 'Set a default value

            'Me.btnSave.Enabled = True

            Call CheckPermission()
            Call Populate_Grid()
            Call Get_EmployeeID()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CheckPermission()
        Dim Role As String = Me.ShowRoleTB.Text

        Select Case Role
            Case "C" 'Cook'
                Me.DelivBtn.Enabled = True

            Case "P" 'Cashier'
                Me.SaleBtn.Enabled = True
                Me.SalesRecBtn.Enabled = True
                Me.DelivBtn.Enabled = True

            Case "I" 'Inventory Custodian'
                Me.DelivBtn.Enabled = True
                Me.RecordRelBtn.Enabled = True
        End Select

        Me.CustRecBtn.Enabled = True
        Me.EmpRecBtn.Enabled = True
        Me.OrderBtn.Enabled = True

    End Sub

    'Get Employee ID
    Private Sub Get_EmployeeID()
        Dim VStr As String
        Dim VCmd As DB2Command
        Dim VRdr As DB2DataReader
        Try
            VStr = "select EmpID from employee order by EmpID desc"
            VCmd = New DB2Command(VStr, DBConn)
            VRdr = VCmd.ExecuteReader
            VRdr.Read()
            If VRdr.HasRows Then
                VEmpID = VRdr.GetString(0) + 1
            Else
                VEmpID = 10000000
            End If
            Me.txtEmpID.Text = VEmpID
        Catch ex As Exception
            'MsgBox(ex.ToString)
            MsgBox("An error occurred while getting the employee ID: " & ex.Message)
        End Try
    End Sub

    'BtnSave Employee Entry
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim VSave As String
        Dim VEmpName As String
        Dim VEmpType As String
        Dim VCmdSave As DB2Command

        Try
            VEmpID = Me.txtEmpID.Text
            VEmpName = Me.txtEmpName.Text
            VEmpType = MapEmpType(Me.cbEmpType.SelectedItem.ToString())


            VSave = "insert into employee values ('" & VEmpID & "','" & VEmpName & "', '" & VEmpType & "')"
            VCmdSave = New DB2Command(VSave, DBConn)
            VCmdSave.ExecuteNonQuery()

            MsgBox("New employee record is successfully added.")

            Call Clear_Entry()
            Call Get_EmployeeID()
            Call Populate_Grid()

        Catch ex As Exception
            MsgBox("An error occurred while saving the employee record: " & ex.Message)
        End Try
    End Sub

    'Edit Button
    Private Sub btnEdit_Click(sender As Object, e As EventArgs)
        Me.txtEmpName.Enabled = True
        Me.cbEmpType.Enabled = True
        Me.btnUpdate.Enabled = True
    End Sub

    'Update Button
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim VStr As String
        Dim VEmpType As String = MapEmpType(Me.cbEmpType.SelectedItem.ToString())
        Dim VCmd As DB2Command

        Try
            VStr = "update employee set empName='" & Me.txtEmpName.Text & "', empType ='" & VEmpType & "' " _
                    & "where empID = '" & Me.txtEmpID.Text & "'"

            VCmd = New DB2Command(VStr, DBConn)
            VCmd.ExecuteNonQuery()

            MsgBox("Employee record has been updated.")

            Me.btnSave.Enabled = True
            Me.btnDelete.Enabled = False
            Me.btnUpdate.Enabled = False

            Call Clear_Entry()
            Call Get_EmployeeID()
            Call Populate_Grid()

        Catch ex As Exception
            MsgBox("An error occurred while saving the employee record: " & ex.Message)
        End Try
    End Sub

    'Delete Button
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim VStr As String
        Dim VCmd As DB2Command

        Try
            VStr = "delete from employee where empID = '" & Me.txtEmpID.Text & "'"

            VCmd = New DB2Command(VStr, DBConn)

            VCmd.ExecuteNonQuery()

            MsgBox("Employee record is deleted successfully.")

            Me.btnSave.Enabled = True
            Me.btnDelete.Enabled = False
            Me.btnUpdate.Enabled = False

            Call Clear_Entry()
            Call Get_EmployeeID()
            Call Populate_Grid()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    'DGV MouseUp
    Private Sub DGVEmployeeList_MouseUp(sender As Object, e As MouseEventArgs) Handles DGVEmployeeList.MouseUp
        Try
            With Me.DGVEmployeeList.CurrentRow
                Me.txtEmpID.Text = .Cells(0).Value
                Me.txtEmpName.Text = .Cells(1).Value.ToString
                Me.cbEmpType.Text = .Cells(2).Value.ToString
            End With

            Me.btnSave.Enabled = False
            Me.btnUpdate.Enabled = True
            Me.btnDelete.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    'Clear Entry
    Private Sub Clear_Entry()
        Me.txtEmpID.Clear()
        Me.txtEmpName.Clear()
        Me.txtEmpName.Focus()
        Me.cbEmpType.SelectedIndex = 0
        'Me.cbEmpType.Clear()
    End Sub

    'Populate Grid
    Private Sub Populate_Grid()
        Dim vStr As String
        Dim VCmdPop As DB2Command
        Dim VRdrPop As DB2DataReader
        Dim VRow As String()

        Try
            vStr = "SELECT EmpID, EmpName, EmpType FROM employee"
            VCmdPop = New DB2Command(vStr, DBConn)
            VRdrPop = VCmdPop.ExecuteReader
            Me.DGVEmployeeList.Rows.Clear()

            While VRdrPop.Read
                VRow = New String() {VRdrPop.GetString(0), VRdrPop.GetString(1), MapEmpTypeBack(VRdrPop.GetString(2).ToString)}
                Me.DGVEmployeeList.Rows.Add(VRow)
            End While
            '  VRdrPop.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    'Search EmpID
    Private Sub txtSearchEmpID_TextChanged(sender As Object, e As EventArgs) Handles txtSearchEmpID.TextChanged
        Dim VstrSearch As String
        Dim Vstr As String
        Dim VCmdSearch As DB2Command
        Dim VRdrSearch As DB2DataReader
        Dim Vrow As String()

        Try
            Vstr = Me.txtSearchEmpID.Text + "%"
            VstrSearch = "SELECT EmpID, EmpName, EmpType FROM EMPLOYEE WHERE empid LIKE '" & Vstr & "'"
            VCmdSearch = New DB2Command(VstrSearch, DBConn)
            VRdrSearch = VCmdSearch.ExecuteReader

            Me.DGVEmployeeList.Rows.Clear()

            While VRdrSearch.Read
                Vrow = New String() {
                    VRdrSearch.GetString(0),
                    VRdrSearch.GetString(1),
                    MapEmpTypeBack(VRdrSearch.GetString(2))
                }
                Me.DGVEmployeeList.Rows.Add(Vrow)
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    'sort by name
    Private Sub RadBtnName_CheckedChanged(sender As Object, e As EventArgs) Handles RadBtnName.CheckedChanged

        Dim CommandStr As String
        Dim DoCommand As DB2Command
        Dim ReaderNameSort As DB2DataReader
        Dim Vrow As String()

        Try
            CommandStr = "SELECT * FROM employee ORDER BY empname ASC"
            DoCommand = New DB2Command(CommandStr, DBConn)
            ReaderNameSort = DoCommand.ExecuteReader

            Me.DGVEmployeeList.Rows.Clear()

            While ReaderNameSort.Read
                Vrow = New String() {
                    ReaderNameSort.GetString(0),
                    ReaderNameSort.GetString(1),
                    MapEmpTypeBack(ReaderNameSort.GetString(2))
                }
                Me.DGVEmployeeList.Rows.Add(Vrow)
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub

    'sort by id
    Private Sub RadBtnID_CheckedChanged(sender As Object, e As EventArgs) Handles RadBtnID.CheckedChanged
        Dim CommandStr As String
        Dim DoCommand As DB2Command
        Dim ReaderNameSort As DB2DataReader
        Dim Vrow As String()

        Try
            CommandStr = "SELECT * FROM employee ORDER BY empid ASC"
            DoCommand = New DB2Command(CommandStr, DBConn)
            ReaderNameSort = DoCommand.ExecuteReader

            Me.DGVEmployeeList.Rows.Clear()

            While ReaderNameSort.Read
                Vrow = New String() {
                    ReaderNameSort.GetString(0),
                    ReaderNameSort.GetString(1),
                    MapEmpTypeBack(ReaderNameSort.GetString(2))
                }
                Me.DGVEmployeeList.Rows.Add(Vrow)
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    'sort by type
    Private Sub RadBtnETyp_CheckedChanged(sender As Object, e As EventArgs) Handles RadBtnETyp.CheckedChanged
        Dim CommandStr As String
        Dim DoCommand As DB2Command
        Dim ReaderNameSort As DB2DataReader
        Dim Vrow As String()

        Try
            CommandStr = "SELECT * FROM employee ORDER BY emptype ASC"

            'Takes into consideration the following: C = Cook, I = Inventory Custodian, P = Cashier. This is why
            'The sorting by type follows the Cook-Inventory Custodian-Cashier format.

            DoCommand = New DB2Command(CommandStr, DBConn)
            ReaderNameSort = DoCommand.ExecuteReader

            Me.DGVEmployeeList.Rows.Clear()

            While ReaderNameSort.Read
                Vrow = New String() {
                    ReaderNameSort.GetString(0),
                    ReaderNameSort.GetString(1),
                    MapEmpTypeBack(ReaderNameSort.GetString(2))
                }
                Me.DGVEmployeeList.Rows.Add(Vrow)
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub
    'EmpType mapping user-friendly names to db values
    Private Function MapEmpType(empType As String) As Char
        Select Case empType
            Case "Cashier (P)"
                Return "P"c
            Case "Cook (C)"
                Return "C"c
            Case "Inventory Custodian (I)"
                Return "I"c
            Case Else
                Return " "c ' Return a space character if the input does not match
        End Select
    End Function

    'EmpType mapping db values back to user-friendly names
    Private Function MapEmpTypeBack(empType As Char) As String
        Select Case empType
            Case "P"c
                Return "Cashier (P)"
            Case "C"c
                Return "Cook (C)"
            Case "I"c
                Return "Inventory Custodian (I)"
            Case Else
                Return String.Empty
        End Select
    End Function

    Private Sub SaleBtn_Click(sender As Object, e As EventArgs) Handles SaleBtn.Click
        Me.Hide()
        FrmRecSale.Show()
    End Sub

    Private Sub DelivBtn_Click(sender As Object, e As EventArgs) Handles DelivBtn.Click
        Me.Hide()
        FrmDeliveryTran.Show()
    End Sub

    Private Sub CustRecBtn_Click(sender As Object, e As EventArgs) Handles CustRecBtn.Click
        Me.Hide()
        FrmCustList.Show()
    End Sub

    Private Sub SalesRecBtn_Click(sender As Object, e As EventArgs) Handles SalesRecBtn.Click
        Me.Hide()
        FrmSalesList.Show()
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        DBConn.Close()
        Me.Close()
    End Sub
   
    Private Sub RecallBtn_Click(sender As Object, e As EventArgs) Handles RecallBtn.Click
        Call Clear_Entry()
        Call Get_EmployeeID()
        Me.btnSave.Enabled = True
        Me.btnUpdate.Enabled = False
        Me.btnDelete.Enabled = False
    End Sub

    Private Sub RecordRelBtn_Click(sender As Object, e As EventArgs) Handles RecordRelBtn.Click
        Me.Hide()
        FrmReleaseRec.Show()
    End Sub

    Private Sub OrderBtn_Click(sender As Object, e As EventArgs) Handles OrderBtn.Click
        Me.Hide()
        FrmOrder.Show()
    End Sub
End Class
