﻿Imports IBM.Data.DB2

Public Class DGVThisOrder
    Private DBConn As Common.DbConnection

    Private Sub DGVThisOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DBConn = New DB2Connection("server=localhost;database=dmpccs5;" + "uid=db2admin;password=db2admin;")
            DBConn.Open()

            With Me.DGVThisOrderRec
                .ColumnCount = 5
                .Columns(0).Name = "Line No."
                .Columns(1).Name = "Order No."
                .Columns(2).Name = "Ingredient ID"
                .Columns(3).Name = "Quantity Ordered"
                .Columns(4).Name = "Unit of Measurement"
                .Columns(0).Width = 100
                .Columns(1).Width = 120
                .Columns(2).Width = 120
                .Columns(3).Width = 90
                .Columns(4).Width = 90
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
        Dim OrderFMNo As String = FrmOrder.txtOrderNo.Text

        Try
            vStr = "SELECT * FROM order_line_item WHERE ordfmno = '" & OrderFMNo & "'"
            VCmdPop = New DB2Command(vStr, DBConn)
            VRdrPop = VCmdPop.ExecuteReader
            Me.DGVThisOrderRec.Rows.Clear()

            While VRdrPop.Read
                VRow = New String() {VRdrPop.GetString(0), VRdrPop.GetString(1), VRdrPop.GetString(2), VRdrPop.GetString(3), VRdrPop.GetString(4)}
                Me.DGVThisOrderRec.Rows.Add(VRow)
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnRfrshDGV_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        FrmOrder.Show()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.DGVThisOrderRec.Rows.Clear()
        Call Populate_Grid()
    End Sub

    Private Sub DGVThisOrderRec_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVThisOrderRec.CellContentClick

    End Sub
End Class