Imports IBM.Data.DB2

Public Class FrmCustList
    Private DBConn As Common.DbConnection

    Private Sub FrmCustList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DBConn = New DB2Connection("server=localhost;database=dmpccs5;" + "uid=db2admin;password=db2admin;")
            DBConn.Open()

            With Me.DGVCustomers
                .ColumnCount = 2
                .Columns(0).Name = "Customer No."
                .Columns(1).Name = "Customer Name"
                .Columns(0).Width = 200
                .Columns(1).Width = 200

            End With

            Call Populate_Grid()
            Call CheckPermission()
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

    Private Sub Populate_Grid()
        Dim CommandStr As String
        Dim DoCommand As DB2Command
        Dim VReader As DB2DataReader
        Dim VRow As String()

        Try
            CommandStr = "SELECT * FROM customer"
            DoCommand = New DB2Command(CommandStr, DBConn)
            VReader = DoCommand.ExecuteReader
            Me.DGVCustomers.Rows.Clear()

            'Add information to the DGV'
            While VReader.Read
                VRow = New String() {VReader.GetString(0), VReader.GetString(1)}
                Me.DGVCustomers.Rows.Add(VRow)
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub Clear_Entry()

        'Refreshing the fields after a successful edit/deletion'
        Me.TxtBxCustName.Clear()
        Me.TxtBxCustNo.Clear()
        Me.TxtBxCustName.Focus()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim Custno As String = Me.TxtBxCustNo.Text
        Dim Custname As String = Me.TxtBxCustName.Text

        'Trapping for users trying to delete a record after erasing the txtbxcustname value'
        If Not String.IsNullOrWhiteSpace(Custno) AndAlso Not String.IsNullOrWhiteSpace(Custname) Then
            MsgBox("WARNING: Deleting a customer's record will also delete ALL their transaction records from the database. Press the 'Confirm Deletion' button if you indeed wish to delete it.")
            Me.btnSureDelete.Visible = True
            Me.btnReset.Visible = True
        Else
            MsgBox("Please make sure that both fields are filled.")
            Me.TxtBxCustNo.Clear()
        End If

    End Sub

    Private Sub btnSureDelete_Click(sender As Object, e As EventArgs) Handles btnSureDelete.Click
        Dim CommandStr As String
        Dim DoCommand As DB2Command
        Dim Custno As String = Me.TxtBxCustNo.Text
        Dim Custname As String = Me.TxtBxCustName.Text

        Try
            'Trapping for users trying to delete a record after erasing the txtbxcustname value'
            If Not String.IsNullOrWhiteSpace(Custno) AndAlso Not String.IsNullOrWhiteSpace(Custname) Then
                CommandStr = "DELETE FROM customer WHERE customerno = '" & Custno & "' AND customername = '" & Custname & "' "
                DoCommand = New DB2Command(CommandStr, DBConn)
                DoCommand.ExecuteNonQuery()

                MsgBox("The customer's records have been deleted.")

                Me.btnDelete.Enabled = False
                Me.btnUpdate.Enabled = False

                Call Clear_Entry()
                Call Populate_Grid()

            Else
                MsgBox("Please make sure that both fields are filled.")
                Me.TxtBxCustNo.Clear()
            End If

            btnSureDelete.Visible = False
            btnReset.Visible = False

        Catch ex As Exception
            MsgBox(ex.ToString)
            Me.btnSureDelete.Visible = False
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim CommandStr As String
        Dim DoCommand As DB2Command
        Dim Custno As String = Me.TxtBxCustNo.Text
        Dim Custname As String = Me.TxtBxCustName.Text

        Try
            CommandStr = "UPDATE customer SET customername = '" & Custname & "' WHERE customerno = '" & Custno & "'"

            DoCommand = New DB2Command(CommandStr, DBConn)
            DoCommand.ExecuteNonQuery()

            MsgBox("Customer record updated!")

            Call Clear_Entry()
            Call Populate_Grid()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub SrchBxCustID_TextChanged(sender As Object, e As EventArgs) Handles SrchBxCustID.TextChanged
        Dim CommandStr As String
        Dim WildcardStr As String
        Dim DoCommand As DB2Command
        Dim VRdrSearch As DB2DataReader
        Dim Vrow As String()

        Try
            WildcardStr = Me.SrchBxCustID.Text + "%"
            CommandStr = "SELECT * FROM customer WHERE customerno LIKE '" & WildcardStr & "'"
            DoCommand = New DB2Command(CommandStr, DBConn)
            VRdrSearch = DoCommand.ExecuteReader

            Me.DGVCustomers.Rows.Clear()

            While VRdrSearch.Read

                Vrow = New String() {
                    VRdrSearch.GetString(0),
                    VRdrSearch.GetString(1)
                }

                Me.DGVCustomers.Rows.Add(Vrow)

            End While

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub DGVCustomers_MouseUp(sender As Object, e As MouseEventArgs) Handles DGVCustomers.MouseUp
        Try
            With Me.DGVCustomers.CurrentRow
                Me.TxtBxCustNo.Text = .Cells(0).Value
                Me.TxtBxCustName.Text = .Cells(1).Value.ToString
            End With

            Me.btnUpdate.Enabled = True
            Me.btnDelete.Enabled = True
            'Trapping in case the user tries to mouseup on the DGV after triggering the suredelete button's visibility'
            Me.btnSureDelete.Visible = False
            Me.btnReset.Visible = False

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub RadBtnName_CheckedChanged(sender As Object, e As EventArgs) Handles RadBtnName.CheckedChanged
        Dim CommandStr As String
        Dim DoCommand As DB2Command
        Dim VReader As DB2DataReader
        Dim Vrow As String()

        Try
            CommandStr = "SELECT * FROM customer ORDER BY customername ASC"
            DoCommand = New DB2Command(CommandStr, DBConn)
            VReader = DoCommand.ExecuteReader

            Me.DGVCustomers.Rows.Clear()

            While VReader.Read
                Vrow = New String() {
                    VReader.GetString(0),
                    VReader.GetString(1)
                }
                Me.DGVCustomers.Rows.Add(Vrow)
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub RadBtnID_CheckedChanged(sender As Object, e As EventArgs) Handles RadBtnID.CheckedChanged
        Dim CommandStr As String
        Dim DoCommand As DB2Command
        Dim VReader As DB2DataReader
        Dim Vrow As String()

        Try
            CommandStr = "SELECT * FROM customer ORDER BY customerno ASC"
            DoCommand = New DB2Command(CommandStr, DBConn)
            VReader = DoCommand.ExecuteReader

            Me.DGVCustomers.Rows.Clear()

            While VReader.Read
                Vrow = New String() {
                    VReader.GetString(0),
                    VReader.GetString(1)
                }
                Me.DGVCustomers.Rows.Add(Vrow)
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub

    Private Sub SaleBtn_Click(sender As Object, e As EventArgs) Handles SaleBtn.Click
        Me.Hide()
        FrmRecSale.Show()
    End Sub

    Private Sub DelivBtn_Click(sender As Object, e As EventArgs) Handles DelivBtn.Click
        Me.Hide()
        FrmDeliveryTran.Show()
    End Sub

    Private Sub EmpRecBtn_Click(sender As Object, e As EventArgs) Handles EmpRecBtn.Click
        Me.Hide()
        FrmEmployee.Show()
    End Sub

    Private Sub SalesRecBtn_Click(sender As Object, e As EventArgs) Handles SalesRecBtn.Click
        Me.Hide()
        FrmSalesList.Show()
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        DBConn.Close()
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Call Clear_Entry()
        Me.btnSureDelete.Visible = False
        Me.btnReset.Visible = False
    End Sub

    Private Sub btnRfrshDGV_Click(sender As Object, e As EventArgs) Handles btnRfrshDGV.Click
        Me.DGVCustomers.Rows.Clear()
        Call Populate_Grid()
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