Imports IBM.Data.DB2

Public Class FrmSalesList
    Private DBConn As Common.DbConnection

    'Button Close
    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        DBConn.Close()
        Me.Close()
    End Sub

    'Sales Report Load
    Private Sub FrmSalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            DBConn = New DB2Connection("server=localhost;database=dmpccs5;" + "uid=db2admin;password=db2admin;")
            DBConn.Open()

            With Me.DGVSalesReport
                .ColumnCount = 5
                .Columns(0).Name = "OR Number"
                .Columns(1).Name = "Customer Number"
                .Columns(2).Name = "Employee ID"
                .Columns(3).Name = "Date"
                .Columns(4).Name = "Total Sales"
                .Columns(0).Width = 100
                .Columns(1).Width = 100
                .Columns(2).Width = 100
                .Columns(3).Width = 100
                .Columns(4).Width = 95
            End With

            Call Populate_LeftGrid()

            With Me.DGVSalesLineItemReport
                .ColumnCount = 5
                .Columns(0).Name = "Sale Line Number"
                .Columns(1).Name = "OR Number"
                .Columns(2).Name = "Item ID"
                .Columns(3).Name = "Quantity Bought"
                .Columns(4).Name = "Line Amount"
                .Columns(0).Width = 80
                .Columns(1).Width = 100
                .Columns(2).Width = 80
                .Columns(3).Width = 60
                .Columns(4).Width = 80

            End With

            Call Populate_RightGrid()

            Call CheckPermission()
            Call CountSales()

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

    'Populate SalesTran Grid
    Private Sub Populate_LeftGrid()
        Dim vStr As String
        Dim VCmdPop As DB2Command
        Dim VRdrPop As DB2DataReader
        Dim VRow As String()
        Dim totalSales As Decimal = 0

        Try
            vStr = "SELECT * FROM Sales_Tran"
            VCmdPop = New DB2Command(vStr, DBConn)
            VRdrPop = VCmdPop.ExecuteReader()

            Me.DGVSalesReport.Rows.Clear()

            While VRdrPop.Read()
                VRow = New String() {
                    VRdrPop.GetString(VRdrPop.GetOrdinal("ORNo")),
                    VRdrPop.GetString(VRdrPop.GetOrdinal("CustomerNo")),
                    VRdrPop.GetString(VRdrPop.GetOrdinal("EmpID")),
                    VRdrPop.GetString(VRdrPop.GetOrdinal("Date")),
                    VRdrPop.GetString(VRdrPop.GetOrdinal("TTL_CostSales"))
                }

                Me.DGVSalesReport.Rows.Add(VRow)

                totalSales += Convert.ToDecimal(VRdrPop.GetString(4))
            End While

            VRdrPop.Close()

            Me.txtSalesTotal.Text = totalSales.ToString("F2")

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    'Populate SalesLineItem Grid
    Private Sub Populate_RightGrid()
        Dim vStr As String
        Dim VCmdPop As DB2Command
        Dim VRdrPop As DB2DataReader
        Dim VRow As String()

        Try
            vStr = "SELECT * FROM sales_line_item"
            VCmdPop = New DB2Command(vStr, DBConn)
            VRdrPop = VCmdPop.ExecuteReader()

            Me.DGVSalesLineItemReport.Rows.Clear()

            While VRdrPop.Read()
                VRow = New String() {
                    VRdrPop.GetString(0),
                    VRdrPop.GetString(1),
                    VRdrPop.GetString(2),
                    VRdrPop.GetString(3),
                    VRdrPop.GetString(4)
                }

                Me.DGVSalesLineItemReport.Rows.Add(VRow)

            End While

            VRdrPop.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub CountSales()
        Dim CommandStr As String
        Dim DoCommand As DB2Command
        Dim AllSales As Integer

        For i As Integer = 1 To 20
            Dim IDTxtBx As String = "Item" & i & "IDTxtBx"
            Dim QtySoldTxtBx As String = "tb" & i & "QtySold"
            Dim CIDTxtBx As TextBox = CType(Me.Controls(IDTxtBx), TextBox) 'typecasting'
            Dim CQtySoldTxtBx As TextBox = CType(Me.Controls(QtySoldTxtBx), TextBox) 'typecasting'

            CommandStr = "SELECT coalesce(sum(qtybought), 0) as total from sales_line_item WHERE itemid = '" & CIDTxtBx.Text & "' "
            DoCommand = New DB2Command(CommandStr, DBConn)

            ' Use ExecuteScalar to get the total sales. This returns the first column of the first row in the result of the query.'

            Dim result = DoCommand.ExecuteScalar()
            If result IsNot Nothing Then
                AllSales = Convert.ToInt32(result)
            Else
                AllSales = 0
            End If

            CQtySoldTxtBx.Text = AllSales.ToString()
        Next
    End Sub

    'Search by date (Left DGV)
    Private Sub txtSearchDate_TextChanged(sender As Object, e As EventArgs) Handles txtSearchDate.TextChanged
        Dim VstrSearch As String
        Dim Vstr As String
        Dim VCmdSearch As DB2Command
        Dim VRdrSearch As DB2DataReader
        Dim Vrow As String()
        Dim totalSales As Decimal = 0.0

        Try
            Vstr = "%" + Me.txtSearchDate.Text + "%"

            VstrSearch = "SELECT ORNo, CustomerNo, EmpID, Date, TTL_CostSales FROM Sales_Tran WHERE Date LIKE '" & Vstr & "' ORDER BY Date ASC"

            VCmdSearch = New DB2Command(VstrSearch, DBConn)
            VRdrSearch = VCmdSearch.ExecuteReader

            Me.DGVSalesReport.Rows.Clear()
            While VRdrSearch.Read
                Vrow = New String() {
                    VRdrSearch.GetString(0),
                    VRdrSearch.GetString(1),
                    VRdrSearch.GetString(2),
                    VRdrSearch.GetString(3),
                    VRdrSearch.GetString(4)
                }
                Me.DGVSalesReport.Rows.Add(Vrow)
                totalSales += Convert.ToDecimal(VRdrSearch.GetString(VRdrSearch.GetOrdinal("TTL_CostSales")))
            End While

            Me.txtSalesTotal.Text = totalSales.ToString("F2")

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    'Search by ID and/or ORNo (Right DGV)
    Private Sub txtbSearchID_TextChanged(sender As Object, e As EventArgs) Handles txtbSearchID.TextChanged, txtbSearchORno.TextChanged
        Dim VstrSearch As String
        Dim Vstr As String
        Dim Vstr2 As String
        Dim VCmdSearch As DB2Command
        Dim VRdrSearch As DB2DataReader
        Dim Vrow As String()

        Try
            Vstr = "%" + Me.txtbSearchID.Text + "%"
            Vstr2 = "%" + Me.txtbSearchORno.Text + "%"
            VstrSearch = "SELECT sal_lineno, orno, itemid, qtybought FROM sales_line_item WHERE itemid LIKE '" & Vstr & "' AND orno LIKE '" & Vstr2 & "' ORDER BY orno ASC"
            VCmdSearch = New DB2Command(VstrSearch, DBConn)
            VRdrSearch = VCmdSearch.ExecuteReader

            Me.DGVSalesLineItemReport.Rows.Clear()
            While VRdrSearch.Read
                Vrow = New String() {
                    VRdrSearch.GetString(0),
                    VRdrSearch.GetString(1),
                    VRdrSearch.GetString(2),
                    VRdrSearch.GetString(3)
                }
                Me.DGVSalesLineItemReport.Rows.Add(Vrow)
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnRfrshDGV_Click(sender As Object, e As EventArgs) Handles btnRfrshDGV.Click
        Me.DGVSalesReport.Rows.Clear()
        Me.DGVSalesLineItemReport.Rows.Clear()
        Call Populate_LeftGrid()
        Call Populate_RightGrid()
        Call CountSales()
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

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        DBConn.Close()
        Me.Close()
    End Sub

    Private Sub picbxHelp_Click(sender As Object, e As EventArgs) Handles picbxHelp.Click
        MsgBox("Dates not appearing? Try appending 0 in front of ones numbers ('06' for '6') and replace backslash separator '/' with a dash '-'. " _
               & "If you're trying to include the year, follow YYYY-MM-DD format.")
    End Sub

    Private Sub picbxHelp2_Click(sender As Object, e As EventArgs) Handles picbxHelp2.Click
        MsgBox("Transactions not reflecting yet? Press this button to refresh the Data Grid Views and Sales Per Item Section.")
    End Sub

    Private Sub txtSalesTotal_TextChanged(sender As Object, e As EventArgs) Handles txtSalesTotal.TextChanged

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
