Imports IBM.Data.DB2

Public Class FrmOrder
    Private DBConn As Common.DbConnection

    Private Sub FrmOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DBConn = New DB2Connection("server=localhost;database=dmpccs5;" + "uid=db2admin;password=db2admin;")
            DBConn.Open()

            Call InitializeForm()
            Call CheckPermission()

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

    Private Sub InitializeForm()
        Me.txtOrderNo.Clear()
        Me.txtOrderDate.Clear()
        Me.txtOrderAmt.Clear()
        Me.txtEmpID.Clear()
        Me.txtEmpName.Clear()
        Me.txtSuppID.Clear()
        Me.txtSuppName.Clear()
        Me.txtIngrdID.Clear()
        Me.txtIngrdName.Clear()
        Me.txtLineNo.Clear()
        Me.txtQtyOrder.Clear()
        Me.txtUnitMeas.Clear()

        Me.txtOrderNo.Text = GetOrderNumber()
        Me.txtLineNo.Text = GetLineNo()
        Me.txtOrderDate.Text = Date.Now

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
            .Columns(2).Width = 50
            .Columns(3).Width = 80
            .Columns(4).Width = 50
            .Columns(5).Width = 50
            .Columns(6).Width = 50

        End With

        Call PopulateIngredientDGV()

        Me.txtOrderAmt.Text = 0

    End Sub

    'For Order Fm No
    Private Function GetOrderNumber()
        Dim VStr As String
        Dim VOrderNo As Integer
        Dim VCmd As DB2Command
        Dim VRdr As DB2DataReader

        'TEST REMARK: Increments properly and is successfully called by InitilizeForm sub'
        Try
            VStr = "SELECT ordfmno FROM order_tran ORDER BY ordfmno DESC"

            VCmd = New DB2Command(VStr, DBConn)
            VRdr = VCmd.ExecuteReader
            VRdr.Read()

            If VRdr.HasRows Then
                VOrderNo = VRdr.GetString(0) + 1
            Else
                VOrderNo = 50133
            End If

            Return VOrderNo

        Catch ex As Exception
            MsgBox(ex.ToString)
            Return 0

        End Try
    End Function

    'For Order Line No
    Private Function GetLineNo()
        Dim VStr As String
        Dim VDelLineNo As Integer
        Dim VCmd As DB2Command
        Dim VRdr As DB2DataReader

        'TEST REMARK: Increments properly and is successfully called by InitializeForm sub'
        Try
            VStr = "SELECT ord_lineno FROM order_line_item ORDER BY ord_lineno DESC"

            VCmd = New DB2Command(VStr, DBConn)
            VRdr = VCmd.ExecuteReader
            VRdr.Read()

            If VRdr.HasRows Then
                VDelLineNo = VRdr.GetString(0) + 1
            Else
                VDelLineNo = 465
            End If

            Return VDelLineNo

        Catch ex As Exception
            MsgBox(ex.ToString)
            Return 0

        End Try
    End Function

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


    'Start Radio Buttons for Grids
    'For Supplier
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

    'For Ingredients
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

    'End of Radio Buttons


    'Refresh Buttons for Grids
    Private Sub btnRfrshSupp_Click(sender As Object, e As EventArgs) Handles btnRfrshSupp.Click
        Me.DGVSuppliers.Rows.Clear()
        Call PopulateSupplierDGV()
    End Sub

    Private Sub btnRfrshIngd_Click(sender As Object, e As EventArgs) Handles btnRfrshIngd.Click
        Me.DGVIngredients.Rows.Clear()
        Call PopulateIngredientDGV()
    End Sub


    'Selecting Items from Grids
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
    'Start of Menu Buttons
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

    'Sub Menu Buttons
    Private Sub SupplierRecBtn_Click(sender As Object, e As EventArgs) Handles SupplierRecBtn.Click
        Me.Hide()
        FrmSupplier.Show()
        FrmSupplier.DelivBtn.Visible = False
        FrmSupplier.OrderBtn.Visible = True
    End Sub

    Private Sub IngredientRecBtn_Click(sender As Object, e As EventArgs) Handles IngredientRecBtn.Click
        Me.Hide()
        FrmIngredients.Show()
        FrmIngredients.DelivBtn.Visible = False
        FrmIngredients.OrderBtn.Visible = True

    End Sub


    'End of Menu Buttons
    'Private Sub btnEmpListShow_Click(sender As Object, e As EventArgs) Handles btnEmpListShow.Click
    '    DGVEmpList.Show()

    'End Sub

    Private Sub btnInitTrans_Click(sender As Object, e As EventArgs) Handles btnInitTrans.Click
        MsgBox("After you initialize the transaction, you will not be able to make changes to ORDER AMOUNT, EMPLOYEE and SUPPLIER data, nor backtrack or undo inputs. " _
               + "Please finalize inputs before pressing the Confirm button.")

        Me.btnConfInit.Visible = True
    End Sub

    Private Sub btnConfInit_Click(sender As Object, e As EventArgs) Handles btnConfInit.Click
        Try

            Dim CommandStr As String
            Dim DoCommand As DB2Command

            Dim VOrderNo As String = Me.txtOrderNo.Text
            Dim VDate As Date = Me.txtOrderDate.Text
            Dim VDateFormatted As String = VDate.ToString("MM-dd-yyyy")
            Dim VOrderAmt As Decimal = Decimal.Parse(Me.txtOrderAmt.Text)

            Dim VSupplierID As String = Me.txtSuppID.Text
            Dim VEmpID As Integer = Me.txtEmpID.Text


            CommandStr = "INSERT INTO order_tran VALUES('" & VOrderNo & "', '" & VEmpID & "', '" & VSupplierID & "', '" & VDateFormatted & "', " & VOrderAmt & ")"
            DoCommand = New DB2Command(CommandStr, DBConn)
            DoCommand.ExecuteNonQuery()

            MsgBox("Transaction initialization successful!")

            'Disable editing order section
            Me.txtOrderAmt.Enabled = False

            'Disable editing of supplier section '
            Me.btnEmpListShow.Enabled = False
            Me.DGVSuppliers.Enabled = False
            Me.btnInitTrans.Enabled = False
            Me.btnConfInit.Visible = False

            'Enable ingredient section '
            Me.radbtnIngrdID.Enabled = True
            Me.radbtnIngrdName.Enabled = True
            Me.btnRfrshIngd.Enabled = True
            Me.DGVIngredients.Enabled = True
            Me.txtQtyOrder.Enabled = True

            Me.txtQtyOrder.Focus()

            Me.btnShowAllDelv.Enabled = True
            Me.txtOrderDate.Enabled = False

        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        End Try

    End Sub

    Private Sub btnAddLinItm_Click(sender As Object, e As EventArgs) Handles btnAddLinItm.Click

        Try
            If String.IsNullOrEmpty(Me.txtQtyOrder.Text) Then
                MsgBox("ERROR! Please make sure the Quantity Ordered textbox is filled.")
            Else
                Dim CommandStr As String
                Dim DoCommand As DB2Command
                Dim VOrderLineNo As Integer = Integer.Parse(Me.txtLineNo.Text)
                Dim VOrderFMNo As String = Me.txtOrderNo.Text
                Dim VIngrdID As String = Me.txtIngrdID.Text
                Dim VQtyOrdered As Decimal = Decimal.Parse(Me.txtQtyOrder.Text)
                Dim VUnitMeas As String = Me.txtUnitMeas.Text

                CommandStr = "INSERT INTO order_line_item VALUES(" & VOrderLineNo & ", '" & VOrderFMNo & "', '" & VIngrdID & "', " & VQtyOrdered & ", '" & VUnitMeas & "')"
                DoCommand = New DB2Command(CommandStr, DBConn)
                DoCommand.ExecuteNonQuery()

                MsgBox("Insert successful!")
                MsgBox("Should you wish to insert more items Ordered by the same supplier, simply click on another ingredient in the Ingredient DGV.")

                Me.txtQtyOrder.Clear()
                Me.txtLineNo.Text = Integer.Parse(Me.txtLineNo.Text) + 1
                Me.btnShowThisOrder.Enabled = True
                Me.btnNewTrans.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    'New Transaction
    Private Sub btnNewTrans_Click(sender As Object, e As EventArgs) Handles btnNewTrans.Click
        Call InitializeForm()

        'Disable Suppliers section'

        With Me
            .DGVSuppliers.Enabled = False
            .btnInitTrans.Enabled = False

            .radbtnSuppID.Enabled = False
            .radbtnSuppName.Enabled = False
            .btnRfrshSupp.Enabled = False

            'Disable Ingredients section'
            .radbtnIngrdID.Enabled = False
            .radbtnIngrdName.Enabled = False
            .btnRfrshIngd.Enabled = False
            .DGVIngredients.Enabled = False

            .txtQtyOrder.Enabled = False

            .btnShowThisOrder.Enabled = False
            .btnAddLinItm.Enabled = False
            .btnNewTrans.Enabled = False
            .txtOrderDate.Enabled = True
        End With

        MsgBox("Form refreshed!")
    End Sub

    Private Sub btnShowAllDelv_Click(sender As Object, e As EventArgs) Handles btnShowAllDelv.Click
        DGVAllOrders.Show()
    End Sub

    Private Sub btnEditSuppRec_Click(sender As Object, e As EventArgs)
        Me.Hide()
        FrmSupplier.Show()
    End Sub

    Private Sub btnShowThisOrder_Click(sender As Object, e As EventArgs) Handles btnShowThisOrder.Click
        DGVThisOrder.Show()
    End Sub

    Private Sub RecordRelBtn_Click(sender As Object, e As EventArgs) Handles RecordRelBtn.Click
        Me.Hide()
        FrmReleaseRec.Show()
    End Sub

    Private Sub DGVSuppliers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVSuppliers.CellContentClick

    End Sub

    Private Sub OrderBtn_Click(sender As Object, e As EventArgs) Handles OrderBtn.Click
        Me.Hide()
        FrmReleaseRec.Show()
    End Sub

    Private Sub btnEmpListShow_Click(sender As Object, e As EventArgs) Handles btnEmpListShow.Click
        DGVEmpListFrmOrder.Show()
    End Sub
End Class