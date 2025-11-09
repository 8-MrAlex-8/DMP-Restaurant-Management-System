Imports IBM.Data.DB2
Public Class FrmReceipt
    Private DBConn As Common.DbConnection
    Private Sub ReceiptForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim CommandStr As String
        Dim DGVRow As String()
        Dim DoCommand As DB2Command
        Dim DGVReader As DB2DataReader

        Try
            DBConn = New DB2Connection("server=localhost;database=dmpccs5;" + "uid=db2admin;password=db2admin;")
            DBConn.Open()

            With Me.ReceiptDGV
                .ColumnCount = 7

                .Columns(0).Name = "Receipt Number"
                .Columns(1).Name = "Sal_Line Number"
                .Columns(2).Name = "Item ID"
                .Columns(3).Name = "Item Name"
                .Columns(4).Name = "Unit Price"
                .Columns(5).Name = "Quantity Bought"
                .Columns(6).Name = "Line Amount"

                .Columns(0).Width = 100
                .Columns(1).Width = 100
                .Columns(2).Width = 100
                .Columns(3).Width = 100
                .Columns(4).Width = 100
                .Columns(5).Width = 100
                .Columns(6).Width = 100
            End With

            CommandStr = "SELECT s.orno, s.sal_lineno, s.itemid, m.itemname, m.unitprice, s.qtybought, m.unitprice * s.qtybought AS lineamt FROM sales_line_item s JOIN menu_item m on s.ItemID = m.ItemID WHERE s.orno = '" & FrmRecSale.ORNoTB.Text & "' ORDER BY sal_lineno ASC "
            DoCommand = New DB2Command(CommandStr, DBConn)
            DGVReader = DoCommand.ExecuteReader

            While DGVReader.Read
                DGVRow = New String() {DGVReader.GetString(0), DGVReader.GetString(1), DGVReader.GetString(2), DGVReader.GetString(3), DGVReader.GetString(4), DGVReader.GetString(5), DGVReader.GetString(6)}
                Me.ReceiptDGV.Rows.Add(DGVRow)
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ReceiptDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ReceiptDGV.CellContentClick

    End Sub
End Class
