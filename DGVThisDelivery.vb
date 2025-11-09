Imports IBM.Data.DB2
Public Class DGVThisDelivery
    Private DBConn As Common.DbConnection

    Private Sub DGVThisDelivery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DBConn = New DB2Connection("server=localhost;database=dmpccs5;" + "uid=db2admin;password=db2admin;")
            DBConn.Open()

            With Me.dgvTHISDelReceiptRec
                .ColumnCount = 6
                .Columns(0).Name = "Line No."
                .Columns(1).Name = "Delivery Receipt No."
                .Columns(2).Name = "Ingredient ID"
                .Columns(3).Name = "Quantity Delivered"
                .Columns(4).Name = "Unit of Measurement"
                .Columns(5).Name = "Line Amount"
                .Columns(0).Width = 80
                .Columns(1).Width = 100
                .Columns(2).Width = 100
                .Columns(3).Width = 70
                .Columns(4).Width = 70
                .Columns(5).Width = 100
            End With

            Call Populate_Grid()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Populate_Grid()
        Dim vStr As String
        Dim VCmdPop As DB2Command
        Dim VRdrPop As DB2DataReader
        Dim VRow As String()
        Dim DRNo As String = FrmDeliveryTran.txtDRNo.Text

        Try
            vStr = "SELECT * FROM delv_line_item WHERE drno = '" & DRNo & "'"
            VCmdPop = New DB2Command(vStr, DBConn)
            VRdrPop = VCmdPop.ExecuteReader
            Me.dgvTHISDelReceiptRec.Rows.Clear()

            While VRdrPop.Read
                VRow = New String() {VRdrPop.GetString(0), VRdrPop.GetString(1), VRdrPop.GetString(2), VRdrPop.GetString(3), VRdrPop.GetString(4), VRdrPop.GetString(5)}
                Me.dgvTHISDelReceiptRec.Rows.Add(VRow)
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnRfrshDGV_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        FrmDeliveryTran.Show()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.dgvTHISDelReceiptRec.Rows.Clear()
        Call Populate_Grid()
    End Sub

End Class