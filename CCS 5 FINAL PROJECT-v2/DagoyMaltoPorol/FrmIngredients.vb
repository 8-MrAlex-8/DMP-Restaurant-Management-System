Imports IBM.Data.DB2
Public Class FrmIngredients
    Private DBConn As Common.DbConnection

    Private Sub FrmIngredients_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DBConn = New DB2Connection("server=localhost;database=dmpccs5;" + "uid=db2admin;password=db2admin;")
        DBConn.Open()

        Try

            Call GetIngredientID()

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
                .Columns(3).Width = 70
                .Columns(4).Width = 80
                .Columns(5).Width = 50
                .Columns(6).Width = 80

            End With

            Call PopulateIngredientDGV()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

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

    Private Sub GetIngredientID()
        Try
            Dim VStr As String
            Dim VCmd As DB2Command
            Dim VRdr As DB2DataReader
            Dim VIngdID = Me.txtIngdID.Text
            Dim VPrefix As String = "P"
            VStr = "SELECT ingredientid FROM ingredient ORDER BY ingredientid desc"
            VCmd = New DB2Command(VStr, DBConn)
            VRdr = VCmd.ExecuteReader
            VRdr.Read()
            If VRdr.HasRows Then

                Dim numberPart As String = VRdr.GetString(0).Substring(VPrefix.Length)
                Dim newNumber As Integer = CInt(numberPart) + 1
                VIngdID = VPrefix & newNumber.ToString().PadLeft(numberPart.Length, "0"c)
            Else
                VIngdID = VPrefix & "1122"
            End If

            Me.txtIngdID.Text = VIngdID

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub IngredientRecBtn_Click(sender As Object, e As EventArgs) Handles IngredientRecBtn.Click

    End Sub

    Private Sub DelivBtn_Click(sender As Object, e As EventArgs) Handles DelivBtn.Click
        Me.Hide()
        FrmDeliveryTran.Show()
    End Sub

    Private Sub SupplierRecBtn_Click(sender As Object, e As EventArgs)
        Me.Hide()
        FrmSupplier.Show()
    End Sub

    Private Sub radbtnSuppID_CheckedChanged(sender As Object, e As EventArgs) Handles radbtnSuppID.CheckedChanged
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

    Private Sub radbtnSuppName_CheckedChanged(sender As Object, e As EventArgs) Handles radbtnSuppName.CheckedChanged
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

    Private Sub DGVIngredients_MouseUp(sender As Object, e As MouseEventArgs) Handles DGVIngredients.MouseUp
        Try
            With Me.DGVIngredients.CurrentRow
                Me.txtIngdID.Text = .Cells(0).Value
                Me.txtIngdName.Text = .Cells(1).Value
                Me.txtIngdStock.Text = .Cells(2).Value
                Me.txtIngdExp.Text = .Cells(3).Value
                Me.txtIngdRepPt.Text = .Cells(4).Value
                Me.txtIngdQtyToOrder.Text = .Cells(5).Value
                Me.txtUnitMeas.Text = .Cells(6).Value
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

    Private Sub ClearEntries()
        Me.txtIngdName.Clear()
        Me.txtIngdStock.Clear()
        Me.txtIngdExp.Clear()
        Me.txtIngdRepPt.Clear()
        Me.txtIngdQtyToOrder.Clear()
        Me.txtUnitMeas.Clear()
    End Sub

    Private Sub RecallBtn_Click(sender As Object, e As EventArgs) Handles RecallBtn.Click
        Call GetIngredientID()
        Call ClearEntries()
        With Me
            .btnCreate.Enabled = True
            .btnEdit.Enabled = False
            .btnDelete.Enabled = False
        End With
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click

        Try

            If String.IsNullOrEmpty(Me.txtIngdID.Text) Or String.IsNullOrEmpty(Me.txtIngdName.Text) _
                Or String.IsNullOrEmpty(Me.txtIngdStock.Text) Or String.IsNullOrEmpty(Me.txtIngdExp.Text) _
                Or String.IsNullOrEmpty(Me.txtIngdRepPt.Text) Or String.IsNullOrEmpty(Me.txtIngdQtyToOrder.Text) _
                Or String.IsNullOrEmpty(Me.txtUnitMeas.Text) Then

                MsgBox("ERROR! Please make sure that all textboxes are filled before proceeding.")

            Else
                Dim VStr As String
                Dim VCmd As DB2Command
                Dim VIngdID As String = Me.txtIngdID.Text
                Dim VIngdName As String = Me.txtIngdName.Text
                Dim VIngdStock As Decimal = Decimal.Parse(Me.txtIngdStock.Text)
                Dim VIngdExp As Date = Me.txtIngdExp.Text
                Dim VIngdReplPt As Decimal = Decimal.Parse(Me.txtIngdRepPt.Text)
                Dim VIngdQtyToOrder As Decimal = Decimal.Parse(Me.txtIngdQtyToOrder.Text)
                Dim VIngdUnitMeas As String = Me.txtUnitMeas.Text


                VStr = "INSERT INTO ingredient VALUES('" & VIngdID & "', '" & VIngdName & "', " & VIngdStock & ", '" & _
                        VIngdExp & "', " & VIngdReplPt & ", " & VIngdQtyToOrder & ", '" & VIngdUnitMeas & "')"

                VCmd = New DB2Command(VStr, DBConn)
                VCmd.ExecuteNonQuery()

                MsgBox("Ingredient record has been added successfully!")

                Me.btnCreate.Enabled = True
                Me.btnDelete.Enabled = False
                Me.btnEdit.Enabled = False

                Call PopulateIngredientDGV()
                Call ClearEntries()
                Call GetIngredientID()

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try

            If String.IsNullOrEmpty(Me.txtIngdID.Text) Or String.IsNullOrEmpty(Me.txtIngdName.Text) _
                Or String.IsNullOrEmpty(Me.txtIngdStock.Text) Or String.IsNullOrEmpty(Me.txtIngdExp.Text) _
                Or String.IsNullOrEmpty(Me.txtIngdRepPt.Text) Or String.IsNullOrEmpty(Me.txtIngdQtyToOrder.Text) _
                Or String.IsNullOrEmpty(Me.txtUnitMeas.Text) Then

                MsgBox("ERROR! Please make sure that all textboxes are filled before proceeding.")

            Else
                Dim VIngdID As String = Me.txtIngdID.Text
                Dim VIngdName As String = Me.txtIngdName.Text
                Dim VIngdStock As Decimal = Decimal.Parse(Me.txtIngdStock.Text)
                Dim VIngdExp As Date = Me.txtIngdExp.Text
                Dim VIngdReplPt As Decimal = Decimal.Parse(Me.txtIngdRepPt.Text)
                Dim VIngdQtyToOrder As Decimal = Decimal.Parse(Me.txtIngdQtyToOrder.Text)
                Dim VIngdUnitMeas As String = Me.txtUnitMeas.Text
                Dim VStr As String
                Dim VCmd As DB2Command

                VStr = "UPDATE ingredient SET ingredientid = '" & VIngdID & "',  ingredientname = '" & VIngdName & "', noinstock = " & VIngdStock & ", expiredate = '" & _
                            VIngdExp & "', replenishpt = " & VIngdReplPt & ", notoorder = " & VIngdQtyToOrder & ", unitmeas = '" & _
                            VIngdUnitMeas & "' WHERE ingredientid = '" & VIngdID & "'"
                    VCmd = New DB2Command(VStr, DBConn)
                    VCmd.ExecuteNonQuery()

                MsgBox("Ingredient record has been edited successfully!")

                Me.btnCreate.Enabled = True
                Me.btnDelete.Enabled = False
                Me.btnEdit.Enabled = False

                Call PopulateIngredientDGV()
                Call ClearEntries()
                Call GetIngredientID()

            End If
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim VStr As String
        Dim VCmd As DB2Command

        Try
            VStr = "DELETE FROM ingredient WHERE ingredientid = '" & Me.txtIngdID.Text & "'"

            VCmd = New DB2Command(VStr, DBConn)

            VCmd.ExecuteNonQuery()

            MsgBox("Ingredient record is deleted successfully.")

            Me.btnCreate.Enabled = True
            Me.btnDelete.Enabled = False
            Me.btnEdit.Enabled = False

            Call PopulateIngredientDGV()
            Call ClearEntries()
            Call GetIngredientID()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub OrderBtn_Click(sender As Object, e As EventArgs) Handles OrderBtn.Click
        Me.Hide()
        FrmOrder.Show()
    End Sub
End Class