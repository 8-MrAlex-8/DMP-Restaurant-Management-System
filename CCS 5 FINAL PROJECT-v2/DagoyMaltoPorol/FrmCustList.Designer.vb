<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCustList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCustList))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RecordRelBtn = New System.Windows.Forms.Button()
        Me.DecorBtn = New System.Windows.Forms.Button()
        Me.EmpRecBtn = New System.Windows.Forms.Button()
        Me.CustRecBtn = New System.Windows.Forms.Button()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.SalesRecBtn = New System.Windows.Forms.Button()
        Me.SaleBtn = New System.Windows.Forms.Button()
        Me.DelivBtn = New System.Windows.Forms.Button()
        Me.RadBtnID = New System.Windows.Forms.RadioButton()
        Me.RadBtnName = New System.Windows.Forms.RadioButton()
        Me.SortLbl = New System.Windows.Forms.Label()
        Me.GuideLbl = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.TxtBxCustName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtBxCustNo = New System.Windows.Forms.TextBox()
        Me.CustNoLbl = New System.Windows.Forms.Label()
        Me.SrchBxCustID = New System.Windows.Forms.TextBox()
        Me.SearchLbl = New System.Windows.Forms.Label()
        Me.DGVCustomers = New System.Windows.Forms.DataGridView()
        Me.btnSureDelete = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnRfrshDGV = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ShowRoleTB = New System.Windows.Forms.TextBox()
        Me.RolettlTB = New System.Windows.Forms.TextBox()
        Me.UserTitleTB = New System.Windows.Forms.TextBox()
        Me.EmployeeIDTB = New System.Windows.Forms.TextBox()
        Me.OrderBtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DGVCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(455, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CUSTOMER RECORDS | RESTAURANT MANAGEMENT SYSTEM"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.Controls.Add(Me.OrderBtn)
        Me.Panel2.Controls.Add(Me.RecordRelBtn)
        Me.Panel2.Controls.Add(Me.DecorBtn)
        Me.Panel2.Controls.Add(Me.EmpRecBtn)
        Me.Panel2.Controls.Add(Me.CustRecBtn)
        Me.Panel2.Controls.Add(Me.CloseBtn)
        Me.Panel2.Controls.Add(Me.SalesRecBtn)
        Me.Panel2.Controls.Add(Me.SaleBtn)
        Me.Panel2.Controls.Add(Me.DelivBtn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 46)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(203, 628)
        Me.Panel2.TabIndex = 187
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
        Me.RecordRelBtn.Location = New System.Drawing.Point(-1, 136)
        Me.RecordRelBtn.Name = "RecordRelBtn"
        Me.RecordRelBtn.Padding = New System.Windows.Forms.Padding(20, 0, 16, 0)
        Me.RecordRelBtn.Size = New System.Drawing.Size(204, 68)
        Me.RecordRelBtn.TabIndex = 215
        Me.RecordRelBtn.Text = "Record Release"
        Me.RecordRelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RecordRelBtn.UseVisualStyleBackColor = False
        '
        'DecorBtn
        '
        Me.DecorBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.DecorBtn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.DecorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DecorBtn.Location = New System.Drawing.Point(0, 272)
        Me.DecorBtn.Name = "DecorBtn"
        Me.DecorBtn.Size = New System.Drawing.Size(10, 68)
        Me.DecorBtn.TabIndex = 195
        Me.DecorBtn.UseVisualStyleBackColor = False
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
        Me.EmpRecBtn.Location = New System.Drawing.Point(-1, 340)
        Me.EmpRecBtn.Name = "EmpRecBtn"
        Me.EmpRecBtn.Padding = New System.Windows.Forms.Padding(20, 0, 48, 0)
        Me.EmpRecBtn.Size = New System.Drawing.Size(204, 68)
        Me.EmpRecBtn.TabIndex = 32
        Me.EmpRecBtn.Text = "Employee"
        Me.EmpRecBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EmpRecBtn.UseVisualStyleBackColor = False
        '
        'CustRecBtn
        '
        Me.CustRecBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.CustRecBtn.Enabled = False
        Me.CustRecBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.CustRecBtn.FlatAppearance.BorderSize = 0
        Me.CustRecBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CustRecBtn.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustRecBtn.Image = CType(resources.GetObject("CustRecBtn.Image"), System.Drawing.Image)
        Me.CustRecBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CustRecBtn.Location = New System.Drawing.Point(0, 272)
        Me.CustRecBtn.Name = "CustRecBtn"
        Me.CustRecBtn.Padding = New System.Windows.Forms.Padding(20, 0, 47, 0)
        Me.CustRecBtn.Size = New System.Drawing.Size(203, 68)
        Me.CustRecBtn.TabIndex = 31
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
        Me.CloseBtn.Location = New System.Drawing.Point(-1, 475)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Padding = New System.Windows.Forms.Padding(20, 0, 76, 0)
        Me.CloseBtn.Size = New System.Drawing.Size(204, 68)
        Me.CloseBtn.TabIndex = 30
        Me.CloseBtn.Text = "Close"
        Me.CloseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CloseBtn.UseVisualStyleBackColor = False
        '
        'SalesRecBtn
        '
        Me.SalesRecBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.SalesRecBtn.Enabled = False
        Me.SalesRecBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.SalesRecBtn.FlatAppearance.BorderSize = 0
        Me.SalesRecBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SalesRecBtn.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesRecBtn.Image = CType(resources.GetObject("SalesRecBtn.Image"), System.Drawing.Image)
        Me.SalesRecBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SalesRecBtn.Location = New System.Drawing.Point(-1, 408)
        Me.SalesRecBtn.Name = "SalesRecBtn"
        Me.SalesRecBtn.Padding = New System.Windows.Forms.Padding(20, 0, 25, 0)
        Me.SalesRecBtn.Size = New System.Drawing.Size(204, 68)
        Me.SalesRecBtn.TabIndex = 29
        Me.SalesRecBtn.Text = "Sales Records"
        Me.SalesRecBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SalesRecBtn.UseVisualStyleBackColor = False
        '
        'SaleBtn
        '
        Me.SaleBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.SaleBtn.Enabled = False
        Me.SaleBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.SaleBtn.FlatAppearance.BorderSize = 0
        Me.SaleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaleBtn.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaleBtn.Image = CType(resources.GetObject("SaleBtn.Image"), System.Drawing.Image)
        Me.SaleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SaleBtn.Location = New System.Drawing.Point(-1, 0)
        Me.SaleBtn.Name = "SaleBtn"
        Me.SaleBtn.Padding = New System.Windows.Forms.Padding(20, 0, 37, 0)
        Me.SaleBtn.Size = New System.Drawing.Size(204, 68)
        Me.SaleBtn.TabIndex = 27
        Me.SaleBtn.Text = "Record Sale"
        Me.SaleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SaleBtn.UseVisualStyleBackColor = False
        '
        'DelivBtn
        '
        Me.DelivBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DelivBtn.Enabled = False
        Me.DelivBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DelivBtn.FlatAppearance.BorderSize = 0
        Me.DelivBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DelivBtn.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelivBtn.Image = CType(resources.GetObject("DelivBtn.Image"), System.Drawing.Image)
        Me.DelivBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DelivBtn.Location = New System.Drawing.Point(-1, 68)
        Me.DelivBtn.Name = "DelivBtn"
        Me.DelivBtn.Padding = New System.Windows.Forms.Padding(20, 0, 12, 0)
        Me.DelivBtn.Size = New System.Drawing.Size(204, 68)
        Me.DelivBtn.TabIndex = 28
        Me.DelivBtn.Text = "Record Delivery"
        Me.DelivBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DelivBtn.UseVisualStyleBackColor = False
        '
        'RadBtnID
        '
        Me.RadBtnID.AutoSize = True
        Me.RadBtnID.Location = New System.Drawing.Point(817, 197)
        Me.RadBtnID.Name = "RadBtnID"
        Me.RadBtnID.Size = New System.Drawing.Size(36, 17)
        Me.RadBtnID.TabIndex = 204
        Me.RadBtnID.TabStop = True
        Me.RadBtnID.Text = "ID"
        Me.RadBtnID.UseVisualStyleBackColor = True
        '
        'RadBtnName
        '
        Me.RadBtnName.AutoSize = True
        Me.RadBtnName.Location = New System.Drawing.Point(868, 197)
        Me.RadBtnName.Name = "RadBtnName"
        Me.RadBtnName.Size = New System.Drawing.Size(56, 17)
        Me.RadBtnName.TabIndex = 203
        Me.RadBtnName.TabStop = True
        Me.RadBtnName.Text = "NAME"
        Me.RadBtnName.UseVisualStyleBackColor = True
        '
        'SortLbl
        '
        Me.SortLbl.AutoSize = True
        Me.SortLbl.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SortLbl.Location = New System.Drawing.Point(726, 194)
        Me.SortLbl.Name = "SortLbl"
        Me.SortLbl.Size = New System.Drawing.Size(70, 24)
        Me.SortLbl.TabIndex = 202
        Me.SortLbl.Text = "SORT BY"
        Me.SortLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GuideLbl
        '
        Me.GuideLbl.AutoSize = True
        Me.GuideLbl.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuideLbl.Location = New System.Drawing.Point(277, 254)
        Me.GuideLbl.Name = "GuideLbl"
        Me.GuideLbl.Size = New System.Drawing.Size(406, 34)
        Me.GuideLbl.TabIndex = 200
        Me.GuideLbl.Text = "Edit or Delete Current Customer Records"
        '
        'btnDelete
        '
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Enabled = False
        Me.btnDelete.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(574, 450)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(109, 35)
        Me.btnDelete.TabIndex = 199
        Me.btnDelete.Text = "Delete Record"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(461, 450)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(109, 35)
        Me.btnUpdate.TabIndex = 198
        Me.btnUpdate.Text = "Update Record"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'TxtBxCustName
        '
        Me.TxtBxCustName.Location = New System.Drawing.Point(527, 382)
        Me.TxtBxCustName.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtBxCustName.Name = "TxtBxCustName"
        Me.TxtBxCustName.Size = New System.Drawing.Size(156, 20)
        Me.TxtBxCustName.TabIndex = 194
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(364, 381)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 19)
        Me.Label5.TabIndex = 193
        Me.Label5.Text = "Customer Name:"
        '
        'TxtBxCustNo
        '
        Me.TxtBxCustNo.Enabled = False
        Me.TxtBxCustNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBxCustNo.Location = New System.Drawing.Point(527, 338)
        Me.TxtBxCustNo.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtBxCustNo.Name = "TxtBxCustNo"
        Me.TxtBxCustNo.Size = New System.Drawing.Size(156, 21)
        Me.TxtBxCustNo.TabIndex = 192
        '
        'CustNoLbl
        '
        Me.CustNoLbl.AutoSize = True
        Me.CustNoLbl.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustNoLbl.Location = New System.Drawing.Point(364, 339)
        Me.CustNoLbl.Name = "CustNoLbl"
        Me.CustNoLbl.Size = New System.Drawing.Size(146, 19)
        Me.CustNoLbl.TabIndex = 191
        Me.CustNoLbl.Text = "Customer Number:"
        '
        'SrchBxCustID
        '
        Me.SrchBxCustID.Location = New System.Drawing.Point(897, 137)
        Me.SrchBxCustID.Name = "SrchBxCustID"
        Me.SrchBxCustID.Size = New System.Drawing.Size(202, 20)
        Me.SrchBxCustID.TabIndex = 190
        '
        'SearchLbl
        '
        Me.SearchLbl.AutoSize = True
        Me.SearchLbl.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchLbl.Location = New System.Drawing.Point(726, 138)
        Me.SearchLbl.Name = "SearchLbl"
        Me.SearchLbl.Size = New System.Drawing.Size(161, 19)
        Me.SearchLbl.TabIndex = 189
        Me.SearchLbl.Text = "Search Customer No."
        '
        'DGVCustomers
        '
        Me.DGVCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCustomers.Location = New System.Drawing.Point(730, 254)
        Me.DGVCustomers.Margin = New System.Windows.Forms.Padding(2)
        Me.DGVCustomers.Name = "DGVCustomers"
        Me.DGVCustomers.RowTemplate.Height = 24
        Me.DGVCustomers.Size = New System.Drawing.Size(425, 366)
        Me.DGVCustomers.TabIndex = 188
        '
        'btnSureDelete
        '
        Me.btnSureDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSureDelete.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSureDelete.ForeColor = System.Drawing.Color.Firebrick
        Me.btnSureDelete.Location = New System.Drawing.Point(574, 489)
        Me.btnSureDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSureDelete.Name = "btnSureDelete"
        Me.btnSureDelete.Size = New System.Drawing.Size(109, 54)
        Me.btnSureDelete.TabIndex = 205
        Me.btnSureDelete.Text = "CONFIRM DELETION"
        Me.btnSureDelete.UseVisualStyleBackColor = True
        Me.btnSureDelete.Visible = False
        '
        'btnReset
        '
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnReset.Location = New System.Drawing.Point(574, 547)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(109, 35)
        Me.btnReset.TabIndex = 206
        Me.btnReset.Text = "RESET FIELDS"
        Me.btnReset.UseVisualStyleBackColor = True
        Me.btnReset.Visible = False
        '
        'btnRfrshDGV
        '
        Me.btnRfrshDGV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRfrshDGV.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRfrshDGV.Location = New System.Drawing.Point(1055, 226)
        Me.btnRfrshDGV.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRfrshDGV.Name = "btnRfrshDGV"
        Me.btnRfrshDGV.Size = New System.Drawing.Size(100, 24)
        Me.btnRfrshDGV.TabIndex = 207
        Me.btnRfrshDGV.Text = "Refresh DGV"
        Me.btnRfrshDGV.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.DagoyMaltoPorol.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(356, 100)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(254, 151)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 208
        Me.PictureBox1.TabStop = False
        '
        'ShowRoleTB
        '
        Me.ShowRoleTB.BackColor = System.Drawing.Color.White
        Me.ShowRoleTB.Location = New System.Drawing.Point(1253, 65)
        Me.ShowRoleTB.Name = "ShowRoleTB"
        Me.ShowRoleTB.ReadOnly = True
        Me.ShowRoleTB.Size = New System.Drawing.Size(32, 20)
        Me.ShowRoleTB.TabIndex = 213
        '
        'RolettlTB
        '
        Me.RolettlTB.Location = New System.Drawing.Point(1216, 65)
        Me.RolettlTB.Name = "RolettlTB"
        Me.RolettlTB.ReadOnly = True
        Me.RolettlTB.Size = New System.Drawing.Size(43, 20)
        Me.RolettlTB.TabIndex = 214
        Me.RolettlTB.Text = "Role"
        '
        'UserTitleTB
        '
        Me.UserTitleTB.Location = New System.Drawing.Point(1138, 46)
        Me.UserTitleTB.Name = "UserTitleTB"
        Me.UserTitleTB.ReadOnly = True
        Me.UserTitleTB.Size = New System.Drawing.Size(43, 20)
        Me.UserTitleTB.TabIndex = 212
        Me.UserTitleTB.Text = "UserID:"
        '
        'EmployeeIDTB
        '
        Me.EmployeeIDTB.BackColor = System.Drawing.Color.White
        Me.EmployeeIDTB.Location = New System.Drawing.Point(1180, 46)
        Me.EmployeeIDTB.Name = "EmployeeIDTB"
        Me.EmployeeIDTB.ReadOnly = True
        Me.EmployeeIDTB.Size = New System.Drawing.Size(105, 20)
        Me.EmployeeIDTB.TabIndex = 211
        '
        'OrderBtn
        '
        Me.OrderBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.OrderBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.OrderBtn.FlatAppearance.BorderSize = 0
        Me.OrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OrderBtn.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderBtn.Image = CType(resources.GetObject("OrderBtn.Image"), System.Drawing.Image)
        Me.OrderBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OrderBtn.Location = New System.Drawing.Point(-1, 204)
        Me.OrderBtn.Name = "OrderBtn"
        Me.OrderBtn.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.OrderBtn.Size = New System.Drawing.Size(204, 68)
        Me.OrderBtn.TabIndex = 215
        Me.OrderBtn.Text = "Record Order"
        Me.OrderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OrderBtn.UseVisualStyleBackColor = False
        '
        'FrmCustList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1285, 674)
        Me.Controls.Add(Me.ShowRoleTB)
        Me.Controls.Add(Me.RolettlTB)
        Me.Controls.Add(Me.UserTitleTB)
        Me.Controls.Add(Me.EmployeeIDTB)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnRfrshDGV)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnSureDelete)
        Me.Controls.Add(Me.RadBtnID)
        Me.Controls.Add(Me.GuideLbl)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.RadBtnName)
        Me.Controls.Add(Me.SortLbl)
        Me.Controls.Add(Me.DGVCustomers)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TxtBxCustName)
        Me.Controls.Add(Me.SearchLbl)
        Me.Controls.Add(Me.SrchBxCustID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CustNoLbl)
        Me.Controls.Add(Me.TxtBxCustNo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCustList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Records"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DGVCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents EmpRecBtn As System.Windows.Forms.Button
    Friend WithEvents CustRecBtn As System.Windows.Forms.Button
    Friend WithEvents CloseBtn As System.Windows.Forms.Button
    Friend WithEvents SalesRecBtn As System.Windows.Forms.Button
    Friend WithEvents SaleBtn As System.Windows.Forms.Button
    Friend WithEvents DelivBtn As System.Windows.Forms.Button
    Friend WithEvents DecorBtn As System.Windows.Forms.Button
    Friend WithEvents RadBtnID As System.Windows.Forms.RadioButton
    Friend WithEvents RadBtnName As System.Windows.Forms.RadioButton
    Friend WithEvents GuideLbl As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents TxtBxCustName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtBxCustNo As System.Windows.Forms.TextBox
    Friend WithEvents CustNoLbl As System.Windows.Forms.Label
    Friend WithEvents SrchBxCustID As System.Windows.Forms.TextBox
    Friend WithEvents SearchLbl As System.Windows.Forms.Label
    Friend WithEvents DGVCustomers As System.Windows.Forms.DataGridView
    Friend WithEvents SortLbl As System.Windows.Forms.Label
    Friend WithEvents btnSureDelete As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnRfrshDGV As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ShowRoleTB As System.Windows.Forms.TextBox
    Friend WithEvents RolettlTB As System.Windows.Forms.TextBox
    Friend WithEvents UserTitleTB As System.Windows.Forms.TextBox
    Friend WithEvents EmployeeIDTB As System.Windows.Forms.TextBox
    Friend WithEvents RecordRelBtn As System.Windows.Forms.Button
    Friend WithEvents OrderBtn As System.Windows.Forms.Button
End Class
