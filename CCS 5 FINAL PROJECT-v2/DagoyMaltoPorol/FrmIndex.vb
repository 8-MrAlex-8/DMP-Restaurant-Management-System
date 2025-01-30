Imports IBM.Data.DB2
Public Class FrmIndex
    Private DBConn As Common.DbConnection

    Private Sub IndexForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DBConn = New DB2Connection("server=localhost;database=dmpccs5;" + "uid=db2admin;password=db2admin;")
            DBConn.Open()

            Me.SaleBtn.Enabled = False
            Me.DelivBtn.Enabled = False
            Me.CustRecBtn.Enabled = False
            Me.SalesRecBtn.Enabled = False
            Me.LoginPass.Visible = False
            Me.LoginFail.Visible = False

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub

    Private Sub TryLoginBtn_Click(sender As Object, e As EventArgs) Handles TryLoginBtn.Click
        Dim VStr As String
        Dim VCmd As DB2Command
        Dim DRead As DB2DataReader
        Dim Emptype As String

        Me.LoginPass.Visible = False
        Me.LoginFail.Visible = False

        Try
            'Search Employee Record for match'
            VStr = " SELECT * FROM employee WHERE empid = '" & Me.TextEmpID.Text & "' and empname = '" & Me.TextEmpName.Text & "' "
            VCmd = New DB2Command(VStr, DBConn)
            DRead = VCmd.ExecuteReader()
            DRead.Read()

            ' If EmpID exists... '
            If DRead.HasRows Then
                Me.LoginPass.Visible = True
                Me.TextEmpID.Enabled = False
                Me.TextEmpName.Enabled = False

                VStr = " SELECT emptype FROM employee WHERE empid = '" & Me.TextEmpID.Text & "'"
                VCmd = New DB2Command(VStr, DBConn)

                DRead = VCmd.ExecuteReader()
                DRead.Read()

                If DRead.HasRows Then
                    Emptype = DRead("emptype").ToString()

                    Select Case Emptype

                        Case "C" 'Cook'
                            Me.DelivBtn.Enabled = True
                            Call PostRole("C")

                        Case "P" 'Cashier'
                            Me.SaleBtn.Enabled = True
                            Me.DelivBtn.Enabled = True
                            Me.SalesRecBtn.Enabled = True
                            Call PostRole("P")

                        Case "I" 'Inventory Custodian'
                            Me.DelivBtn.Enabled = True
                            Me.RecordRelBtn.Enabled = True
                            Call PostRole("I")

                    End Select
                End If

                Me.CustRecBtn.Enabled = True
                Me.EmpRecBtn.Enabled = True
                Me.OrderBtn.Enabled = True
                Call PostID()

                ' If EmpID DNE '
            Else
                Me.TextEmpID.Clear()
                Me.TextEmpName.Clear()
                Me.LoginFail.Visible = True
                Me.TextEmpID.Focus()
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub PostID()
        FrmRecSale.EmployeeIDTB.Text = Me.TextEmpID.Text
        FrmSalesList.EmployeeIDTB.Text = Me.TextEmpID.Text
        FrmCustList.EmployeeIDTB.Text = Me.TextEmpID.Text
        FrmEmployee.EmployeeIDTB.Text = Me.TextEmpID.Text
        FrmDeliveryTran.EmployeeIDTB.Text = Me.TextEmpID.Text
        FrmReleaseRec.EmployeeIDTB.Text = Me.TextEmpID.Text
        FrmOrder.EmployeeIDTB.Text = Me.TextEmpID.Text
    End Sub

    Private Sub PostRole(role As String)
        FrmRecSale.ShowRoleTB.Text = role
        FrmSalesList.ShowRoleTB.Text = role
        FrmCustList.ShowRoleTB.Text = role
        FrmEmployee.ShowRoleTB.Text = role
        FrmDeliveryTran.ShowRoleTB.Text = role
        FrmReleaseRec.ShowRoleTB.Text = role
        FrmOrder.ShowRoleTB.Text = role
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

    Private Sub SalesRecBtn_Click(sender As Object, e As EventArgs) Handles SalesRecBtn.Click
        Me.Hide()
        FrmSalesList.Show()
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        DBConn.Close()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles RecordRelBtn.Click
        Me.Hide()
        FrmReleaseRec.Show()
    End Sub

    Private Sub OrderBtn_Click(sender As Object, e As EventArgs) Handles OrderBtn.Click
        Me.Hide()
        FrmOrder.Show()
    End Sub
End Class
