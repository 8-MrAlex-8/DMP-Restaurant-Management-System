Imports IBM.Data.DB2
Public Class FrmRecSale
    Private DBConn As Common.DbConnection

    Private Sub SalesRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DBConn = New DB2Connection("server=localhost;database=dmpccs5;" + "uid=db2admin;password=db2admin;")
            DBConn.Open()

            Call InitializeForm()
            Call CheckPermission()

        Catch ex As Exception
            MsgBox(ex.ToString)

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

    Private Function GetORNumber()
        Dim VStr As String
        Dim VOrNo As Integer
        Dim VCmd As DB2Command
        Dim VRdr As DB2DataReader

        'TEST REMARK: successfully sets ORNo'
        Try
            VStr = "SELECT orno FROM sales_tran ORDER BY orno DESC"
            VCmd = New DB2Command(VStr, DBConn)
            VRdr = VCmd.ExecuteReader
            VRdr.Read()
            If VRdr.HasRows Then
                VOrNo = VRdr.GetString(0) + 1
            Else
                VOrNo = 10000
            End If

            Return VOrNo

        Catch ex As Exception
            MsgBox(ex.ToString)
            Return "0"

        End Try
    End Function

    Private Function GetCustNo()
        Dim VStr As String
        Dim VCustNo As Integer
        Dim VCmd As DB2Command
        Dim VRdr As DB2DataReader

        'TEST REMARK: successfully sets CustNo'
        Try
            VStr = "SELECT customerno FROM customer ORDER BY customerno DESC"
            VCmd = New DB2Command(VStr, DBConn)
            VRdr = VCmd.ExecuteReader
            VRdr.Read()

            If VRdr.HasRows Then
                VCustNo = VRdr.GetString(0) + 1
            Else
                VCustNo = 1
            End If

            Return VCustNo

        Catch ex As Exception
            MsgBox(ex.ToString)
            Return 0

        End Try
    End Function

    Private Function GetSalLineNo()
        Dim VStr As String
        Dim VSalLineNo As Integer
        Dim VCmd As DB2Command
        Dim VRdr As DB2DataReader

        'TEST REMARK: Increments properly and is successfully called by InsertSalesLineItem sub'
        Try
            VStr = "SELECT sal_lineno FROM sales_line_item ORDER BY sal_lineno DESC"

            VCmd = New DB2Command(VStr, DBConn)
            VRdr = VCmd.ExecuteReader
            VRdr.Read()

            If VRdr.HasRows Then
                VSalLineNo = VRdr.GetString(0) + 1
            Else
                VSalLineNo = 1
            End If

            Return VSalLineNo

        Catch ex As Exception
            MsgBox(ex.ToString)
            Return 0

        End Try
    End Function

    Private Sub IncrementQty(sender As Object, e As EventArgs) Handles Item1Qty_IncBtn.Click, Item2Qty_IncBtn.Click, Item3Qty_IncBtn.Click, Item4Qty_IncBtn.Click, Item5Qty_IncBtn.Click,
                                                                        Item6Qty_IncBtn.Click, Item7Qty_IncBtn.Click, Item8Qty_IncBtn.Click, Item9Qty_IncBtn.Click, Item10Qty_IncBtn.Click,
                                                                        Item11Qty_IncBtn.Click, Item12Qty_IncBtn.Click, Item13Qty_IncBtn.Click, Item14Qty_IncBtn.Click, Item15Qty_IncBtn.Click,
                                                                        Item16Qty_IncBtn.Click, Item17Qty_IncBtn.Click, Item18Qty_IncBtn.Click, Item19Qty_IncBtn.Click, Item20Qty_IncBtn.Click

        Dim clicked_QtyButton As Button = DirectCast(sender, Button)

        Try
            Select Case clicked_QtyButton.Name
                Case "Item1Qty_IncBtn"
                    Me.Item1Qty.Text = IncrementValue(Item1Qty.Text)
                    Me.Item1_LineAmtTxtBx.Text = ComputeLineItemAmt(Me.Item1IDTxtBx.Text, Me.Item1Qty.Text)

                Case "Item2Qty_IncBtn"
                    Me.Item2Qty.Text = IncrementValue(Item2Qty.Text)
                    Me.Item2_LineAmtTxtBx.Text = ComputeLineItemAmt(Me.Item2IDTxtBx.Text, Me.Item2Qty.Text)

                Case "Item3Qty_IncBtn"
                    Me.Item3Qty.Text = IncrementValue(Item3Qty.Text)
                    Me.Item3_LineAmtTxtBx.Text = ComputeLineItemAmt(Me.Item3IDTxtBx.Text, Me.Item3Qty.Text)

                Case "Item4Qty_IncBtn"
                    Me.Item4Qty.Text = IncrementValue(Item4Qty.Text)
                    Me.Item4_LineAmtTxtBx.Text = ComputeLineItemAmt(Me.Item4IDTxtBx.Text, Me.Item4Qty.Text)

                Case "Item5Qty_IncBtn"
                    Me.Item5Qty.Text = IncrementValue(Item5Qty.Text)
                    Me.Item5_LineAmtTxtBx.Text = ComputeLineItemAmt(Me.Item5IDTxtBx.Text, Me.Item5Qty.Text)

                Case "Item6Qty_IncBtn"
                    Me.Item6Qty.Text = IncrementValue(Item6Qty.Text)
                    Me.Item6_LineAmtTxtBx.Text = ComputeLineItemAmt(Me.Item6IDTxtBx.Text, Me.Item6Qty.Text)

                Case "Item7Qty_IncBtn"
                    Me.Item7Qty.Text = IncrementValue(Item7Qty.Text)
                    Me.Item7_LineAmtTxtBx.Text = ComputeLineItemAmt(Me.Item7IDTxtBx.Text, Me.Item7Qty.Text)

                Case "Item8Qty_IncBtn"
                    Me.Item8Qty.Text = IncrementValue(Item8Qty.Text)
                    Me.Item8_LineAmtTxtBx.Text = ComputeLineItemAmt(Me.Item8IDTxtBx.Text, Me.Item8Qty.Text)

                Case "Item9Qty_IncBtn"
                    Me.Item9Qty.Text = IncrementValue(Item9Qty.Text)
                    Me.Item9_LineAmtTxtBx.Text = ComputeLineItemAmt(Me.Item9IDTxtBx.Text, Me.Item9Qty.Text)

                Case "Item10Qty_IncBtn"
                    Me.Item10Qty.Text = IncrementValue(Item10Qty.Text)
                    Me.Item10_LineAmtTxtBx.Text = ComputeLineItemAmt(Me.Item10IDTxtBx.Text, Me.Item10Qty.Text)

                Case "Item11Qty_IncBtn"
                    Me.Item11Qty.Text = IncrementValue(Item11Qty.Text)
                    Me.Item11_LineAmtTxtBx.Text = ComputeLineItemAmt(Me.Item11IDTxtBx.Text, Me.Item11Qty.Text)

                Case "Item12Qty_IncBtn"
                    Me.Item12Qty.Text = IncrementValue(Item12Qty.Text)
                    Me.Item12_LineAmtTxtBx.Text = ComputeLineItemAmt(Me.Item12IDTxtBx.Text, Me.Item12Qty.Text)

                Case "Item13Qty_IncBtn"
                    Me.Item13Qty.Text = IncrementValue(Item13Qty.Text)
                    Me.Item13_LineAmtTxtBx.Text = ComputeLineItemAmt(Me.Item13IDTxtBx.Text, Me.Item13Qty.Text)

                Case "Item14Qty_IncBtn"
                    Me.Item14Qty.Text = IncrementValue(Item14Qty.Text)
                    Me.Item14_LineAmtTxtBx.Text = ComputeLineItemAmt(Me.Item14IDTxtBx.Text, Me.Item14Qty.Text)

                Case "Item15Qty_IncBtn"
                    Me.Item15Qty.Text = IncrementValue(Item15Qty.Text)
                    Me.Item15_LineAmtTxtBx.Text = ComputeLineItemAmt(Me.Item15IDTxtBx.Text, Me.Item15Qty.Text)

                Case "Item16Qty_IncBtn"
                    Me.Item16Qty.Text = IncrementValue(Item16Qty.Text)
                    Me.Item16_LineAmtTxtBx.Text = ComputeLineItemAmt(Me.Item16IDTxtBx.Text, Me.Item16Qty.Text)

                Case "Item17Qty_IncBtn"
                    Me.Item17Qty.Text = IncrementValue(Item17Qty.Text)
                    Me.Item17_LineAmtTxtBx.Text = ComputeLineItemAmt(Me.Item17IDTxtBx.Text, Me.Item17Qty.Text)

                Case "Item18Qty_IncBtn"
                    Me.Item18Qty.Text = IncrementValue(Item18Qty.Text)
                    Me.Item18_LineAmtTxtBx.Text = ComputeLineItemAmt(Me.Item18IDTxtBx.Text, Me.Item18Qty.Text)

                Case "Item19Qty_IncBtn"
                    Me.Item19Qty.Text = IncrementValue(Item19Qty.Text)
                    Me.Item19_LineAmtTxtBx.Text = ComputeLineItemAmt(Me.Item19IDTxtBx.Text, Me.Item19Qty.Text)

                Case "Item20Qty_IncBtn"
                    Me.Item20Qty.Text = IncrementValue(Item20Qty.Text)
                    Me.Item20_LineAmtTxtBx.Text = ComputeLineItemAmt(Me.Item20IDTxtBx.Text, Me.Item20Qty.Text)
            End Select

            Call GetTransactionTotal()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub

    Private Sub DecrementQty(sender As Object, e As EventArgs) Handles Item1Qty_DecBtn.Click, Item2Qty_DecBtn.Click, Item3Qty_DecBtn.Click, Item4Qty_DecBtn.Click, Item5Qty_DecBtn.Click,
                                                                        Item6Qty_DecBtn.Click, Item7Qty_DecBtn.Click, Item8Qty_DecBtn.Click, Item9Qty_DecBtn.Click, Item10Qty_DecBtn.Click,
                                                                        Item11Qty_DecBtn.Click, Item12Qty_DecBtn.Click, Item13Qty_DecBtn.Click, Item14Qty_DecBtn.Click, Item15Qty_DecBtn.Click,
                                                                        Item16Qty_DecBtn.Click, Item17Qty_DecBtn.Click, Item18Qty_DecBtn.Click, Item19Qty_DecBtn.Click, Item20Qty_DecBtn.Click

        Dim clicked_QtyButton As Button = DirectCast(sender, Button)

        Try
            Select Case clicked_QtyButton.Name
                Case "Item1Qty_DecBtn"
                    Me.Item1Qty.Text = DecrementValue(Item1Qty.Text)
                    Me.Item1_LineAmtTxtBx.Text = ComputeLineItemAmt(Me.Item1IDTxtBx.Text, Me.Item1Qty.Text)

                Case "Item2Qty_DecBtn"
                    Me.Item2Qty.Text = DecrementValue(Item2Qty.Text)
                    Me.Item2_LineAmtTxtBx.Text = ComputeLineItemAmt(Me.Item2IDTxtBx.Text, Me.Item2Qty.Text)

                Case "Item3Qty_DecBtn"
                    Me.Item3Qty.Text = DecrementValue(Item3Qty.Text)
                    Me.Item3_LineAmtTxtBx.Text = ComputeLineItemAmt(Me.Item3IDTxtBx.Text, Me.Item3Qty.Text)

                Case "Item4Qty_DecBtn"
                    Me.Item4Qty.Text = DecrementValue(Item4Qty.Text)
                    Me.Item4_LineAmtTxtBx.Text = ComputeLineItemAmt(Me.Item4IDTxtBx.Text, Me.Item4Qty.Text)

                Case "Item5Qty_DecBtn"
                    Me.Item5Qty.Text = DecrementValue(Item5Qty.Text)
                    Me.Item5_LineAmtTxtBx.Text = ComputeLineItemAmt(Me.Item5IDTxtBx.Text, Me.Item5Qty.Text)

                Case "Item6Qty_DecBtn"
                    Me.Item6Qty.Text = DecrementValue(Item6Qty.Text)
                    Me.Item6_LineAmtTxtBx.Text = ComputeLineItemAmt(Me.Item6IDTxtBx.Text, Me.Item6Qty.Text)

                Case "Item7Qty_DecBtn"
                    Me.Item7Qty.Text = DecrementValue(Item7Qty.Text)
                    Me.Item7_LineAmtTxtBx.Text = ComputeLineItemAmt(Me.Item7IDTxtBx.Text, Me.Item7Qty.Text)

                Case "Item8Qty_DecBtn"
                    Me.Item8Qty.Text = DecrementValue(Item8Qty.Text)
                    Me.Item8_LineAmtTxtBx.Text = ComputeLineItemAmt(Me.Item8IDTxtBx.Text, Me.Item8Qty.Text)

                Case "Item9Qty_DecBtn"
                    Me.Item9Qty.Text = DecrementValue(Item9Qty.Text)
                    Me.Item9_LineAmtTxtBx.Text = ComputeLineItemAmt(Me.Item9IDTxtBx.Text, Me.Item9Qty.Text)

                Case "Item10Qty_DecBtn"
                    Me.Item10Qty.Text = DecrementValue(Item10Qty.Text)
                    Me.Item10_LineAmtTxtBx.Text = ComputeLineItemAmt(Me.Item10IDTxtBx.Text, Me.Item10Qty.Text)

                Case "Item11Qty_DecBtn"
                    Me.Item11Qty.Text = DecrementValue(Item11Qty.Text)
                    Me.Item11_LineAmtTxtBx.Text = ComputeLineItemAmt(Me.Item11IDTxtBx.Text, Me.Item11Qty.Text)

                Case "Item12Qty_DecBtn"
                    Me.Item12Qty.Text = DecrementValue(Item12Qty.Text)
                    Me.Item12_LineAmtTxtBx.Text = ComputeLineItemAmt(Me.Item12IDTxtBx.Text, Me.Item12Qty.Text)

                Case "Item13Qty_DecBtn"
                    Me.Item13Qty.Text = DecrementValue(Item13Qty.Text)
                    Me.Item13_LineAmtTxtBx.Text = ComputeLineItemAmt(Me.Item13IDTxtBx.Text, Me.Item13Qty.Text)

                Case "Item14Qty_DecBtn"
                    Me.Item14Qty.Text = DecrementValue(Item14Qty.Text)
                    Me.Item14_LineAmtTxtBx.Text = ComputeLineItemAmt(Me.Item14IDTxtBx.Text, Me.Item14Qty.Text)

                Case "Item15Qty_DecBtn"
                    Me.Item15Qty.Text = DecrementValue(Item15Qty.Text)
                    Me.Item15_LineAmtTxtBx.Text = ComputeLineItemAmt(Me.Item15IDTxtBx.Text, Me.Item15Qty.Text)

                Case "Item16Qty_DecBtn"
                    Me.Item16Qty.Text = DecrementValue(Item16Qty.Text)
                    Me.Item16_LineAmtTxtBx.Text = ComputeLineItemAmt(Me.Item16IDTxtBx.Text, Me.Item16Qty.Text)

                Case "Item17Qty_DecBtn"
                    Me.Item17Qty.Text = DecrementValue(Item17Qty.Text)
                    Me.Item17_LineAmtTxtBx.Text = ComputeLineItemAmt(Me.Item17IDTxtBx.Text, Me.Item17Qty.Text)

                Case "Item18Qty_DecBtn"
                    Me.Item18Qty.Text = DecrementValue(Item18Qty.Text)
                    Me.Item18_LineAmtTxtBx.Text = ComputeLineItemAmt(Me.Item18IDTxtBx.Text, Me.Item18Qty.Text)

                Case "Item19Qty_DecBtn"
                    Me.Item19Qty.Text = DecrementValue(Item19Qty.Text)
                    Me.Item19_LineAmtTxtBx.Text = ComputeLineItemAmt(Me.Item19IDTxtBx.Text, Me.Item19Qty.Text)

                Case "Item20Qty_DecBtn"
                    Me.Item20Qty.Text = DecrementValue(Item20Qty.Text)
                    Me.Item20_LineAmtTxtBx.Text = ComputeLineItemAmt(Me.Item20IDTxtBx.Text, Me.Item20Qty.Text)
            End Select

            Call GetTransactionTotal()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Function IncrementValue(value As String) As String

        Dim currentValue As Integer = 0

        Integer.TryParse(value, currentValue)
        currentValue += 1
        Return currentValue.ToString()

    End Function

    Private Function DecrementValue(value As String) As String

        Dim currentValue As Integer = 0

        Integer.TryParse(value, currentValue)

        'Trapping: Do not allow negative values'
        If currentValue > 0 Then
            currentValue -= 1
        End If

        Return currentValue.ToString()

    End Function

    Private Sub GetTransactionTotal()
        Dim TransTtl As Decimal = 0

        'Using a for-loop to shorten what was supposed to be TransTtl += Me.Item1_LineAmtTxtBx.Text; TransTtl += Me.Item2_LineAmtTxtBx.Text;...; TransTtl += Me.Item20_LineAmtTxtBx.Text'

        'TEST REMARK: successfully increments current transaction cost as user increases/decreases quantity of goods bought'

        For i As Integer = 1 To 20
            Dim TxtBoxName As String = "Item" & i & "_LineAmtTxtBx"
            Dim VTextBox As TextBox = CType(Me.Controls(TxtBoxName), TextBox) 'typecasting'
            TransTtl += Decimal.Parse(VTextBox.Text)
        Next

        Me.TotalPriceLabel.Text = Decimal.Round(TransTtl, 2)

    End Sub

    Private Function ComputeLineItemAmt(ItemID As String, ItemQty As String)
        Dim VQty As Decimal
        Dim VPrice As Decimal = 0
        Dim CommandStr As String
        Dim DoCommand As DB2Command
        Dim Vreadr As DB2DataReader

        Try
            VQty = Decimal.Parse(ItemQty)

            CommandStr = "SELECT unitprice * '" & VQty & "' AS totalprice FROM menu_item WHERE itemid = '" & ItemID & "' "
            DoCommand = New DB2Command(CommandStr, DBConn)

            Vreadr = DoCommand.ExecuteReader
            Vreadr.Read()

            If Vreadr.HasRows Then
                VPrice = Vreadr.GetDecimal(0)
            Else
                VPrice = 0
            End If

            Return Decimal.Round(VPrice, 2)

        Catch ex As Exception
            MsgBox(ex.ToString)
            Return 0

        End Try
    End Function

    Private Sub ViewTranReceiptBtn_Click(sender As Object, e As EventArgs) Handles ViewTranReceiptBtn.Click
        FrmReceipt.Show()
    End Sub

    Private Sub CustSaveBtn_Click(sender As Object, e As EventArgs) Handles CustSaveBtn.Click
        Dim CommandStr As String
        Dim DoCommand As DB2Command
        Dim VReader As DB2DataReader

        Try

            Dim CustName As String = Me.CustNameTB.Text
            Dim CustNo As Decimal
            Decimal.TryParse(Me.CustNumTB.Text, CustNo)

            'TRAPPING: Don't allow adding/subtracting quantities in the form without pressing the Save Customer Data Button.'

            'Note: Functionally, the CustomerName column is nullable (optional), and you can still proceed 
            'despite not inputting a name. 

            'TEST REMARK: successfully adds into customer table'
            CommandStr = "INSERT INTO customer VALUES('" & CustNo & "', '" & CustName & "')"
            DoCommand = New DB2Command(CommandStr, DBConn)

            DoCommand.ExecuteNonQuery()

            Me.CustNameTB.Enabled = False
            Me.CustSaveBtn.Enabled = False
            Me.DateTB.Enabled = False

            'Enables the manipulation of quantities in the form by enabling the qtyinc and qtydec buttons per item'
            For i As Integer = 1 To 20

                'Item ID Section--for accessing the value of ItemID and setting up the query'
                Dim IDTxtBoxName As String = "Item" & i & "IDTxtBx"
                Dim CIDTxtBoxName As TextBox = CType(Me.Controls(IDTxtBoxName), TextBox)
                Dim ItemID = CIDTxtBoxName.Text

                'Item PicBox Section--for possible trapping UI when item is out of stock'
                Dim PicBoxObj As String = "Item" & i & "PicBox"
                Dim CPicBoxObj As PictureBox = CType(Me.Controls(PicBoxObj), PictureBox)

                'Item OutofStk Label Section--for possible trapping UI when item is out of stock'
                Dim OutofStkLabel As String = "Item" & i & "_OutStkLabel"
                Dim COutofStkLabel As Label = CType(Me.Controls(OutofStkLabel), Label)

                'Item QtyTxtBox Section--for disabling/enabling manipulation of Item Quantity to be purchased'
                Dim QtyTxtBoxName As String = "Item" & i & "Qty"
                Dim CTextBox As TextBox = CType(Me.Controls(QtyTxtBoxName), TextBox) 'typecasting'

                'Item QtyIncBtn Section--for disabling/enabling access to QtyInc buttons, depending on item availability'
                Dim QtyIncBtn As String = "Item" & i & "Qty_IncBtn"
                Dim CIncBtn As Button = CType(Me.Controls(QtyIncBtn), Button) 'typecasting'

                'Item QtyDecBtn Section--for disabling/enabling access to QtyDec buttons, depending on item availability'
                Dim QtyDecBtn As String = "Item" & i & "Qty_DecBtn"
                Dim CDecBtn As Button = CType(Me.Controls(QtyDecBtn), Button) 'typecasting'

                'Checks if there are items out of stock'
                CommandStr = "SELECT * FROM menu_item WHERE itemid = '" & ItemID & "' AND unitcount = '0'"
                DoCommand = New DB2Command(CommandStr, DBConn)
                VReader = DoCommand.ExecuteReader()

                'If a particular item is out of stock, disable quantity manipulation and show that it's out of stock'
                If VReader.HasRows Then
                    CPicBoxObj.Visible = False
                    COutofStkLabel.Visible = True
                    CTextBox.Enabled = False
                    CIncBtn.Enabled = False
                    CDecBtn.Enabled = False
                Else
                    CTextBox.Enabled = True
                    CIncBtn.Enabled = True
                    CDecBtn.Enabled = True
                End If

            Next

            Me.btnCheckInv.Enabled = True
            Me.RecordSaleBtn.Enabled = True
            Me.VoidTransBtn.Enabled = True
            MsgBox("Customer data saved successfully!")

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub ZeroAll()
        For i As Integer = 1 To 20

            Dim QtyTxtBoxName As String = "Item" & i & "Qty" 'Corresponds to VTextBox'
            Dim LineAmtTxtBoxName As String = "Item" & i & "_LineAmtTxtBx" 'Corresponds to VTextBox2'
            Dim VTextBox As TextBox = CType(Me.Controls(QtyTxtBoxName), TextBox) 'typecasting'
            Dim VTextBox2 As TextBox = CType(Me.Controls(LineAmtTxtBoxName), TextBox)

            If VTextBox IsNot Nothing Then
                VTextBox.Text = "0"
            End If
            If VTextBox2 IsNot Nothing Then
                VTextBox2.Text = "0.00"
            End If
        Next

        TotalPriceLabel.Text = "0.00"
    End Sub

    Private Sub RecordSaleBtn_Click(sender As Object, e As EventArgs) Handles RecordSaleBtn.Click
        Dim CommandStr As String
        Dim DoCommand As DB2Command
        Dim ORNo As Decimal = Me.ORNoTB.Text
        Dim CustNo As Decimal = Me.CustNumTB.Text
        Dim EmpID As String = Me.EmployeeIDTB.Text
        Dim VDate As Date = Me.DateTB.Text
        Dim VDateFormatted As String = VDate.ToString("MM-dd-yyyy")
        Dim TTL_CostSales As Decimal = Me.TotalPriceLabel.Text

        Try

            'CHECK: If items to be deducted are not greater than the amount available for sale'
            For i As Integer = 1 To 20
                Dim QtyTxtBoxName As String = "Item" & i & "Qty" 'Item Qty'
                Dim ItemIDBoxName As String = "Item" & i & "IDTxtBx" 'Item ID'
                Dim VIDTextBox As TextBox = CType(Me.Controls(ItemIDBoxName), TextBox)
                Dim VQtyTextBox As TextBox = CType(Me.Controls(QtyTxtBoxName), TextBox)

                Dim IsEnough As Boolean = CheckInventory(VQtyTextBox.Text, VIDTextBox.Text)
                If Not IsEnough Then
                    Call ZeroAll()
                    Exit Sub
                End If
            Next

            'TEST REMARK: successfully adds into sales_tran table'
            CommandStr = "INSERT INTO sales_tran VALUES('" & ORNo & "', '" & CustNo & "', '" & EmpID & "', '" & VDateFormatted & "', '" & TTL_CostSales & "')"
            DoCommand = New DB2Command(CommandStr, DBConn)

            DoCommand.ExecuteNonQuery()

            For i As Integer = 1 To 20
                Dim ItemIDBoxName As String = "Item" & i & "IDTxtBx" 'Item ID'
                Dim QtyTxtBoxName As String = "Item" & i & "Qty" 'Item Qty'
                Dim LineAmtTxtBoxName As String = "Item" & i & "_LineAmtTxtBx" 'Total Line Amt'
                Dim QtyIncBtn As String = "Item" & i & "Qty_IncBtn"
                Dim QtyDecBtn As String = "Item" & i & "Qty_DecBtn"

                'typecasting'
                Dim VIDTextBox As TextBox = CType(Me.Controls(ItemIDBoxName), TextBox)
                Dim VQtyTextBox As TextBox = CType(Me.Controls(QtyTxtBoxName), TextBox)
                Dim VLnAmtTextBox As TextBox = CType(Me.Controls(LineAmtTxtBoxName), TextBox)
                Dim VIncBtn As Button = CType(Me.Controls(QtyIncBtn), Button)
                Dim VDecBtn As Button = CType(Me.Controls(QtyDecBtn), Button)

                'TEST REMARK: successfully decreases QtyInStock on menu_item table'

                UpdateQuantity(VIDTextBox.Text, VQtyTextBox.Text)
                InsertSalesLineItem(VIDTextBox.Text, VQtyTextBox.Text, VLnAmtTextBox.Text)

                VQtyTextBox.Enabled = False
                VIncBtn.Enabled = False
                VDecBtn.Enabled = False
            Next

            Me.RecordSaleBtn.Enabled = False
            Me.VoidTransBtn.Enabled = False
            Me.NewTransBtn.Enabled = True

            MsgBox("Transaction data saved successfully!")
            Me.ViewTranReceiptBtn.Enabled = True

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Function CheckInventory(Quantity As String, ItemID As String)

        Dim QtyBought As Decimal = Decimal.Parse(Quantity)
        Dim CommandStr As String
        Dim DoCommand As DB2Command
        Dim VRdr As DB2DataReader

        Try
            CommandStr = "SELECT * FROM menu_item WHERE itemid = '" & ItemID & "' AND unitcount >= '" & QtyBought & "' "
            DoCommand = New DB2Command(CommandStr, DBConn)
            VRdr = DoCommand.ExecuteReader
            VRdr.Read()
            If VRdr.HasRows = False Then
                MsgBox("Error! You are attempting to sell item/s at an amount which is over the number in stock. Please check current inventory and review the transaction.")
                Return False
            Else
                Return True
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try

    End Function

    Private Sub UpdateQuantity(ItemID As String, Qtyvalue As String)
        'ItemID is naturally a string, while Qtyvalue is expected to be a decimal.'

        Dim VQuantity As Decimal
        Dim CommandStr As String
        Dim DoCommand As DB2Command

        Try
            VQuantity = Decimal.Parse(Qtyvalue)

            CommandStr = "UPDATE menu_item SET unitcount = unitcount - '" & VQuantity & "' WHERE itemid = '" & ItemID & "'"
            DoCommand = New DB2Command(CommandStr, DBConn)

            DoCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub InsertSalesLineItem(ItemID As String, Qtyvalue As String, Lineamount As String)
        Dim Sal_LineNo As Decimal = GetSalLineNo()
        Dim ORNo As Decimal = Me.ORNoTB.Text
        Dim QtyBought As Decimal
        Dim LineAmt As Decimal

        Dim CommandStr As String
        Dim DoCommand As DB2Command

        Try
            QtyBought = Decimal.Parse(Qtyvalue) 'QtyBought'
            LineAmt = Decimal.Parse(Lineamount) 'Line amount'

            'TEST REMARK: successfully inserts into receipt all purchased items.'
            If QtyBought > 0 Then
                CommandStr = "INSERT INTO sales_line_item VALUES('" & Sal_LineNo & "', '" & ORNo & "', '" & ItemID & "', '" & QtyBought & "', " & LineAmt & ")"
                DoCommand = New DB2Command(CommandStr, DBConn)

                DoCommand.ExecuteNonQuery()
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub VoidTransBtn_Click(sender As Object, e As EventArgs) Handles VoidTransBtn.Click
        Call ZeroAll()
    End Sub

    Private Sub NewTransBtn_Click(sender As Object, e As EventArgs) Handles NewTransBtn.Click
        Call ZeroAll()
        Call InitializeForm()
        MsgBox("Form refreshed!")
    End Sub

    Private Sub InitializeForm() 'Refreshes form to what it is like during the first load'

        Dim CommandStr As String
        Dim DoCommand As DB2Command
        Dim VReader As DB2DataReader

        Me.DateTB.Text = Date.Now.Date.ToString("MM/dd/yyyy")
        Me.DateTB.Enabled = True
        Me.ORNoTB.Text = GetORNumber()
        Me.CustNumTB.Text = GetCustNo()
        Me.CustNameTB.Enabled = True
        Me.CustNameTB.Text = ""
        Me.CustSaveBtn.Enabled = True

        Try
            For i As Integer = 1 To 20

                Dim IDTxtBoxName As String = "Item" & i & "IDTxtBx"
                Dim CIDTxtBoxName As TextBox = CType(Me.Controls(IDTxtBoxName), TextBox)
                Dim ItemID = CIDTxtBoxName.Text

                Dim PicBoxObj As String = "Item" & i & "PicBox"
                Dim CPicBoxObj As PictureBox = CType(Me.Controls(PicBoxObj), PictureBox)

                Dim OutofStkLabel As String = "Item" & i & "_OutStkLabel"
                Dim COutofStkLabel As Label = CType(Me.Controls(OutofStkLabel), Label)

                Dim QtyTxtBoxName As String = "Item" & i & "Qty"
                Dim CTextBox As TextBox = CType(Me.Controls(QtyTxtBoxName), TextBox) 'typecasting'

                Dim QtyIncBtn As String = "Item" & i & "Qty_IncBtn"
                Dim CIncBtn As Button = CType(Me.Controls(QtyIncBtn), Button) 'typecasting'

                Dim QtyDecBtn As String = "Item" & i & "Qty_DecBtn"
                Dim CDecBtn As Button = CType(Me.Controls(QtyDecBtn), Button) 'typecasting'

                'Checks if there are items out of stock'
                CommandStr = "SELECT * FROM menu_item WHERE itemid = '" & ItemID & "' AND unitcount = '0'"
                DoCommand = New DB2Command(CommandStr, DBConn)
                VReader = DoCommand.ExecuteReader()

                'If a particular item is out of stock, disable quantity manipulation and show that it's out of stock'
                If VReader.HasRows Then
                    CPicBoxObj.Visible = False
                    COutofStkLabel.Visible = True
                Else
                    CPicBoxObj.Visible = True
                    COutofStkLabel.Visible = False
                End If

                CTextBox.Enabled = False
                CIncBtn.Enabled = False
                CDecBtn.Enabled = False

            Next

            Me.RecordSaleBtn.Enabled = False
            Me.VoidTransBtn.Enabled = False
            Me.ViewTranReceiptBtn.Enabled = False
            Me.NewTransBtn.Enabled = False
            Me.TotalPriceLabel.Text = "0.00"

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
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

    Private Sub btnCheckInv_Click(sender As Object, e As EventArgs) Handles btnCheckInv.Click
        MenuItemInventory.Show()
    End Sub

    Private Sub RecordRelBtn_Click(sender As Object, e As EventArgs) Handles RecordRelBtn.Click
        Me.Hide()
        FrmReleaseRec.Show()
    End Sub

    Private Sub OrderBtn_Click(sender As Object, e As EventArgs) Handles OrderBtn.Click
        Me.Hide()
        FrmOrder.Show()
    End Sub
    Private Sub SaleBtn_Click(sender As Object, e As EventArgs) Handles SaleBtn.Click

    End Sub
End Class
