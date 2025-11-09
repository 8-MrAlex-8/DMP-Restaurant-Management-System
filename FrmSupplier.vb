Imports IBM.Data.DB2
Public Class FrmSupplier
    Private DBConn As Common.DbConnection

    Private Sub FrmSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            DBConn = New DB2Connection("server=localhost;database=dmpccs5;" + "uid=db2admin;password=db2admin;")
            DBConn.Open()

            Call GetSuppID()

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

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub GetSuppID()
        Dim VStr As String
        Dim VCmd As DB2Command
        Dim VRdr As DB2DataReader
        Dim VSuppID = Me.txtSuppID.Text
        Dim VPrefix As String = "A"
        Try
            VStr = "SELECT supplierid FROM supplier ORDER BY supplierid desc"
            VCmd = New DB2Command(VStr, DBConn)
            VRdr = VCmd.ExecuteReader
            VRdr.Read()
            If VRdr.HasRows Then
                ' Extract the numeric part from the drno using Substring method, which returns a substring 
                ' encapsulating the character starting from a specific index to the end of the string. Below,
                ' the substring is from index 2 ('3') to the end of the string ('0').
                Dim numberPart As String = VRdr.GetString(0).Substring(VPrefix.Length)

                ' Increment Value 
                Dim newNumber As Integer = CInt(numberPart) + 1

                ' Concatenate the prefix with the new incremented number, ensuring leading zeros are preserved
                VSuppID = VPrefix & newNumber.ToString().PadLeft(numberPart.Length, "0"c)
            Else
                VSuppID = VPrefix & "19001"
            End If
            Me.txtSuppID.Text = VSuppID

        Catch ex As Exception
            MsgBox(ex.ToString)
            End Try
    End Sub

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

    Private Sub DGVSuppliers_MouseUp(sender As Object, e As MouseEventArgs) Handles DGVSuppliers.MouseUp

        Try
            With Me.DGVSuppliers.CurrentRow
                Me.txtSuppID.Text = .Cells(0).Value
                Me.txtSuppName.Text = .Cells(1).Value
                Me.txtContNo.Text = .Cells(2).Value
            End With

            With Me
                .btnCreate.Enabled = False
                .btnEdit.Enabled = True
                .btnDelete.Enabled = True
            End With

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub DelivBtn_Click(sender As Object, e As EventArgs) Handles DelivBtn.Click
        Me.Hide()
        FrmDeliveryTran.Show()
    End Sub

    Private Sub IngredientRecBtn_Click(sender As Object, e As EventArgs)
        Me.Hide()
        FrmIngredients.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim VStr As String
        Dim VCmd As DB2Command

        Try
            VStr = "DELETE FROM supplier WHERE supplierid = '" & Me.txtSuppID.Text & "'"

            VCmd = New DB2Command(VStr, DBConn)

            VCmd.ExecuteNonQuery()

            MsgBox("Employee record is deleted successfully.")

            Me.btnCreate.Enabled = True
            Me.btnDelete.Enabled = False
            Me.btnEdit.Enabled = False

            Call PopulateSupplierDGV()
            Call ClearEntries()
            Call GetSuppID()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ClearEntries()
        Me.txtSuppID.Clear()
        Me.txtContNo.Clear()
        Me.txtSuppName.Clear()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim VStr As String
        Dim VCmd As DB2Command

        Try
            If String.IsNullOrEmpty(Me.txtSuppID.Text) Or String.IsNullOrEmpty(Me.txtSuppName.Text) Or String.IsNullOrEmpty(Me.txtContNo.Text) Then
                MsgBox("ERROR! Please make sure that all textboxes are filled before creating a record.")
            Else

                VStr = "INSERT INTO supplier VALUES('" & Me.txtSuppID.Text & "' , '" & Me.txtSuppName.Text & "', '" & Me.txtContNo.Text & "')"
                VCmd = New DB2Command(VStr, DBConn)
                VCmd.ExecuteNonQuery()

                MsgBox("Supplier record has been added successfully!")

                Me.btnCreate.Enabled = True
                Me.btnDelete.Enabled = False
                Me.btnEdit.Enabled = False

                Call PopulateSupplierDGV()
                Call ClearEntries()
                Call GetSuppID()

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim VStr As String
        Dim VCmd As DB2Command

        Try
            VStr = "UPDATE supplier SET supplierid = '" & Me.txtSuppID.Text & "', suppliername = '" & Me.txtSuppName.Text & "', " _
                & "contactno = '" & Me.txtContNo.Text & "' WHERE supplierid = '" & Me.txtSuppID.Text & "'"
            VCmd = New DB2Command(VStr, DBConn)
            VCmd.ExecuteNonQuery()

            MsgBox("Supplier record has been edited successfully!")

            Me.btnCreate.Enabled = True
            Me.btnDelete.Enabled = False
            Me.btnEdit.Enabled = False

            Call PopulateSupplierDGV()
            Call ClearEntries()
            Call GetSuppID()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub RecallBtn_Click(sender As Object, e As EventArgs) Handles RecallBtn.Click
        Call ClearEntries()
        Call GetSuppID()
        Me.btnCreate.Enabled = True
        Me.btnDelete.Enabled = False
        Me.btnEdit.Enabled = False
    End Sub


    Private Sub OrderBtn_Click(sender As Object, e As EventArgs) Handles OrderBtn.Click
        Me.Hide()
        FrmOrder.Show()
    End Sub
End Class