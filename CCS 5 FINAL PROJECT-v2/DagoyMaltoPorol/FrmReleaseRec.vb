Imports IBM.Data.DB2
Public Class FrmReleaseRec
    Private DBConn As Common.DbConnection

    'ReleaseRecordFrm Load 
    Private Sub FrmReleaseRec_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DBConn = New DB2Connection("server=localhost;database=dmpccs5;" + "uid=db2admin;password=db2admin;")
            DBConn.Open()

            With Me.DGVIngredientList
                .ColumnCount = 7
                .Columns(0).Name = "IngredientID"
                .Columns(1).Name = "IngredientName"
                .Columns(2).Name = "NoInSTock"
                .Columns(3).Name = "ExpireDate"
                .Columns(4).Name = "ReplenishPT"
                .Columns(5).Name = "NoToOrder"
                .Columns(6).Name = "UnitMeas"
                .Columns(0).Width = 100
                .Columns(1).Width = 165
                .Columns(2).Width = 100
                .Columns(3).Width = 165
                .Columns(4).Width = 100
                .Columns(5).Width = 100
                .Columns(6).Width = 100
            End With

            Call PopulateIngredientDGV()

            With Me.DGVReleaseRecList
                .ColumnCount = 4
                .Columns(0).Name = "RONo"
                .Columns(1).Name = "EmpID"
                .Columns(2).Name = "ReleasedBy"
                .Columns(3).Name = "Date"
                .Columns(0).Width = 75
                .Columns(1).Width = 75
                .Columns(2).Width = 120
                .Columns(3).Width = 80
            End With

            Call PopulateReleaseTranDGV()

            With Me.DGVRecDetails
                .ColumnCount = 5
                .Columns(0).Name = "Rel_LineNo"
                .Columns(1).Name = "RONo"
                .Columns(2).Name = "IngredientID"
                .Columns(3).Name = "QtyReleased"
                .Columns(4).Name = "UnitMeas"
                .Columns(0).Width = 80
                .Columns(1).Width = 80
                .Columns(2).Width = 100
                .Columns(3).Width = 80
                .Columns(4).Width = 100
            End With

            Call PopulateReleaseLineItemDGV()

            Me.btnReleaseIng.Enabled = False

            Call CheckPermission()
            Call GetRONumber()
            Me.txtLineNo.Text = GetLineNumber()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub

    'Check Permission
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

        Me.CustRecBtn.Enabled = True    'panel
        Me.EmpRecBtn.Enabled = True     'panel
        Me.OrderBtn.Enabled = True

    End Sub

    'Get Release Order Number   //Done
    Private Sub GetRONumber()
        Dim VStr As String
        Dim VRoNo As String = Me.txtRONo.Text
        Dim VCmd As DB2Command
        Dim VRdr As DB2DataReader
        Dim VPrefix As String = "RN"

        Try
            VStr = "SELECT rono FROM rel_record ORDER BY rono DESC "
            VCmd = New DB2Command(VStr, DBConn)
            VRdr = VCmd.ExecuteReader
            VRdr.Read()

            If VRdr.HasRows Then

                Dim numberPart As String = VRdr.GetString(0).Substring(VPrefix.Length)
                Dim newNumber As Integer = CInt(numberPart) + 1
                VRONo = VPrefix & newNumber.ToString().PadLeft(numberPart.Length, "0"c)

            Else
                VRONo = VPrefix & "0001"
            End If

            Me.txtRONo.Text = VRONo

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Function GetLineNumber()
        Dim VStr As String
        Dim VDelLineNo As Integer
        Dim VCmd As DB2Command
        Dim VRdr As DB2DataReader

        'TEST REMARK: Increments properly and is successfully called by InsertSalesLineItem sub'
        Try
            VStr = "SELECT rel_lineno FROM ro_line_item ORDER BY rel_lineno DESC"

            VCmd = New DB2Command(VStr, DBConn)
            VRdr = VCmd.ExecuteReader
            VRdr.Read()

            If VRdr.HasRows Then
                VDelLineNo = VRdr.GetString(0) + 1
            Else
                VDelLineNo = 100
            End If

            Return VDelLineNo

        Catch ex As Exception
            MsgBox(ex.ToString)
            Return 0

        End Try
    End Function

    Private Sub PopulateIngredientDGV()
        Dim vStr As String
        Dim VCmdPop As DB2Command
        Dim VRdrPop As DB2DataReader
        Dim VRow As String()

        Try
            vStr = "SELECT * FROM ingredient"
            VCmdPop = New DB2Command(vStr, DBConn)
            VRdrPop = VCmdPop.ExecuteReader()

            Me.DGVIngredientList.Rows.Clear()

            While VRdrPop.Read()
                VRow = New String() {
                    VRdrPop.GetString(0),
                    VRdrPop.GetString(1),
                    VRdrPop.GetString(2),
                    VRdrPop.GetString(3),
                    VRdrPop.GetString(4),
                    VRdrPop.GetString(5),
                    VRdrPop.GetString(6)
                }

                Me.DGVIngredientList.Rows.Add(VRow)

            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub PopulateReleaseTranDGV()
        Dim vStr As String
        Dim VCmdPop As DB2Command
        Dim VRdrPop As DB2DataReader
        Dim VRow As String()

        Try
            vStr = "SELECT * FROM rel_record"
            VCmdPop = New DB2Command(vStr, DBConn)
            VRdrPop = VCmdPop.ExecuteReader()

            Me.DGVReleaseRecList.Rows.Clear()

            While VRdrPop.Read()
                VRow = New String() {
                    VRdrPop.GetString(0),
                    VRdrPop.GetString(1),
                    VRdrPop.GetString(2),
                    VRdrPop.GetString(3)
                }

                Me.DGVReleaseRecList.Rows.Add(VRow)

            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub PopulateReleaseLineItemDGV()
        Dim vStr As String
        Dim VCmdPop As DB2Command
        Dim VRdrPop As DB2DataReader
        Dim VRow As String()

        Try
            vStr = "SELECT * FROM ro_line_item"
            VCmdPop = New DB2Command(vStr, DBConn)
            VRdrPop = VCmdPop.ExecuteReader()

            Me.DGVRecDetails.Rows.Clear()

            While VRdrPop.Read()
                VRow = New String() {
                    VRdrPop.GetString(0),
                    VRdrPop.GetString(1),
                    VRdrPop.GetString(2),
                    VRdrPop.GetString(3),
                    VRdrPop.GetString(4)
                }

                Me.DGVRecDetails.Rows.Add(VRow)

            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    'Get Employee Name // should automatically be filled whatever the EMPID is but IDK how
    Private Function GetEmpName(empID As String) As String
        Dim VStr As String
        Dim VEmpName As String = ""
        Dim VCmd As DB2Command
        Dim VRdr As DB2DataReader

        Try
            VStr = "SELECT EmpName FROM employee WHERE EmpID = '" & empID & "'"
            VCmd = New DB2Command(VStr, DBConn)
            VRdr = VCmd.ExecuteReader

            If VRdr.Read() Then
                VEmpName = VRdr.GetString(0)
            End If

            Return VEmpName

        Catch ex As Exception
            MsgBox(ex.ToString)
            Return ""
        End Try
    End Function


    'Search Ingredient Name //Done 
    Private Sub txtSearchIngredientName_TextChanged(sender As Object, e As EventArgs) Handles txtSearchIngredientName.TextChanged
        Dim VstrSearch As String
        Dim Vstr As String
        Dim VCmdSearch As DB2Command
        Dim VRdrSearch As DB2DataReader
        Dim Vrow As String()

        Try
            Vstr = Me.txtSearchIngredientName.Text + "%"
            VstrSearch = "SELECT * FROM ingredient WHERE ingredientname LIKE '" & Vstr & "'"

            VCmdSearch = New DB2Command(VstrSearch, DBConn)
            VRdrSearch = VCmdSearch.ExecuteReader

            Me.DGVIngredientList.Rows.Clear()

            While VRdrSearch.Read
                Vrow = New String() {
                    VRdrSearch.GetString(0),
                    VRdrSearch.GetString(1),
                    VRdrSearch.GetString(2),
                    VRdrSearch.GetString(3),
                    VRdrSearch.GetString(4),
                    VRdrSearch.GetString(5),
                    VRdrSearch.GetString(6)
                }
                Me.DGVIngredientList.Rows.Add(Vrow)
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    'DGVIngredients MouseUp
    Private Sub DGVIngredientList_MouseUp(sender As Object, e As MouseEventArgs) Handles DGVIngredientList.MouseUp

        Try
            With Me.DGVIngredientList.CurrentRow
                Me.txtIngID.Text = .Cells(0).Value
                Me.txtUnitMeas.Text = .Cells(6).Value
            End With

            Me.txtQtyRel.Enabled = True
            Me.btnReleaseIng.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    'Release Ingredient Button // 
    Private Sub IngReleaseBtn_Click(sender As Object, e As EventArgs) Handles btnReleaseIng.Click

        Try
            If String.IsNullOrEmpty(Me.txtQtyRel.Text) Then
                MsgBox("ERROR! Please make sure the quantity to release textbox is filled.")
            Else
                Dim CommandStr As String
                Dim DoCommand As DB2Command
                Dim VRec_Lineno As Integer = Integer.Parse(Me.txtLineNo.Text)
                Dim VRoNo As String = Me.txtRONo.Text
                Dim VIngrdID As String = Me.txtIngID.Text
                Dim VQtyRel As Decimal = Decimal.Parse(Me.txtQtyRel.Text)
                Dim VUnitMeas As String = Me.txtUnitMeas.Text
                Dim VreplenishPt As Integer
                Dim VcurrentStock As Integer


                CommandStr = "INSERT INTO ro_line_item VALUES(" & VRec_Lineno & ", '" & VRoNo & "', '" & VIngrdID & "', " & VQtyRel & ", '" & VUnitMeas & "')"
                DoCommand = New DB2Command(CommandStr, DBConn)
                DoCommand.ExecuteNonQuery()

                MsgBox("Ingredient Released!")

                CommandStr = "UPDATE ingredient SET noinstock = noinstock - " & VQtyRel & " WHERE ingredientid = '" & VIngrdID & "'"
                DoCommand = New DB2Command(CommandStr, DBConn)
                DoCommand.ExecuteNonQuery()

                CommandStr = "SELECT ReplenishPT, NoInStock FROM ingredient WHERE ingredientid = '" & VIngrdID & "'"
                DoCommand = New DB2Command(CommandStr, DBConn)
                Dim reader As DB2DataReader = DoCommand.ExecuteReader()

                If reader.Read() Then
                    VreplenishPt = Convert.ToInt32(reader("ReplenishPT"))
                    VcurrentStock = Convert.ToInt32(reader("NoInStock"))
                End If
                reader.Close()

                If VcurrentStock <= VreplenishPt Then
                    MsgBox("Replenish point reached. Please replenish ingredient with ID: " & VIngrdID)
                End If

                Me.txtQtyRel.Clear()
                Me.txtQtyRel.Clear()
                Me.txtLineNo.Text = Integer.Parse(Me.txtLineNo.Text) + 1

                Call PopulateIngredientDGV()
                Call PopulateReleaseTranDGV()
                Call PopulateReleaseLineItemDGV()

                Me.btnNewTrans.Enabled = True
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    ' Record Save Button Click Event Handler
    Private Sub btnSaveRecord_Click(sender As Object, e As EventArgs) Handles btnSaveRecord.Click

        Try
            If String.IsNullOrEmpty(Me.txtEmpID.Text) Or String.IsNullOrEmpty(Me.txtEmpName.Text) Or String.IsNullOrEmpty(Me.DateTB.Text) Or String.IsNullOrEmpty(Me.txtRONo.Text) Or String.IsNullOrEmpty(Me.txtRole.Text) Then
                MsgBox("ERROR! Please make sure all textboxes in this section are filled.")

            Else
                If Me.txtRole.Text = "I"c Then
                    Dim CommandStr As String
                    Dim DoCommand As DB2Command
                    Dim VRoNo As String = Me.txtRONo.Text
                    Dim VEmpID As String = Me.txtEmpID.Text
                    Dim VEmpName As String = Me.txtEmpName.Text
                    Dim VReleaseDate As Date = Me.DateTB.Text
                    Dim VDateFormatted As String = VReleaseDate.ToString("MM-dd-yyyy")

                    CommandStr = "INSERT INTO rel_record VALUES('" & VRoNo & "', " & VEmpID & ", '" & VEmpName & "', '" & VDateFormatted & "')"
                    DoCommand = New DB2Command(CommandStr, DBConn)
                    DoCommand.ExecuteNonQuery()

                    MsgBox("Record Saved Successfully!")

                    Me.btnReleaseIng.Enabled = False
                    Me.btnSaveRecord.Enabled = False

                    Call PopulateReleaseTranDGV()
                Else
                    MsgBox("ERROR! Only Inventory Custodians can make Ingredient Releases.")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub

    'DGVReleaseRecList MouseUp
    Private Sub DGVReleaseRecList_MouseUp(sender As Object, e As MouseEventArgs) Handles DGVRecDetails.MouseUp
        Dim VRONo As String
        Dim Vdetails As DataTable

        Try
            DGVRecDetails.Rows.Clear()

            If DGVRecDetails.CurrentRow IsNot Nothing AndAlso DGVRecDetails.CurrentRow.Index >= 0 Then
                VRONo = DGVRecDetails.CurrentRow.Cells("RONo").Value.ToString()
                Vdetails = GetRODetails(VRONo)

                ' Display the details in the RecDetails DataGridView
                For Each row As DataRow In Vdetails.Rows
                    DGVRecDetails.Rows.Add(row.ItemArray)
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    'Function to get RO Details
    Private Function GetRODetails(RONo As String) As DataTable
        Dim VdetailsTable As New DataTable()
        Dim commandStr As String

        Try
            commandStr = "SELECT REL_LINENO, RONO, INGREDIENTID, QTYRELEASED, UNITMEAS FROM RO_Line_Item WHERE RONO = @RONo"

            Using cmd As New DB2Command(commandStr, DBConn)
                cmd.Parameters.Add("@RONo", DB2Type.VarChar).Value = RONo

                Using adapter As New DB2DataAdapter(cmd)
                    adapter.Fill(VdetailsTable)
                End Using

            End Using

        Catch ex As Exception
            MsgBox(ex.ToString())

        End Try

        Return VdetailsTable
    End Function

    Private Sub btnNewTrans_Click(sender As Object, e As EventArgs) Handles btnNewTrans.Click
        MsgBox("Form refreshed!")

        With Me
            .txtEmpID.Clear()
            .txtEmpName.Clear()
            .txtRONo.Clear()
            .DateTB.Clear()
            .txtRole.Clear()
            .txtIngID.Clear()
            .txtSearchIngredientName.Clear()
            .txtLineNo.Clear()
            .txtUnitMeas.Clear()
            .btnSaveRecord.Enabled = True
            .txtSearchIngredientName.Enabled = False
            .txtLineNo.Enabled = False
            .txtQtyRel.Enabled = False
            .btnReleaseIng.Enabled = False
            .btnNewTrans.Enabled = False
        End With

        Me.txtLineNo.Text = GetLineNumber()
        Call GetRONumber()
    End Sub

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

    Private Sub btnEmpRecs_Click(sender As Object, e As EventArgs) Handles btnEmpRecs.Click
        DGVEmpListFrmRelease.Show()
        DGVIngredientList.Enabled = True
    End Sub

    Private Sub OrderBtn_Click(sender As Object, e As EventArgs) Handles OrderBtn.Click
        Me.Hide()
        FrmOrder.Show()
    End Sub
End Class

