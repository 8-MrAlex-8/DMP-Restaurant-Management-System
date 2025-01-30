Imports IBM.Data.DB2
Public Class DGVEmpListFrmRelease
    Private DBConn As Common.DbConnection

    Private Sub DGVEmpList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DBConn = New DB2Connection("server=localhost;database=dmpccs5;" + "uid=db2admin;password=db2admin;")
            DBConn.Open()

            With Me.dgvEmpRecs
                .ColumnCount = 3
                .Columns(0).Name = "EmpID"
                .Columns(1).Name = "EmpName"
                .Columns(2).Name = "EmpType"
                .Columns(0).Width = 100
                .Columns(1).Width = 200
                .Columns(2).Width = 80
            End With

            Call Populate_Grid()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub dgvEmpRecs_MouseUp(sender As Object, e As MouseEventArgs) Handles dgvEmpRecs.MouseUp
        Try
            FrmReleaseRec.txtEmpID.Text = Me.dgvEmpRecs.CurrentRow.Cells(0).Value
            FrmReleaseRec.txtEmpName.Text = Me.dgvEmpRecs.CurrentRow.Cells(1).Value
            FrmReleaseRec.txtRole.Text = Me.dgvEmpRecs.CurrentRow.Cells(2).Value
            FrmReleaseRec.txtSearchIngredientName.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub Populate_Grid()
        Dim vStr As String
        Dim VCmdPop As DB2Command
        Dim VRdrPop As DB2DataReader
        Dim VRow As String()

        Try
            vStr = "SELECT EmpID, EmpName, EmpType FROM employee"
            VCmdPop = New DB2Command(vStr, DBConn)
            VRdrPop = VCmdPop.ExecuteReader
            Me.dgvEmpRecs.Rows.Clear()

            While VRdrPop.Read
                VRow = New String() {VRdrPop.GetString(0), VRdrPop.GetString(1), VRdrPop.GetString(2)}
                Me.dgvEmpRecs.Rows.Add(VRow)
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        FrmReleaseRec.Show()
    End Sub
End Class
