<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIndex
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIndex))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EmpIdLabel = New System.Windows.Forms.Label()
        Me.TextEmpID = New System.Windows.Forms.TextBox()
        Me.TryLoginBtn = New System.Windows.Forms.Button()
        Me.LoginPass = New System.Windows.Forms.Label()
        Me.LoginFail = New System.Windows.Forms.Label()
        Me.TextEmpName = New System.Windows.Forms.TextBox()
        Me.FullNameLabel = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.OrderBtn = New System.Windows.Forms.Button()
        Me.RecordRelBtn = New System.Windows.Forms.Button()
        Me.EmpRecBtn = New System.Windows.Forms.Button()
        Me.DecorBtn = New System.Windows.Forms.Button()
        Me.CustRecBtn = New System.Windows.Forms.Button()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.SalesRecBtn = New System.Windows.Forms.Button()
        Me.SaleBtn = New System.Windows.Forms.Button()
        Me.DelivBtn = New System.Windows.Forms.Button()
        Me.HomeBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1285, 46)
        Me.Panel1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(346, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "HOME | RESTAURANT MANAGEMENT SYSTEM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(333, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(799, 43)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "WELCOME TO DMP RESTAURANT MANAGEMENT SYSTEM!"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(444, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(577, 34)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Please Enter your Employee ID and Full Name to Continue."
        '
        'EmpIdLabel
        '
        Me.EmpIdLabel.AutoSize = True
        Me.EmpIdLabel.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpIdLabel.Location = New System.Drawing.Point(535, 330)
        Me.EmpIdLabel.Name = "EmpIdLabel"
        Me.EmpIdLabel.Size = New System.Drawing.Size(132, 30)
        Me.EmpIdLabel.TabIndex = 10
        Me.EmpIdLabel.Text = "EMPLOYEE ID"
        '
        'TextEmpID
        '
        Me.TextEmpID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextEmpID.Location = New System.Drawing.Point(706, 333)
        Me.TextEmpID.Name = "TextEmpID"
        Me.TextEmpID.Size = New System.Drawing.Size(190, 20)
        Me.TextEmpID.TabIndex = 11
        Me.TextEmpID.Text = "1"
        '
        'TryLoginBtn
        '
        Me.TryLoginBtn.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TryLoginBtn.Location = New System.Drawing.Point(690, 440)
        Me.TryLoginBtn.Name = "TryLoginBtn"
        Me.TryLoginBtn.Size = New System.Drawing.Size(86, 37)
        Me.TryLoginBtn.TabIndex = 12
        Me.TryLoginBtn.Text = "Enter"
        Me.TryLoginBtn.UseVisualStyleBackColor = True
        '
        'LoginPass
        '
        Me.LoginPass.AutoSize = True
        Me.LoginPass.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginPass.Location = New System.Drawing.Point(600, 517)
        Me.LoginPass.Name = "LoginPass"
        Me.LoginPass.Size = New System.Drawing.Size(267, 28)
        Me.LoginPass.TabIndex = 13
        Me.LoginPass.Text = "Login Success! Welcome."
        '
        'LoginFail
        '
        Me.LoginFail.AutoSize = True
        Me.LoginFail.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginFail.Location = New System.Drawing.Point(600, 517)
        Me.LoginFail.Name = "LoginFail"
        Me.LoginFail.Size = New System.Drawing.Size(263, 28)
        Me.LoginFail.TabIndex = 14
        Me.LoginFail.Text = "Error! Record not found."
        '
        'TextEmpName
        '
        Me.TextEmpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextEmpName.Location = New System.Drawing.Point(706, 380)
        Me.TextEmpName.Name = "TextEmpName"
        Me.TextEmpName.Size = New System.Drawing.Size(190, 20)
        Me.TextEmpName.TabIndex = 16
        Me.TextEmpName.Text = "ADMIN"
        '
        'FullNameLabel
        '
        Me.FullNameLabel.AutoSize = True
        Me.FullNameLabel.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullNameLabel.Location = New System.Drawing.Point(535, 375)
        Me.FullNameLabel.Name = "FullNameLabel"
        Me.FullNameLabel.Size = New System.Drawing.Size(113, 30)
        Me.FullNameLabel.TabIndex = 15
        Me.FullNameLabel.Text = "FULL NAME"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.Controls.Add(Me.OrderBtn)
        Me.Panel2.Controls.Add(Me.RecordRelBtn)
        Me.Panel2.Controls.Add(Me.EmpRecBtn)
        Me.Panel2.Controls.Add(Me.DecorBtn)
        Me.Panel2.Controls.Add(Me.CustRecBtn)
        Me.Panel2.Controls.Add(Me.CloseBtn)
        Me.Panel2.Controls.Add(Me.SalesRecBtn)
        Me.Panel2.Controls.Add(Me.SaleBtn)
        Me.Panel2.Controls.Add(Me.DelivBtn)
        Me.Panel2.Controls.Add(Me.HomeBtn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 46)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(203, 675)
        Me.Panel2.TabIndex = 17
        '
        'OrderBtn
        '
        Me.OrderBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.OrderBtn.Enabled = False
        Me.OrderBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.OrderBtn.FlatAppearance.BorderSize = 0
        Me.OrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OrderBtn.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderBtn.Image = CType(resources.GetObject("OrderBtn.Image"), System.Drawing.Image)
        Me.OrderBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OrderBtn.Location = New System.Drawing.Point(0, 272)
        Me.OrderBtn.Name = "OrderBtn"
        Me.OrderBtn.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.OrderBtn.Size = New System.Drawing.Size(202, 68)
        Me.OrderBtn.TabIndex = 211
        Me.OrderBtn.Text = "Record Order"
        Me.OrderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OrderBtn.UseVisualStyleBackColor = False
        '
        'RecordRelBtn
        '
        Me.RecordRelBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.RecordRelBtn.Enabled = False
        Me.RecordRelBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.RecordRelBtn.FlatAppearance.BorderSize = 0
        Me.RecordRelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RecordRelBtn.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecordRelBtn.Image = CType(resources.GetObject("RecordRelBtn.Image"), System.Drawing.Image)
        Me.RecordRelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RecordRelBtn.Location = New System.Drawing.Point(-2, 204)
        Me.RecordRelBtn.Name = "RecordRelBtn"
        Me.RecordRelBtn.Padding = New System.Windows.Forms.Padding(20, 0, 16, 0)
        Me.RecordRelBtn.Size = New System.Drawing.Size(204, 68)
        Me.RecordRelBtn.TabIndex = 210
        Me.RecordRelBtn.Text = "Record Release"
        Me.RecordRelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RecordRelBtn.UseVisualStyleBackColor = False
        '
        'EmpRecBtn
        '
        Me.EmpRecBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.EmpRecBtn.Enabled = False
        Me.EmpRecBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.EmpRecBtn.FlatAppearance.BorderSize = 0
        Me.EmpRecBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EmpRecBtn.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpRecBtn.Image = CType(resources.GetObject("EmpRecBtn.Image"), System.Drawing.Image)
        Me.EmpRecBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EmpRecBtn.Location = New System.Drawing.Point(0, 408)
        Me.EmpRecBtn.Name = "EmpRecBtn"
        Me.EmpRecBtn.Padding = New System.Windows.Forms.Padding(20, 0, 48, 0)
        Me.EmpRecBtn.Size = New System.Drawing.Size(202, 68)
        Me.EmpRecBtn.TabIndex = 18
        Me.EmpRecBtn.Text = "Employee"
        Me.EmpRecBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EmpRecBtn.UseVisualStyleBackColor = False
        '
        'DecorBtn
        '
        Me.DecorBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.DecorBtn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.DecorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DecorBtn.Location = New System.Drawing.Point(0, 0)
        Me.DecorBtn.Name = "DecorBtn"
        Me.DecorBtn.Size = New System.Drawing.Size(9, 68)
        Me.DecorBtn.TabIndex = 17
        Me.DecorBtn.UseVisualStyleBackColor = False
        '
        'CustRecBtn
        '
        Me.CustRecBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.CustRecBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.CustRecBtn.FlatAppearance.BorderSize = 0
        Me.CustRecBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CustRecBtn.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustRecBtn.Image = CType(resources.GetObject("CustRecBtn.Image"), System.Drawing.Image)
        Me.CustRecBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CustRecBtn.Location = New System.Drawing.Point(0, 340)
        Me.CustRecBtn.Name = "CustRecBtn"
        Me.CustRecBtn.Padding = New System.Windows.Forms.Padding(20, 0, 47, 0)
        Me.CustRecBtn.Size = New System.Drawing.Size(202, 68)
        Me.CustRecBtn.TabIndex = 7
        Me.CustRecBtn.Text = "Customer"
        Me.CustRecBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CustRecBtn.UseVisualStyleBackColor = False
        '
        'CloseBtn
        '
        Me.CloseBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.CloseBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.CloseBtn.FlatAppearance.BorderSize = 0
        Me.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseBtn.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Image = CType(resources.GetObject("CloseBtn.Image"), System.Drawing.Image)
        Me.CloseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CloseBtn.Location = New System.Drawing.Point(0, 544)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Padding = New System.Windows.Forms.Padding(20, 0, 76, 0)
        Me.CloseBtn.Size = New System.Drawing.Size(202, 68)
        Me.CloseBtn.TabIndex = 5
        Me.CloseBtn.Text = "Close"
        Me.CloseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CloseBtn.UseVisualStyleBackColor = False
        '
        'SalesRecBtn
        '
        Me.SalesRecBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.SalesRecBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.SalesRecBtn.FlatAppearance.BorderSize = 0
        Me.SalesRecBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SalesRecBtn.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesRecBtn.Image = CType(resources.GetObject("SalesRecBtn.Image"), System.Drawing.Image)
        Me.SalesRecBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SalesRecBtn.Location = New System.Drawing.Point(0, 476)
        Me.SalesRecBtn.Name = "SalesRecBtn"
        Me.SalesRecBtn.Padding = New System.Windows.Forms.Padding(20, 0, 25, 0)
        Me.SalesRecBtn.Size = New System.Drawing.Size(202, 68)
        Me.SalesRecBtn.TabIndex = 4
        Me.SalesRecBtn.Text = "Sales Records"
        Me.SalesRecBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SalesRecBtn.UseVisualStyleBackColor = False
        '
        'SaleBtn
        '
        Me.SaleBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.SaleBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.SaleBtn.FlatAppearance.BorderSize = 0
        Me.SaleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaleBtn.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaleBtn.Image = CType(resources.GetObject("SaleBtn.Image"), System.Drawing.Image)
        Me.SaleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SaleBtn.Location = New System.Drawing.Point(0, 68)
        Me.SaleBtn.Name = "SaleBtn"
        Me.SaleBtn.Padding = New System.Windows.Forms.Padding(20, 0, 37, 0)
        Me.SaleBtn.Size = New System.Drawing.Size(202, 68)
        Me.SaleBtn.TabIndex = 1
        Me.SaleBtn.Text = "Record Sale"
        Me.SaleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SaleBtn.UseVisualStyleBackColor = False
        '
        'DelivBtn
        '
        Me.DelivBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DelivBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DelivBtn.FlatAppearance.BorderSize = 0
        Me.DelivBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DelivBtn.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelivBtn.Image = CType(resources.GetObject("DelivBtn.Image"), System.Drawing.Image)
        Me.DelivBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DelivBtn.Location = New System.Drawing.Point(0, 136)
        Me.DelivBtn.Name = "DelivBtn"
        Me.DelivBtn.Padding = New System.Windows.Forms.Padding(20, 0, 12, 0)
        Me.DelivBtn.Size = New System.Drawing.Size(202, 68)
        Me.DelivBtn.TabIndex = 3
        Me.DelivBtn.Text = "Record Delivery"
        Me.DelivBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DelivBtn.UseVisualStyleBackColor = False
        '
        'HomeBtn
        '
        Me.HomeBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.HomeBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.HomeBtn.FlatAppearance.BorderSize = 0
        Me.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HomeBtn.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeBtn.Image = CType(resources.GetObject("HomeBtn.Image"), System.Drawing.Image)
        Me.HomeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.HomeBtn.Location = New System.Drawing.Point(0, 0)
        Me.HomeBtn.Name = "HomeBtn"
        Me.HomeBtn.Padding = New System.Windows.Forms.Padding(20, 0, 75, 0)
        Me.HomeBtn.Size = New System.Drawing.Size(202, 68)
        Me.HomeBtn.TabIndex = 2
        Me.HomeBtn.Text = "Home"
        Me.HomeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.HomeBtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.DagoyMaltoPorol.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(519, 68)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(414, 146)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'FrmIndex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1285, 721)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TextEmpName)
        Me.Controls.Add(Me.FullNameLabel)
        Me.Controls.Add(Me.LoginPass)
        Me.Controls.Add(Me.TryLoginBtn)
        Me.Controls.Add(Me.TextEmpID)
        Me.Controls.Add(Me.EmpIdLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LoginFail)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmIndex"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log In Form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents EmpIdLabel As System.Windows.Forms.Label
    Friend WithEvents TextEmpID As System.Windows.Forms.TextBox
    Friend WithEvents TryLoginBtn As System.Windows.Forms.Button
    Friend WithEvents LoginPass As System.Windows.Forms.Label
    Friend WithEvents LoginFail As System.Windows.Forms.Label
    Friend WithEvents TextEmpName As System.Windows.Forms.TextBox
    Friend WithEvents FullNameLabel As System.Windows.Forms.Label
    Friend WithEvents EmpRecBtn As System.Windows.Forms.Button
    Friend WithEvents CustRecBtn As System.Windows.Forms.Button
    Friend WithEvents CloseBtn As System.Windows.Forms.Button
    Friend WithEvents SalesRecBtn As System.Windows.Forms.Button
    Friend WithEvents SaleBtn As System.Windows.Forms.Button
    Friend WithEvents DelivBtn As System.Windows.Forms.Button
    Friend WithEvents HomeBtn As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DecorBtn As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents RecordRelBtn As System.Windows.Forms.Button
    Friend WithEvents OrderBtn As System.Windows.Forms.Button

End Class
