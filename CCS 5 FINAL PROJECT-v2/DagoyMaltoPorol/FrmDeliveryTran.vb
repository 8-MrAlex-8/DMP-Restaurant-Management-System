Imports IBM.Data.DB2

Public Class FrmDeliveryTran
    Private DBConn As Common.DbConnection

    Private Sub FrmDeliveryList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DBConn = New DB2Connection("server=localhost;database=dmpccs5;" + "uid=db2admin;password=db2admin;")
            DBConn.Open()

            Call InitializeForm()
            Call CheckPermission()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Function GetDRNumber()
        Dim VStr As String
        Dim VDrNo As String
        Dim VCmd As DB2Command
        Dim VRdr As DB2DataReader
        Dim prefix As String = "DN" ' This string is of length 2. Significant in explanations below. '

        'TEST REMARK: successfully sets DRNo'
        Try
            VStr = "SELECT drno FROM deliv_tran ORDER BY drno DESC"
            VCmd = New DB2Command(VStr, DBConn)
            VRdr = VCmd.ExecuteReader()
            VRdr.Read()

            ' Sample (initial) DRNumber: DN3790100 '

            If VRdr.HasRows Then
                ' Extract the numeric part from the drno using Substring method, which returns a substring 
                ' encapsulating the character starting from a specific index to the end of the string. Below,
                ' the substring is from index 2 ('3') to the end of the string ('0').
                Dim numberPart As String = VRdr.GetString(0).Substring(prefix.Length)

                ' Increment Value 
                Dim newNumber As Integer = CInt(numberPart) + 1

                ' Concatenate the prefix with the new incremented number, ensuring leading zeros are preserved
                VDrNo = prefix & newNumber.ToString().PadLeft(numberPart.Length, "0"c)
            Else
                VDrNo = prefix & "3790100"
            End If

            Return VDrNo

        Catch ex As Exception
            MsgBox(ex.ToString)
            Return "0"

        End Try
    End Function

    Private Function GetLineNo()
        Dim VStr As String
        Dim VDelLineNo As Integer
        Dim VCmd As DB2Command
        Dim VRdr As DB2DataReader

        'TEST REMARK: Increments properly and is successfully called by InsertSalesLineItem sub'
        Try
            VStr = "SELECT del_lineno FROM delv_line_item ORDER BY del_lineno DESC"

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

    'Populate Suppliers Grid
    Private Sub PopulateSupplierDGV()
        Dim vStr As String
        Dim VCmdPop As DB2Command
        Dim VRdrPop As DB2DataReader
        Dim VRow As String()

        Try
            vStr = "SELECT * FROM supplier"
            VCmdPop = New DB2Command(vStr, DBConn)
            VRdrPop = VCmdPop.ExecuteReader()

            Me.DGVSuppliers.Rows.Clear()

            While VRdrPop.Read()
                VRow = New String() {
                    VRdrPop.GetString(0),
                    VRdrPop.GetString(1),
                    VRdrPop.GetString(2)
                }

                Me.DGVSuppliers.Rows.Add(VRow)

            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub radbtnSuppID_CheckedChanged(sender As Object, e As EventArgs) Handles radbtnSuppID.CheckedChanged
        Dim vStr As String
        Dim VCmdPop As DB2Command
        Dim VRdrPop As DB2DataReader
        Dim VRow As String()

        Try
            vStr = "SELECT * FROM supplier ORDER BY supplierid ASC"
            VCmdPop = New DB2Command(vStr, DBConn)
            VRdrPop = VCmdPop.ExecuteReader()

            Me.DGVSuppliers.Rows.Clear()

            While VRdrPop.Read()
                VRow = New String() {
                    VRdrPop.GetString(0),
                    VRdrPop.GetString(1),
                    VRdrPop.GetString(2)
                }

                Me.DGVSuppliers.Rows.Add(VRow)

            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub radbtnSuppName_CheckedChanged(sender As Object, e As EventArgs) Handles radbtnSuppName.CheckedChanged
        Dim vStr As String
        Dim VCmdPop As DB2Command
        Dim VRdrPop As DB2DataReader
        Dim VRow As String()

        Try
            vStr = "SELECT * FROM supplier ORDER BY suppliername ASC"
            VCmdPop = New DB2Command(vStr, DBConn)
            VRdrPop = VCmdPop.ExecuteReader()

            Me.DGVSuppliers.Rows.Clear()

            While VRdrPop.Read()
                VRow = New String() {
                    VRdrPop.GetString(0),
                    VRdrPop.GetString(1),
                    VRdrPop.GetString(2)
                }

                Me.DGVSuppliers.Rows.Add(VRow)

            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    'Populate Ingredient Grid
    Private Sub PopulateIngredientDGV()
        Dim vStr As String
        Dim VCmdPop As DB2Command
        Dim VRdrPop As DB2DataReader
        Dim VRow As String()

        Try
            vStr = "SELECT * FROM ingredient"
            VCmdPop = New DB2Command(vStr, DBConn)
            VRdrPop = VCmdPop.ExecuteReader()

            Me.DGVIngredients.Rows.Clear()

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

                Me.DGVIngredients.Rows.Add(VRow)

            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub radbtnIngrdID_CheckedChanged(sender As Object, e As EventArgs) Handles radbtnIngrdID.CheckedChanged
        Dim vStr As String
        Dim VCmdPop As DB2Command
        Dim VRdrPop As DB2DataReader
        Dim VRow As String()

        Try
            vStr = "SELECT * FROM ingredient ORDER BY ingredientid ASC"
            VCmdPop = New DB2Command(vStr, DBConn)
            VRdrPop = VCmdPop.ExecuteReader()

            Me.DGVIngredients.Rows.Clear()

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

                Me.DGVIngredients.Rows.Add(VRow)

            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub radbtnIngrdName_CheckedChanged(sender As Object, e As EventArgs) Handles radbtnIngrdName.CheckedChanged
        Dim vStr As String
        Dim VCmdPop As DB2Command
        Dim VRdrPop As DB2DataReader
        Dim VRow As String()

        Try
            vStr = "SELECT * FROM ingredient ORDER BY ingredientname ASC"
            VCmdPop = New DB2Command(vStr, DBConn)
            VRdrPop = VCmdPop.ExecuteReader()

            Me.DGVIngredients.Rows.Clear()

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

                Me.DGVIngredients.Rows.Add(VRow)

            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub SaleBtn_Click(sender As Object, e As EventArgs) Handles SaleBtn.Click
        Me.Hide()
        FrmRecSale.Show()
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

    Private Sub btnRfrshSupp_Click(sender As Object, e As EventArgs) Handles btnRfrshSupp.Click
        Me.DGVSuppliers.Rows.Clear()
        Call PopulateSupplierDGV()
    End Sub

    Private Sub btnRfrshIngd_Click(sender As Object, e As EventArgs) Handles btnRfrshIngd.Click
        Me.DGVIngredients.Rows.Clear()
        Call PopulateIngredientDGV()
    End Sub

    Private Sub DGVSuppliers_MouseUp(sender As Object, e As MouseEventArgs) Handles DGVSuppliers.MouseUp

        Try
            With Me.DGVSuppliers.CurrentRow
                Me.txtSuppID.Text = .Cells(0).Value
                Me.txtSuppName.Text = .Cells(1).Value
            End With
            Me.btnInitTrans.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub DGVIngredient_MouseUp(sender As Object, e As MouseEventArgs) Handles DGVIngredients.MouseUp

        Try
            With Me.DGVIngredients.CurrentRow
                Me.txtIngrdID.Text = .Cells(0).Value
                Me.txtIngrdName.Text = .Cells(1).Value
                Me.txtUnitMeas.Text = .Cells(6).Value
            End With

            Me.btnAddLinItm.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btnEmpListShow_Click(sender As Object, e As EventArgs) Handles btnEmpListShow.Click
        DGVEmpListFrmDel.Show()
    End Sub

    Private Sub btnAddLinItm_Click(sender As Object, e As EventArgs) Handles btnAddLinItm.Click

        Try
            If String.IsNullOrEmpty(Me.txtLineAmt.Text) Or String.IsNullOrEmpty(Me.txtQtyDelv.Text) Then
                MsgBox("ERROR! Please make sure the Line Amount and Quantity Delivered textboxes are filled.")
            Else
                Dim CommandStr As String
                Dim DoCommand As DB2Command
                Dim VDel_Lineno As Integer = Integer.Parse(Me.txtLineNo.Text)
                Dim VDRNo As String = Me.txtDRNo.Text
                Dim VIngrdID As String = Me.txtIngrdID.Text
                Dim VQtyDlvrd As Decimal = Decimal.Parse(Me.txtQtyDelv.Text)
                Dim VUnitMeas As String = Me.txtUnitMeas.Text
                Dim VLineAmt As Decimal = Decimal.Parse(Me.txtLineAmt.Text)

                CommandStr = "INSERT INTO delv_line_item VALUES(" & VDel_Lineno & ", '" & VDRNo & "', '" & VIngrdID & "', " & VQtyDlvrd & ", '" & VUnitMeas & "', " & VLineAmt & ")"
                DoCommand = New DB2Command(CommandStr, DBConn)
                DoCommand.ExecuteNonQuery()

                MsgBox("Insert successful!")
                MsgBox("Should you wish to insert more items delivered by the same supplier, simply click on another ingredient in the Ingredient DGV.")

                'Compute total
                Me.txtTranAmt.Text += VLineAmt

                'Update transamt every time lineamt is updated
                CommandStr = "UPDATE deliv_tran SET ttl_costdelv = '" & Me.txtTranAmt.Text & "' WHERE drno = '" & VDRNo & "'"
                DoCommand = New DB2Command(CommandStr, DBConn)
                DoCommand.ExecuteNonQuery()

                CommandStr = "UPDATE ingredient SET noinstock = noinstock + " & VQtyDlvrd & " WHERE ingredientid = '" & VIngrdID & "'"
                DoCommand = New DB2Command(CommandStr, DBConn)
                DoCommand.ExecuteNonQuery()

                Me.txtQtyDelv.Clear()
                Me.txtLineAmt.Clear()
                Me.txtLineNo.Text = Integer.Parse(Me.txtLineNo.Text) + 1
                Me.btnShowThisDelv.Enabled = True
                Me.btnNewTrans.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btnInitTrans_Click(sender As Object, e As EventArgs) Handles btnInitTrans.Click
        MsgBox("After you initialize the transaction, you will not be able to make changes to EMPLOYEE and SUPPLIER data, nor backtrack or undo inputs. " _
               + "Please finalize inputs before pressing the Confirm button.")

        Me.btnConfInit.Visible = True
    End Sub

    Private Sub btnConfInit_Click(sender As Object, e As EventArgs) Handles btnConfInit.Click

        Try
            Dim CommandStr As String
            Dim DoCommand As DB2Command
            Dim VDRNo As String = Me.txtDRNo.Text
            Dim VSupplierID As String = Me.txtSuppID.Text
            Dim VEmpID As Integer = Me.txtEmpID.Text
            Dim VTotalCost As Decimal = 0.0
            Dim VDate As Date = Me.txtDelDate.Text
            Dim VDateFormatted As String = VDate.ToString("MM-dd-yyyy")

            CommandStr = "INSERT INTO deliv_tran VALUES('" & VDRNo & "', '" & VSupplierID & "', " & VEmpID & ", " & VTotalCost & ", '" & VDateFormatted & "')"
            DoCommand = New DB2Command(CommandStr, DBConn)
            DoCommand.ExecuteNonQuery()

            MsgBox("Transaction initialization successful!")

            'Disable editing of supplier section '
            Me.btnEmpListShow.Enabled = False
            Me.DGVSuppliers.Enabled = False
            Me.btnInitTrans.Enabled = False
            Me.btnConfInit.Visible = False
            Me.btnEditSuppRec.Enabled = False
            Me.txtLineAmt.Focus()

            'Enable ingredient section '
            Me.radbtnIngrdID.Enabled = True
            Me.radbtnIngrdName.Enabled = True
            Me.btnRfrshIngd.Enabled = True
            Me.DGVIngredients.Enabled = True
            Me.btnEditIngdRec.Enabled = True
            Me.txtLineAmt.Enabled = True
            Me.txtQtyDelv.Enabled = True

            Me.btnShowAllDelv.Enabled = True

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnShowThisDelv_Click(sender As Object, e As EventArgs) Handles btnShowThisDelv.Click
        DGVThisDelivery.Show()
    End Sub

    Private Sub btnShowAllDelv_Click(sender As Object, e As EventArgs) Handles btnShowAllDelv.Click
        DGVAllDeliveries.Show()
    End Sub

    Private Sub InitializeForm()
        Me.txtDRNo.Clear()
        Me.txtDelDate.Clear()
        Me.txtEmpID.Clear()
        Me.txtEmpName.Clear()
        Me.txtIngrdID.Clear()
        Me.txtIngrdName.Clear()
        Me.txtLineAmt.Clear()
        Me.txtLineNo.Clear()
        Me.txtSuppID.Clear()
        Me.txtSuppName.Clear()
        Me.txtQtyDelv.Clear()
        Me.txtLineAmt.Clear()
        Me.txtUnitMeas.Clear()

        Me.txtDRNo.Text = GetDRNumber()
        Me.txtLineNo.Text = GetLineNo()
        Me.txtDelDate.Text = Date.Now

        Me.btnEmpListShow.Enabled = True

        With Me.DGVSuppliers
            .ColumnCount = 3
            .Columns(0).Name = "Supplier ID"
            .Columns(1).Name = "Supplier Name"
            .Columns(2).Name = "Contact Number"

            .Columns(0).Width = 80
            .Columns(1).Width = 180
            .Columns(2).Width = 100

        End With

        Call PopulateSupplierDGV()

        With Me.DGVIngredients
            .ColumnCount = 7
            .Columns(0).Name = "Ingredient ID"
            .Columns(1).Name = "Ingredient Name"
            .Columns(2).Name = "No in Stock"
            .Columns(3).Name = "Expiry Date"
            .Columns(4).Name = "Replenishment Point"
            .Columns(5).Name = "No to Order"
            .Columns(6).Name = "Unit of Measurement"


            .Columns(0).Width = 80
            .Columns(1).Width = 100
            .Columns(2).Width = 100
            .Columns(3).Width = 80
            .Columns(4).Width = 50
            .Columns(5).Width = 80
            .Columns(6).Width = 50

        End With

        Call PopulateIngredientDGV()

        Me.txtTranAmt.Text = 0

    End Sub

    Private Sub btnNewTrans_Click(sender As Object, e As EventArgs) Handles btnNewTrans.Click
        Call InitializeForm()

        'Disable Suppliers section'

        With Me
            .DGVSuppliers.Enabled = False
            .btnInitTrans.Enabled = False
            .btnEditSuppRec.Enabled = False

            .radbtnSuppID.Enabled = False
            .radbtnSuppName.Enabled = False
            .btnEditSuppRec.Enabled = False
            .btnRfrshSupp.Enabled = False

            'Disable Ingredients section'
            .radbtnIngrdID.Enabled = False
            .radbtnIngrdName.Enabled = False
            .btnRfrshIngd.Enabled = False
            .DGVIngredients.Enabled = False
            .btnEditIngdRec.Enabled = False
            .txtLineAmt.Enabled = False
            .txtQtyDelv.Enabled = False
            .btnShowThisDelv.Enabled = False
            .btnAddLinItm.Enabled = False
            .btnNewTrans.Enabled = False
        End With

        MsgBox("Form refreshed!")
    End Sub

    Private Sub SupplierRecBtn_Click(sender As Object, e As EventArgs) Handles SupplierRecBtn.Click
        Me.Hide()
        FrmSupplier.Show()
        FrmSupplier.OrderBtn.Visible = False
        FrmSupplier.DelivBtn.Visible = True
    End Sub

    Private Sub IngredientRecBtn_Click(sender As Object, e As EventArgs) Handles IngredientRecBtn.Click
        Me.Hide()
        FrmIngredients.Show()
        FrmIngredients.OrderBtn.Visible = False
        FrmIngredients.DelivBtn.Visible = True
    End Sub

    Private Sub btnEditSuppRec_Click(sender As Object, e As EventArgs) Handles btnEditSuppRec.Click
        Me.Hide()
        FrmSupplier.Show()
        FrmSupplier.OrderBtn.Visible = False
        FrmSupplier.DelivBtn.Visible = True
    End Sub

    Private Sub btnEditIngdRec_Click(sender As Object, e As EventArgs) Handles btnEditIngdRec.Click
        Me.Hide()
        FrmIngredients.Show()
        FrmIngredients.OrderBtn.Visible = False
        FrmIngredients.DelivBtn.Visible = True

    End Sub

    Private Sub txtDelDate_TextChanged(sender As Object, e As EventArgs) Handles txtDelDate.TextChanged

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
