<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOrder))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RecordRelBtn = New System.Windows.Forms.Button()
        Me.DelivBtn = New System.Windows.Forms.Button()
        Me.CustRecBtn = New System.Windows.Forms.Button()
        Me.IngredientRecBtn = New System.Windows.Forms.Button()
        Me.SupplierRecBtn = New System.Windows.Forms.Button()
        Me.EmpRecBtn = New System.Windows.Forms.Button()
        Me.DecorBtn = New System.Windows.Forms.Button()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.SalesRecBtn = New System.Windows.Forms.Button()
        Me.SaleBtn = New System.Windows.Forms.Button()
        Me.OrderBtn = New System.Windows.Forms.Button()
        Me.txtEmpName = New System.Windows.Forms.TextBox()
        Me.btnEmpListShow = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblSuppName = New System.Windows.Forms.Label()
        Me.txtSuppName = New System.Windows.Forms.TextBox()
        Me.lblSuppID = New System.Windows.Forms.Label()
        Me.txtSuppID = New System.Windows.Forms.TextBox()
        Me.lblIngrdName = New System.Windows.Forms.Label()
        Me.txtIngrdName = New System.Windows.Forms.TextBox()
        Me.lblIngrdID = New System.Windows.Forms.Label()
        Me.txtIngrdID = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtOrderDate = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtOrderNo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEmpID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnConfInit = New System.Windows.Forms.Button()
        Me.btnInitTrans = New System.Windows.Forms.Button()
        Me.btnRfrshIngd = New System.Windows.Forms.Button()
        Me.btnRfrshSupp = New System.Windows.Forms.Button()
        Me.radbtnIngrdID = New System.Windows.Forms.RadioButton()
        Me.radbtnIngrdName = New System.Windows.Forms.RadioButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.radbtnSuppID = New System.Windows.Forms.RadioButton()
        Me.radbtnSuppName = New System.Windows.Forms.RadioButton()
        Me.SortLbl = New System.Windows.Forms.Label()
        Me.DGVSuppliers = New System.Windows.Forms.DataGridView()
        Me.DGVIngredients = New System.Windows.Forms.DataGridView()
        Me.btnNewTrans = New System.Windows.Forms.Button()
        Me.btnShowAllDelv = New System.Windows.Forms.Button()
        Me.btnShowThisOrder = New System.Windows.Forms.Button()
        Me.txtUnitMeas = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtQtyOrder = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLineNo = New System.Windows.Forms.TextBox()
        Me.lblLineNo = New System.Windows.Forms.Label()
        Me.btnAddLinItm = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOrderAmt = New System.Windows.Forms.TextBox()
        Me.ShowRoleTB = New System.Windows.Forms.TextBox()
        Me.RolettlTB = New System.Windows.Forms.TextBox()
        Me.UserTitleTB = New System.Windows.Forms.TextBox()
        Me.EmployeeIDTB = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DGVSuppliers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVIngredients, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(416, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "RECORD ORDER | RESTAURANT MANAGEMENT SYSTEM"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1265, 46)
        Me.Panel1.TabIndex = 18
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.Controls.Add(Me.RecordRelBtn)
        Me.Panel2.Controls.Add(Me.DelivBtn)
        Me.Panel2.Controls.Add(Me.CustRecBtn)
        Me.Panel2.Controls.Add(Me.IngredientRecBtn)
        Me.Panel2.Controls.Add(Me.SupplierRecBtn)
        Me.Panel2.Controls.Add(Me.EmpRecBtn)
        Me.Panel2.Controls.Add(Me.DecorBtn)
        Me.Panel2.Controls.Add(Me.CloseBtn)
        Me.Panel2.Controls.Add(Me.SalesRecBtn)
        Me.Panel2.Controls.Add(Me.SaleBtn)
        Me.Panel2.Controls.Add(Me.OrderBtn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 46)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(203, 896)
        Me.Panel2.TabIndex = 19
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
        Me.RecordRelBtn.Location = New System.Drawing.Point(0, 135)
        Me.RecordRelBtn.Name = "RecordRelBtn"
        Me.RecordRelBtn.Padding = New System.Windows.Forms.Padding(20, 0, 13, 0)
        Me.RecordRelBtn.Size = New System.Drawing.Size(204, 68)
        Me.RecordRelBtn.TabIndex = 317
        Me.RecordRelBtn.Text = "Record Release"
        Me.RecordRelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RecordRelBtn.UseVisualStyleBackColor = False
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
        Me.DelivBtn.Location = New System.Drawing.Point(0, 67)
        Me.DelivBtn.Name = "DelivBtn"
        Me.DelivBtn.Padding = New System.Windows.Forms.Padding(20, 0, 12, 0)
        Me.DelivBtn.Size = New System.Drawing.Size(205, 68)
        Me.DelivBtn.TabIndex = 30
        Me.DelivBtn.Text = "Record Delivery"
        Me.DelivBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DelivBtn.UseVisualStyleBackColor = False
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
        Me.CustRecBtn.Location = New System.Drawing.Point(1, 407)
        Me.CustRecBtn.Name = "CustRecBtn"
        Me.CustRecBtn.Padding = New System.Windows.Forms.Padding(20, 0, 47, 0)
        Me.CustRecBtn.Size = New System.Drawing.Size(202, 68)
        Me.CustRecBtn.TabIndex = 29
        Me.CustRecBtn.Text = "Customer"
        Me.CustRecBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CustRecBtn.UseVisualStyleBackColor = False
        '
        'IngredientRecBtn
        '
        Me.IngredientRecBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.IngredientRecBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.IngredientRecBtn.FlatAppearance.BorderSize = 0
        Me.IngredientRecBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IngredientRecBtn.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IngredientRecBtn.Image = CType(resources.GetObject("IngredientRecBtn.Image"), System.Drawing.Image)
        Me.IngredientRecBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IngredientRecBtn.Location = New System.Drawing.Point(1, 339)
        Me.IngredientRecBtn.Name = "IngredientRecBtn"
        Me.IngredientRecBtn.Padding = New System.Windows.Forms.Padding(40, 0, 13, 0)
        Me.IngredientRecBtn.Size = New System.Drawing.Size(202, 68)
        Me.IngredientRecBtn.TabIndex = 28
        Me.IngredientRecBtn.Text = "Ingredients"
        Me.IngredientRecBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IngredientRecBtn.UseVisualStyleBackColor = False
        '
        'SupplierRecBtn
        '
        Me.SupplierRecBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.SupplierRecBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.SupplierRecBtn.FlatAppearance.BorderSize = 0
        Me.SupplierRecBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SupplierRecBtn.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupplierRecBtn.Image = CType(resources.GetObject("SupplierRecBtn.Image"), System.Drawing.Image)
        Me.SupplierRecBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SupplierRecBtn.Location = New System.Drawing.Point(1, 271)
        Me.SupplierRecBtn.Name = "SupplierRecBtn"
        Me.SupplierRecBtn.Padding = New System.Windows.Forms.Padding(40, 0, 37, 0)
        Me.SupplierRecBtn.Size = New System.Drawing.Size(202, 68)
        Me.SupplierRecBtn.TabIndex = 27
        Me.SupplierRecBtn.Text = "Supplier"
        Me.SupplierRecBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SupplierRecBtn.UseVisualStyleBackColor = False
        '
        'EmpRecBtn
        '
        Me.EmpRecBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.EmpRecBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.EmpRecBtn.FlatAppearance.BorderSize = 0
        Me.EmpRecBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EmpRecBtn.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpRecBtn.Image = CType(resources.GetObject("EmpRecBtn.Image"), System.Drawing.Image)
        Me.EmpRecBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EmpRecBtn.Location = New System.Drawing.Point(1, 475)
        Me.EmpRecBtn.Name = "EmpRecBtn"
        Me.EmpRecBtn.Padding = New System.Windows.Forms.Padding(20, 0, 48, 0)
        Me.EmpRecBtn.Size = New System.Drawing.Size(202, 68)
        Me.EmpRecBtn.TabIndex = 26
        Me.EmpRecBtn.Text = "Employee"
        Me.EmpRecBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EmpRecBtn.UseVisualStyleBackColor = False
        '
        'DecorBtn
        '
        Me.DecorBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.DecorBtn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.DecorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DecorBtn.Location = New System.Drawing.Point(0, 203)
        Me.DecorBtn.Name = "DecorBtn"
        Me.DecorBtn.Size = New System.Drawing.Size(9, 68)
        Me.DecorBtn.TabIndex = 25
        Me.DecorBtn.UseVisualStyleBackColor = False
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
        Me.CloseBtn.Location = New System.Drawing.Point(1, 611)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Padding = New System.Windows.Forms.Padding(20, 0, 76, 0)
        Me.CloseBtn.Size = New System.Drawing.Size(202, 68)
        Me.CloseBtn.TabIndex = 23
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
        Me.SalesRecBtn.Location = New System.Drawing.Point(1, 543)
        Me.SalesRecBtn.Name = "SalesRecBtn"
        Me.SalesRecBtn.Padding = New System.Windows.Forms.Padding(20, 0, 25, 0)
        Me.SalesRecBtn.Size = New System.Drawing.Size(202, 68)
        Me.SalesRecBtn.TabIndex = 22
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
        Me.SaleBtn.Location = New System.Drawing.Point(0, -1)
        Me.SaleBtn.Name = "SaleBtn"
        Me.SaleBtn.Padding = New System.Windows.Forms.Padding(20, 0, 37, 0)
        Me.SaleBtn.Size = New System.Drawing.Size(205, 68)
        Me.SaleBtn.TabIndex = 19
        Me.SaleBtn.Text = "Record Sale"
        Me.SaleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SaleBtn.UseVisualStyleBackColor = False
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
        Me.OrderBtn.Location = New System.Drawing.Point(1, 203)
        Me.OrderBtn.Name = "OrderBtn"
        Me.OrderBtn.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.OrderBtn.Size = New System.Drawing.Size(202, 68)
        Me.OrderBtn.TabIndex = 21
        Me.OrderBtn.Text = "Record Order"
        Me.OrderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OrderBtn.UseVisualStyleBackColor = False
        '
        'txtEmpName
        '
        Me.txtEmpName.Enabled = False
        Me.txtEmpName.Location = New System.Drawing.Point(930, 231)
        Me.txtEmpName.Name = "txtEmpName"
        Me.txtEmpName.Size = New System.Drawing.Size(160, 20)
        Me.txtEmpName.TabIndex = 288
        '
        'btnEmpListShow
        '
        Me.btnEmpListShow.Location = New System.Drawing.Point(1096, 207)
        Me.btnEmpListShow.Name = "btnEmpListShow"
        Me.btnEmpListShow.Size = New System.Drawing.Size(86, 38)
        Me.btnEmpListShow.TabIndex = 287
        Me.btnEmpListShow.Text = "Show Records"
        Me.btnEmpListShow.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.75!)
        Me.Label16.Location = New System.Drawing.Point(769, 340)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(203, 26)
        Me.Label16.TabIndex = 286
        Me.Label16.Text = "(4) INGREDIENT DETAILS"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.75!)
        Me.Label15.Location = New System.Drawing.Point(246, 341)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(183, 26)
        Me.Label15.TabIndex = 285
        Me.Label15.Text = "(3) SUPPLIER DETAILS"
        '
        'lblSuppName
        '
        Me.lblSuppName.AutoSize = True
        Me.lblSuppName.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuppName.Location = New System.Drawing.Point(283, 409)
        Me.lblSuppName.Name = "lblSuppName"
        Me.lblSuppName.Size = New System.Drawing.Size(116, 19)
        Me.lblSuppName.TabIndex = 284
        Me.lblSuppName.Text = "Supplier Name"
        '
        'txtSuppName
        '
        Me.txtSuppName.Enabled = False
        Me.txtSuppName.Location = New System.Drawing.Point(467, 410)
        Me.txtSuppName.Name = "txtSuppName"
        Me.txtSuppName.Size = New System.Drawing.Size(202, 20)
        Me.txtSuppName.TabIndex = 283
        '
        'lblSuppID
        '
        Me.lblSuppID.AutoSize = True
        Me.lblSuppID.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuppID.Location = New System.Drawing.Point(283, 377)
        Me.lblSuppID.Name = "lblSuppID"
        Me.lblSuppID.Size = New System.Drawing.Size(88, 19)
        Me.lblSuppID.TabIndex = 282
        Me.lblSuppID.Text = "Supplier ID"
        '
        'txtSuppID
        '
        Me.txtSuppID.Enabled = False
        Me.txtSuppID.Location = New System.Drawing.Point(467, 378)
        Me.txtSuppID.Name = "txtSuppID"
        Me.txtSuppID.Size = New System.Drawing.Size(202, 20)
        Me.txtSuppID.TabIndex = 281
        '
        'lblIngrdName
        '
        Me.lblIngrdName.AutoSize = True
        Me.lblIngrdName.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngrdName.Location = New System.Drawing.Point(794, 409)
        Me.lblIngrdName.Name = "lblIngrdName"
        Me.lblIngrdName.Size = New System.Drawing.Size(134, 19)
        Me.lblIngrdName.TabIndex = 280
        Me.lblIngrdName.Text = "Ingredient Name"
        '
        'txtIngrdName
        '
        Me.txtIngrdName.Enabled = False
        Me.txtIngrdName.Location = New System.Drawing.Point(942, 411)
        Me.txtIngrdName.Name = "txtIngrdName"
        Me.txtIngrdName.Size = New System.Drawing.Size(202, 20)
        Me.txtIngrdName.TabIndex = 279
        '
        'lblIngrdID
        '
        Me.lblIngrdID.AutoSize = True
        Me.lblIngrdID.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngrdID.Location = New System.Drawing.Point(794, 377)
        Me.lblIngrdID.Name = "lblIngrdID"
        Me.lblIngrdID.Size = New System.Drawing.Size(106, 19)
        Me.lblIngrdID.TabIndex = 278
        Me.lblIngrdID.Text = "Ingredient ID"
        '
        'txtIngrdID
        '
        Me.txtIngrdID.Enabled = False
        Me.txtIngrdID.Location = New System.Drawing.Point(942, 379)
        Me.txtIngrdID.Name = "txtIngrdID"
        Me.txtIngrdID.Size = New System.Drawing.Size(202, 20)
        Me.txtIngrdID.TabIndex = 277
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(271, 232)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(132, 19)
        Me.Label11.TabIndex = 276
        Me.Label11.Text = "Transaction Date"
        '
        'txtOrderDate
        '
        Me.txtOrderDate.Location = New System.Drawing.Point(455, 233)
        Me.txtOrderDate.Name = "txtOrderDate"
        Me.txtOrderDate.Size = New System.Drawing.Size(160, 20)
        Me.txtOrderDate.TabIndex = 275
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(271, 200)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(124, 19)
        Me.Label12.TabIndex = 274
        Me.Label12.Text = "Order Form No."
        '
        'txtOrderNo
        '
        Me.txtOrderNo.Enabled = False
        Me.txtOrderNo.Location = New System.Drawing.Point(455, 201)
        Me.txtOrderNo.Name = "txtOrderNo"
        Me.txtOrderNo.Size = New System.Drawing.Size(160, 20)
        Me.txtOrderNo.TabIndex = 273
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(246, 160)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(162, 26)
        Me.Label13.TabIndex = 272
        Me.Label13.Text = "(1) ORDER DETAILS"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(782, 232)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(128, 19)
        Me.Label10.TabIndex = 271
        Me.Label10.Text = "Employee Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(782, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 19)
        Me.Label3.TabIndex = 270
        Me.Label3.Text = "Employee ID"
        '
        'txtEmpID
        '
        Me.txtEmpID.Enabled = False
        Me.txtEmpID.Location = New System.Drawing.Point(930, 200)
        Me.txtEmpID.Name = "txtEmpID"
        Me.txtEmpID.Size = New System.Drawing.Size(160, 20)
        Me.txtEmpID.TabIndex = 269
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.75!)
        Me.Label9.Location = New System.Drawing.Point(757, 160)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(188, 26)
        Me.Label9.TabIndex = 268
        Me.Label9.Text = "(2) RECIPIENT DETAILS"
        '
        'btnConfInit
        '
        Me.btnConfInit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfInit.Font = New System.Drawing.Font("Eras Demi ITC", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfInit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnConfInit.Location = New System.Drawing.Point(606, 815)
        Me.btnConfInit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnConfInit.Name = "btnConfInit"
        Me.btnConfInit.Size = New System.Drawing.Size(72, 27)
        Me.btnConfInit.TabIndex = 300
        Me.btnConfInit.Text = "Confirm"
        Me.btnConfInit.UseVisualStyleBackColor = True
        Me.btnConfInit.Visible = False
        '
        'btnInitTrans
        '
        Me.btnInitTrans.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInitTrans.Enabled = False
        Me.btnInitTrans.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInitTrans.Location = New System.Drawing.Point(533, 784)
        Me.btnInitTrans.Margin = New System.Windows.Forms.Padding(2)
        Me.btnInitTrans.Name = "btnInitTrans"
        Me.btnInitTrans.Size = New System.Drawing.Size(145, 27)
        Me.btnInitTrans.TabIndex = 299
        Me.btnInitTrans.Text = "Initialize Transaction"
        Me.btnInitTrans.UseVisualStyleBackColor = True
        '
        'btnRfrshIngd
        '
        Me.btnRfrshIngd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRfrshIngd.Enabled = False
        Me.btnRfrshIngd.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRfrshIngd.Location = New System.Drawing.Point(1089, 478)
        Me.btnRfrshIngd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRfrshIngd.Name = "btnRfrshIngd"
        Me.btnRfrshIngd.Size = New System.Drawing.Size(100, 24)
        Me.btnRfrshIngd.TabIndex = 298
        Me.btnRfrshIngd.Text = "Refresh DGV"
        Me.btnRfrshIngd.UseVisualStyleBackColor = True
        '
        'btnRfrshSupp
        '
        Me.btnRfrshSupp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRfrshSupp.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRfrshSupp.Location = New System.Drawing.Point(578, 478)
        Me.btnRfrshSupp.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRfrshSupp.Name = "btnRfrshSupp"
        Me.btnRfrshSupp.Size = New System.Drawing.Size(100, 24)
        Me.btnRfrshSupp.TabIndex = 297
        Me.btnRfrshSupp.Text = "Refresh DGV"
        Me.btnRfrshSupp.UseVisualStyleBackColor = True
        '
        'radbtnIngrdID
        '
        Me.radbtnIngrdID.AutoSize = True
        Me.radbtnIngrdID.Enabled = False
        Me.radbtnIngrdID.Location = New System.Drawing.Point(861, 478)
        Me.radbtnIngrdID.Name = "radbtnIngrdID"
        Me.radbtnIngrdID.Size = New System.Drawing.Size(36, 17)
        Me.radbtnIngrdID.TabIndex = 296
        Me.radbtnIngrdID.TabStop = True
        Me.radbtnIngrdID.Text = "ID"
        Me.radbtnIngrdID.UseVisualStyleBackColor = True
        '
        'radbtnIngrdName
        '
        Me.radbtnIngrdName.AutoSize = True
        Me.radbtnIngrdName.Enabled = False
        Me.radbtnIngrdName.Location = New System.Drawing.Point(912, 478)
        Me.radbtnIngrdName.Name = "radbtnIngrdName"
        Me.radbtnIngrdName.Size = New System.Drawing.Size(56, 17)
        Me.radbtnIngrdName.TabIndex = 295
        Me.radbtnIngrdName.TabStop = True
        Me.radbtnIngrdName.Text = "NAME"
        Me.radbtnIngrdName.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(770, 475)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 24)
        Me.Label14.TabIndex = 294
        Me.Label14.Text = "SORT BY"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'radbtnSuppID
        '
        Me.radbtnSuppID.AutoSize = True
        Me.radbtnSuppID.Location = New System.Drawing.Point(350, 478)
        Me.radbtnSuppID.Name = "radbtnSuppID"
        Me.radbtnSuppID.Size = New System.Drawing.Size(36, 17)
        Me.radbtnSuppID.TabIndex = 293
        Me.radbtnSuppID.TabStop = True
        Me.radbtnSuppID.Text = "ID"
        Me.radbtnSuppID.UseVisualStyleBackColor = True
        '
        'radbtnSuppName
        '
        Me.radbtnSuppName.AutoSize = True
        Me.radbtnSuppName.Location = New System.Drawing.Point(401, 478)
        Me.radbtnSuppName.Name = "radbtnSuppName"
        Me.radbtnSuppName.Size = New System.Drawing.Size(56, 17)
        Me.radbtnSuppName.TabIndex = 292
        Me.radbtnSuppName.TabStop = True
        Me.radbtnSuppName.Text = "NAME"
        Me.radbtnSuppName.UseVisualStyleBackColor = True
        '
        'SortLbl
        '
        Me.SortLbl.AutoSize = True
        Me.SortLbl.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SortLbl.Location = New System.Drawing.Point(259, 475)
        Me.SortLbl.Name = "SortLbl"
        Me.SortLbl.Size = New System.Drawing.Size(70, 24)
        Me.SortLbl.TabIndex = 291
        Me.SortLbl.Text = "SORT BY"
        Me.SortLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DGVSuppliers
        '
        Me.DGVSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSuppliers.Location = New System.Drawing.Point(263, 514)
        Me.DGVSuppliers.Margin = New System.Windows.Forms.Padding(2)
        Me.DGVSuppliers.Name = "DGVSuppliers"
        Me.DGVSuppliers.RowTemplate.Height = 24
        Me.DGVSuppliers.Size = New System.Drawing.Size(415, 252)
        Me.DGVSuppliers.TabIndex = 289
        '
        'DGVIngredients
        '
        Me.DGVIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVIngredients.Enabled = False
        Me.DGVIngredients.Location = New System.Drawing.Point(774, 514)
        Me.DGVIngredients.Margin = New System.Windows.Forms.Padding(2)
        Me.DGVIngredients.Name = "DGVIngredients"
        Me.DGVIngredients.RowTemplate.Height = 24
        Me.DGVIngredients.Size = New System.Drawing.Size(415, 252)
        Me.DGVIngredients.TabIndex = 290
        '
        'btnNewTrans
        '
        Me.btnNewTrans.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewTrans.Enabled = False
        Me.btnNewTrans.Font = New System.Drawing.Font("Eras Demi ITC", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewTrans.Location = New System.Drawing.Point(1036, 869)
        Me.btnNewTrans.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNewTrans.Name = "btnNewTrans"
        Me.btnNewTrans.Size = New System.Drawing.Size(153, 27)
        Me.btnNewTrans.TabIndex = 314
        Me.btnNewTrans.Text = "NEW TRANSACTION"
        Me.btnNewTrans.UseVisualStyleBackColor = True
        '
        'btnShowAllDelv
        '
        Me.btnShowAllDelv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShowAllDelv.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowAllDelv.Location = New System.Drawing.Point(263, 815)
        Me.btnShowAllDelv.Margin = New System.Windows.Forms.Padding(2)
        Me.btnShowAllDelv.Name = "btnShowAllDelv"
        Me.btnShowAllDelv.Size = New System.Drawing.Size(128, 27)
        Me.btnShowAllDelv.TabIndex = 313
        Me.btnShowAllDelv.Text = "Show All Orders"
        Me.btnShowAllDelv.UseVisualStyleBackColor = True
        '
        'btnShowThisOrder
        '
        Me.btnShowThisOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShowThisOrder.Enabled = False
        Me.btnShowThisOrder.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowThisOrder.Location = New System.Drawing.Point(263, 784)
        Me.btnShowThisOrder.Margin = New System.Windows.Forms.Padding(2)
        Me.btnShowThisOrder.Name = "btnShowThisOrder"
        Me.btnShowThisOrder.Size = New System.Drawing.Size(128, 27)
        Me.btnShowThisOrder.TabIndex = 312
        Me.btnShowThisOrder.Text = "Show This Order"
        Me.btnShowThisOrder.UseVisualStyleBackColor = True
        '
        'txtUnitMeas
        '
        Me.txtUnitMeas.Enabled = False
        Me.txtUnitMeas.Location = New System.Drawing.Point(1134, 791)
        Me.txtUnitMeas.Name = "txtUnitMeas"
        Me.txtUnitMeas.Size = New System.Drawing.Size(55, 20)
        Me.txtUnitMeas.TabIndex = 309
        Me.txtUnitMeas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(965, 791)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(163, 19)
        Me.Label6.TabIndex = 308
        Me.Label6.Text = "Unit of Measurement"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtQtyOrder
        '
        Me.txtQtyOrder.Enabled = False
        Me.txtQtyOrder.Location = New System.Drawing.Point(886, 825)
        Me.txtQtyOrder.Name = "txtQtyOrder"
        Me.txtQtyOrder.Size = New System.Drawing.Size(55, 20)
        Me.txtQtyOrder.TabIndex = 307
        Me.txtQtyOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(770, 826)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 19)
        Me.Label4.TabIndex = 306
        Me.Label4.Text = "Qty Ordered"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtLineNo
        '
        Me.txtLineNo.Enabled = False
        Me.txtLineNo.Location = New System.Drawing.Point(886, 792)
        Me.txtLineNo.Name = "txtLineNo"
        Me.txtLineNo.Size = New System.Drawing.Size(55, 20)
        Me.txtLineNo.TabIndex = 305
        Me.txtLineNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblLineNo
        '
        Me.lblLineNo.AutoSize = True
        Me.lblLineNo.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLineNo.Location = New System.Drawing.Point(770, 792)
        Me.lblLineNo.Name = "lblLineNo"
        Me.lblLineNo.Size = New System.Drawing.Size(104, 19)
        Me.lblLineNo.TabIndex = 304
        Me.lblLineNo.Text = "Line Number"
        Me.lblLineNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAddLinItm
        '
        Me.btnAddLinItm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddLinItm.Enabled = False
        Me.btnAddLinItm.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddLinItm.Location = New System.Drawing.Point(774, 869)
        Me.btnAddLinItm.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddLinItm.Name = "btnAddLinItm"
        Me.btnAddLinItm.Size = New System.Drawing.Size(128, 27)
        Me.btnAddLinItm.TabIndex = 303
        Me.btnAddLinItm.Text = "Add Line Item"
        Me.btnAddLinItm.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(271, 266)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 19)
        Me.Label2.TabIndex = 316
        Me.Label2.Text = "Order Amount"
        '
        'txtOrderAmt
        '
        Me.txtOrderAmt.Location = New System.Drawing.Point(455, 267)
        Me.txtOrderAmt.Name = "txtOrderAmt"
        Me.txtOrderAmt.Size = New System.Drawing.Size(160, 20)
        Me.txtOrderAmt.TabIndex = 315
        '
        'ShowRoleTB
        '
        Me.ShowRoleTB.BackColor = System.Drawing.Color.White
        Me.ShowRoleTB.Location = New System.Drawing.Point(1215, 65)
        Me.ShowRoleTB.Name = "ShowRoleTB"
        Me.ShowRoleTB.ReadOnly = True
        Me.ShowRoleTB.Size = New System.Drawing.Size(33, 20)
        Me.ShowRoleTB.TabIndex = 319
        '
        'RolettlTB
        '
        Me.RolettlTB.Location = New System.Drawing.Point(1178, 65)
        Me.RolettlTB.Name = "RolettlTB"
        Me.RolettlTB.ReadOnly = True
        Me.RolettlTB.Size = New System.Drawing.Size(44, 20)
        Me.RolettlTB.TabIndex = 320
        Me.RolettlTB.Text = "Role"
        '
        'UserTitleTB
        '
        Me.UserTitleTB.Location = New System.Drawing.Point(1100, 46)
        Me.UserTitleTB.Name = "UserTitleTB"
        Me.UserTitleTB.ReadOnly = True
        Me.UserTitleTB.Size = New System.Drawing.Size(44, 20)
        Me.UserTitleTB.TabIndex = 318
        Me.UserTitleTB.Text = "UserID:"
        '
        'EmployeeIDTB
        '
        Me.EmployeeIDTB.BackColor = System.Drawing.Color.White
        Me.EmployeeIDTB.Location = New System.Drawing.Point(1142, 46)
        Me.EmployeeIDTB.Name = "EmployeeIDTB"
        Me.EmployeeIDTB.ReadOnly = True
        Me.EmployeeIDTB.Size = New System.Drawing.Size(106, 20)
        Me.EmployeeIDTB.TabIndex = 317
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.DagoyMaltoPorol.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(517, 60)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(280, 142)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 219
        Me.PictureBox1.TabStop = False
        '
        'FrmOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1265, 942)
        Me.Controls.Add(Me.ShowRoleTB)
        Me.Controls.Add(Me.RolettlTB)
        Me.Controls.Add(Me.UserTitleTB)
        Me.Controls.Add(Me.EmployeeIDTB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtOrderAmt)
        Me.Controls.Add(Me.btnNewTrans)
        Me.Controls.Add(Me.btnShowAllDelv)
        Me.Controls.Add(Me.btnShowThisOrder)
        Me.Controls.Add(Me.txtUnitMeas)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtQtyOrder)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtLineNo)
        Me.Controls.Add(Me.lblLineNo)
        Me.Controls.Add(Me.btnAddLinItm)
        Me.Controls.Add(Me.btnConfInit)
        Me.Controls.Add(Me.btnInitTrans)
        Me.Controls.Add(Me.btnRfrshIngd)
        Me.Controls.Add(Me.btnRfrshSupp)
        Me.Controls.Add(Me.radbtnIngrdID)
        Me.Controls.Add(Me.radbtnIngrdName)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.radbtnSuppID)
        Me.Controls.Add(Me.radbtnSuppName)
        Me.Controls.Add(Me.SortLbl)
        Me.Controls.Add(Me.DGVSuppliers)
        Me.Controls.Add(Me.DGVIngredients)
        Me.Controls.Add(Me.txtEmpName)
        Me.Controls.Add(Me.btnEmpListShow)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblSuppName)
        Me.Controls.Add(Me.txtSuppName)
        Me.Controls.Add(Me.lblSuppID)
        Me.Controls.Add(Me.txtSuppID)
        Me.Controls.Add(Me.lblIngrdName)
        Me.Controls.Add(Me.txtIngrdName)
        Me.Controls.Add(Me.lblIngrdID)
        Me.Controls.Add(Me.txtIngrdID)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtOrderDate)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtOrderNo)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEmpID)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Record Order"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DGVSuppliers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVIngredients, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents IngredientRecBtn As System.Windows.Forms.Button
    Friend WithEvents SupplierRecBtn As System.Windows.Forms.Button
    Friend WithEvents EmpRecBtn As System.Windows.Forms.Button
    Friend WithEvents DecorBtn As System.Windows.Forms.Button
    Friend WithEvents CloseBtn As System.Windows.Forms.Button
    Friend WithEvents SalesRecBtn As System.Windows.Forms.Button
    Friend WithEvents SaleBtn As System.Windows.Forms.Button
    Friend WithEvents OrderBtn As System.Windows.Forms.Button
    Friend WithEvents CustRecBtn As System.Windows.Forms.Button
    Friend WithEvents DelivBtn As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtEmpName As System.Windows.Forms.TextBox
    Friend WithEvents btnEmpListShow As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblSuppName As System.Windows.Forms.Label
    Friend WithEvents txtSuppName As System.Windows.Forms.TextBox
    Friend WithEvents lblSuppID As System.Windows.Forms.Label
    Friend WithEvents txtSuppID As System.Windows.Forms.TextBox
    Friend WithEvents lblIngrdName As System.Windows.Forms.Label
    Friend WithEvents txtIngrdName As System.Windows.Forms.TextBox
    Friend WithEvents lblIngrdID As System.Windows.Forms.Label
    Friend WithEvents txtIngrdID As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtOrderDate As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtOrderNo As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtEmpID As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnConfInit As System.Windows.Forms.Button
    Friend WithEvents btnInitTrans As System.Windows.Forms.Button
    Friend WithEvents btnRfrshIngd As System.Windows.Forms.Button
    Friend WithEvents btnRfrshSupp As System.Windows.Forms.Button
    Friend WithEvents radbtnIngrdID As System.Windows.Forms.RadioButton
    Friend WithEvents radbtnIngrdName As System.Windows.Forms.RadioButton
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents radbtnSuppID As System.Windows.Forms.RadioButton
    Friend WithEvents radbtnSuppName As System.Windows.Forms.RadioButton
    Friend WithEvents SortLbl As System.Windows.Forms.Label
    Friend WithEvents DGVSuppliers As System.Windows.Forms.DataGridView
    Friend WithEvents DGVIngredients As System.Windows.Forms.DataGridView
    Friend WithEvents btnNewTrans As System.Windows.Forms.Button
    Friend WithEvents btnShowAllDelv As System.Windows.Forms.Button
    Friend WithEvents btnShowThisOrder As System.Windows.Forms.Button
    Friend WithEvents txtUnitMeas As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtQtyOrder As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLineNo As System.Windows.Forms.TextBox
    Friend WithEvents lblLineNo As System.Windows.Forms.Label
    Friend WithEvents btnAddLinItm As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtOrderAmt As System.Windows.Forms.TextBox
    Friend WithEvents RecordRelBtn As System.Windows.Forms.Button
    Friend WithEvents ShowRoleTB As System.Windows.Forms.TextBox
    Friend WithEvents RolettlTB As System.Windows.Forms.TextBox
    Friend WithEvents UserTitleTB As System.Windows.Forms.TextBox
    Friend WithEvents EmployeeIDTB As System.Windows.Forms.TextBox
End Class
