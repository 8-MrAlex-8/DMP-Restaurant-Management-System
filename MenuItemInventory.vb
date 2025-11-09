Imports IBM.Data.DB2
Public Class MenuItemInventory
    Private DBConn As Common.DbConnection

    Private Sub MenuItemInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim CommandStr As String
        Dim DGVRow As String()
        Dim DoCommand As DB2Command
        Dim DGVReader As DB2DataReader

        Try
            DBConn = New DB2Connection("server=localhost;database=dmpccs5;" + "uid=db2admin;password=db2admin;")
            DBConn.Open()

            With Me.MenuItemDGV
                .ColumnCount = 5

                .Columns(0).Name = "Item ID"
                .Columns(1).Name = "Item Name"
                .Columns(2).Name = "Unit Meas."
                .Columns(3).Name = "Unit Price"
                .Columns(4).Name = "Unit Count"


                .Columns(0).Width = 100
                .Columns(1).Width = 100
                .Columns(2).Width = 100
                .Columns(3).Width = 100
                .Columns(4).Width = 100

            End With

            CommandStr = "SELECT * FROM menu_item ORDER BY itemid ASC"
            DoCommand = New DB2Command(CommandStr, DBConn)
            DGVReader = DoCommand.ExecuteReader

            While DGVReader.Read
                DGVRow = New String() {DGVReader.GetString(0), DGVReader.GetString(1), DGVReader.GetString(2), DGVReader.GetString(3), DGVReader.GetString(4)}
                Me.MenuItemDGV.Rows.Add(DGVRow)
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub MenuItemDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MenuItemDGV.CellContentClick

    End Sub
End Class