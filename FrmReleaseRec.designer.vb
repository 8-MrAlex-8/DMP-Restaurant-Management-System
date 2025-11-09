<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReleaseRec
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReleaseRec))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRONo = New System.Windows.Forms.TextBox()
        Me.DateTB = New System.Windows.Forms.TextBox()
        Me.txtEmpName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSaveRecord = New System.Windows.Forms.Button()
        Me.btnReleaseIng = New System.Windows.Forms.Button()
        Me.VoidTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.RecordTransTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnNewTrans = New System.Windows.Forms.Button()
        Me.ViewRecTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SaveCustRecTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.EmployeeIDTB = New System.Windows.Forms.TextBox()
        Me.UserTitleTB = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RolettlTB = New System.Windows.Forms.TextBox()
        Me.ShowRoleTB = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblIngrdID = New System.Windows.Forms.Label()
        Me.txtIngID = New System.Windows.Forms.TextBox()
        Me.DGVIngredientList = New System.Windows.Forms.DataGridView()
        Me.txtSearchIngredientName = New System.Windows.Forms.TextBox()
        Me.SearchLbl = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DGVReleaseRecList = New System.Windows.Forms.DataGridView()
        Me.DGVRecDetails = New System.Windows.Forms.DataGridView()
        Me.lblLineItem = New System.Windows.Forms.Label()
        Me.txtUnitMeas = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtQtyRel = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtLineNo = New System.Windows.Forms.TextBox()
        Me.lblLineNo = New System.Windows.Forms.Label()
        Me.btnEmpRecs = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmpID = New System.Windows.Forms.TextBox()
        Me.txtRole = New System.Windows.Forms.TextBox()
        Me.EmpRecBtn = New System.Windows.Forms.Button()
        Me.CustRecBtn = New System.Windows.Forms.Button()
        Me.RecordRelBtn = New System.Windows.Forms.Button()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.SalesRecBtn = New System.Windows.Forms.Button()
        Me.SaleBtn = New System.Windows.Forms.Button()
        Me.DelivBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OrderBtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DGVIngredientList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVReleaseRecList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVRecDetails, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(1341, 46)
        Me.Panel1.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(400, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RECORD SALE | RESTAURANT MANAGEMENT SYSTEM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(772, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 19)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "RO NUMBER"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(251, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 19)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "RELEASE DATE"
        '
        'txtRONo
        '
        Me.txtRONo.Cursor = System.Windows.Forms.Cursors.No
        Me.txtRONo.Enabled = False
        Me.txtRONo.Location = New System.Drawing.Point(970, 176)
        Me.txtRONo.Name = "txtRONo"
        Me.txtRONo.ReadOnly = True
        Me.txtRONo.Size = New System.Drawing.Size(202, 20)
        Me.txtRONo.TabIndex = 22
        '
        'DateTB
        '
        Me.DateTB.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DateTB.Location = New System.Drawing.Point(406, 239)
        Me.DateTB.Name = "DateTB"
        Me.DateTB.Size = New System.Drawing.Size(202, 20)
        Me.DateTB.TabIndex = 25
        '
        'txtEmpName
        '
        Me.txtEmpName.Enabled = False
        Me.txtEmpName.Location = New System.Drawing.Point(406, 203)
        Me.txtEmpName.Name = "txtEmpName"
        Me.txtEmpName.Size = New System.Drawing.Size(202, 20)
        Me.txtEmpName.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(250, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 19)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "RELEASED BY"
        '
        'btnSaveRecord
        '
        Me.btnSaveRecord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveRecord.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveRecord.Location = New System.Drawing.Point(613, 234)
        Me.btnSaveRecord.Name = "btnSaveRecord"
        Me.btnSaveRecord.Size = New System.Drawing.Size(107, 29)
        Me.btnSaveRecord.TabIndex = 37
        Me.btnSaveRecord.Text = "SAVE RECORD"
        Me.RecordTransTooltip.SetToolTip(Me.btnSaveRecord, "Post this transaction in the database.")
        Me.btnSaveRecord.UseVisualStyleBackColor = True
        '
        'btnReleaseIng
        '
        Me.btnReleaseIng.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReleaseIng.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!)
        Me.btnReleaseIng.Location = New System.Drawing.Point(476, 836)
        Me.btnReleaseIng.Name = "btnReleaseIng"
        Me.btnReleaseIng.Size = New System.Drawing.Size(158, 32)
        Me.btnReleaseIng.TabIndex = 144
        Me.btnReleaseIng.Text = "Release Ingredient"
        Me.SaveCustRecTooltip.SetToolTip(Me.btnReleaseIng, "Releases ingredient")
        Me.btnReleaseIng.UseVisualStyleBackColor = True
        '
        'btnNewTrans
        '
        Me.btnNewTrans.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewTrans.Enabled = False
        Me.btnNewTrans.Font = New System.Drawing.Font("Eras Demi ITC", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewTrans.Location = New System.Drawing.Point(465, 885)
        Me.btnNewTrans.Name = "btnNewTrans"
        Me.btnNewTrans.Size = New System.Drawing.Size(180, 29)
        Me.btnNewTrans.TabIndex = 292
        Me.btnNewTrans.Text = "NEW TRANSACTION"
        Me.RecordTransTooltip.SetToolTip(Me.btnNewTrans, "Post this transaction in the database.")
        Me.btnNewTrans.UseVisualStyleBackColor = True
        '
        'EmployeeIDTB
        '
        Me.EmployeeIDTB.BackColor = System.Drawing.Color.White
        Me.EmployeeIDTB.Location = New System.Drawing.Point(1236, 46)
        Me.EmployeeIDTB.Name = "EmployeeIDTB"
        Me.EmployeeIDTB.ReadOnly = True
        Me.EmployeeIDTB.Size = New System.Drawing.Size(105, 20)
        Me.EmployeeIDTB.TabIndex = 184
        '
        'UserTitleTB
        '
        Me.UserTitleTB.Location = New System.Drawing.Point(1194, 46)
        Me.UserTitleTB.Name = "UserTitleTB"
        Me.UserTitleTB.ReadOnly = True
        Me.UserTitleTB.Size = New System.Drawing.Size(43, 20)
        Me.UserTitleTB.TabIndex = 185
        Me.UserTitleTB.Text = "UserID:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.Controls.Add(Me.OrderBtn)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.EmpRecBtn)
        Me.Panel2.Controls.Add(Me.CustRecBtn)
        Me.Panel2.Controls.Add(Me.RecordRelBtn)
        Me.Panel2.Controls.Add(Me.CloseBtn)
        Me.Panel2.Controls.Add(Me.SalesRecBtn)
        Me.Panel2.Controls.Add(Me.SaleBtn)
        Me.Panel2.Controls.Add(Me.DelivBtn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 46)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(203, 943)
        Me.Panel2.TabIndex = 186
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SteelBlue
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(-1, 136)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(9, 68)
        Me.Button1.TabIndex = 210
        Me.Button1.UseVisualStyleBackColor = False
        '
        'RolettlTB
        '
        Me.RolettlTB.Location = New System.Drawing.Point(1272, 65)
        Me.RolettlTB.Name = "RolettlTB"
        Me.RolettlTB.ReadOnly = True
        Me.RolettlTB.Size = New System.Drawing.Size(43, 20)
        Me.RolettlTB.TabIndex = 210
        Me.RolettlTB.Text = "Role"
        '
        'ShowRoleTB
        '
        Me.ShowRoleTB.BackColor = System.Drawing.Color.White
        Me.ShowRoleTB.Location = New System.Drawing.Point(1309, 65)
        Me.ShowRoleTB.Name = "ShowRoleTB"
        Me.ShowRoleTB.ReadOnly = True
        Me.ShowRoleTB.Size = New System.Drawing.Size(32, 20)
        Me.ShowRoleTB.TabIndex = 209
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.75!)
        Me.Label16.Location = New System.Drawing.Point(250, 292)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(208, 26)
        Me.Label16.TabIndex = 272
        Me.Label16.Text = "INGREDIENT TO RELEASE"
        '
        'lblIngrdID
        '
        Me.lblIngrdID.AutoSize = True
        Me.lblIngrdID.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngrdID.Location = New System.Drawing.Point(251, 332)
        Me.lblIngrdID.Name = "lblIngrdID"
        Me.lblIngrdID.Size = New System.Drawing.Size(106, 19)
        Me.lblIngrdID.TabIndex = 264
        Me.lblIngrdID.Text = "Ingredient ID"
        '
        'txtIngID
        '
        Me.txtIngID.Enabled = False
        Me.txtIngID.Location = New System.Drawing.Point(447, 333)
        Me.txtIngID.Name = "txtIngID"
        Me.txtIngID.Size = New System.Drawing.Size(194, 20)
        Me.txtIngID.TabIndex = 263
        '
        'DGVIngredientList
        '
        Me.DGVIngredientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVIngredientList.Enabled = False
        Me.DGVIngredientList.Location = New System.Drawing.Point(255, 423)
        Me.DGVIngredientList.Margin = New System.Windows.Forms.Padding(2)
        Me.DGVIngredientList.Name = "DGVIngredientList"
        Me.DGVIngredientList.RowTemplate.Height = 24
        Me.DGVIngredientList.Size = New System.Drawing.Size(570, 302)
        Me.DGVIngredientList.TabIndex = 267
        '
        'txtSearchIngredientName
        '
        Me.txtSearchIngredientName.Enabled = False
        Me.txtSearchIngredientName.Location = New System.Drawing.Point(448, 369)
        Me.txtSearchIngredientName.Name = "txtSearchIngredientName"
        Me.txtSearchIngredientName.Size = New System.Drawing.Size(194, 20)
        Me.txtSearchIngredientName.TabIndex = 274
        '
        'SearchLbl
        '
        Me.SearchLbl.AutoSize = True
        Me.SearchLbl.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchLbl.Location = New System.Drawing.Point(250, 368)
        Me.SearchLbl.Name = "SearchLbl"
        Me.SearchLbl.Size = New System.Drawing.Size(188, 19)
        Me.SearchLbl.TabIndex = 273
        Me.SearchLbl.Text = "Search Ingredient Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.75!)
        Me.Label4.Location = New System.Drawing.Point(864, 274)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(209, 26)
        Me.Label4.TabIndex = 277
        Me.Label4.Text = "ALL RELEASED RECORDS"
        '
        'DGVReleaseRecList
        '
        Me.DGVReleaseRecList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVReleaseRecList.Location = New System.Drawing.Point(904, 360)
        Me.DGVReleaseRecList.Margin = New System.Windows.Forms.Padding(2)
        Me.DGVReleaseRecList.Name = "DGVReleaseRecList"
        Me.DGVReleaseRecList.RowTemplate.Height = 24
        Me.DGVReleaseRecList.Size = New System.Drawing.Size(387, 252)
        Me.DGVReleaseRecList.TabIndex = 280
        '
        'DGVRecDetails
        '
        Me.DGVRecDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVRecDetails.Location = New System.Drawing.Point(904, 677)
        Me.DGVRecDetails.Margin = New System.Windows.Forms.Padding(2)
        Me.DGVRecDetails.Name = "DGVRecDetails"
        Me.DGVRecDetails.RowTemplate.Height = 24
        Me.DGVRecDetails.Size = New System.Drawing.Size(387, 207)
        Me.DGVRecDetails.TabIndex = 281
        '
        'lblLineItem
        '
        Me.lblLineItem.AutoSize = True
        Me.lblLineItem.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLineItem.Location = New System.Drawing.Point(900, 643)
        Me.lblLineItem.Name = "lblLineItem"
        Me.lblLineItem.Size = New System.Drawing.Size(145, 19)
        Me.lblLineItem.TabIndex = 282
        Me.lblLineItem.Text = "LINE ITEM DETAILS"
        '
        'txtUnitMeas
        '
        Me.txtUnitMeas.Enabled = False
        Me.txtUnitMeas.Location = New System.Drawing.Point(698, 746)
        Me.txtUnitMeas.Name = "txtUnitMeas"
        Me.txtUnitMeas.Size = New System.Drawing.Size(55, 20)
        Me.txtUnitMeas.TabIndex = 288
        Me.txtUnitMeas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(529, 746)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(163, 19)
        Me.Label9.TabIndex = 287
        Me.Label9.Text = "Unit of Measurement"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtQtyRel
        '
        Me.txtQtyRel.Enabled = False
        Me.txtQtyRel.Location = New System.Drawing.Point(571, 786)
        Me.txtQtyRel.Name = "txtQtyRel"
        Me.txtQtyRel.Size = New System.Drawing.Size(55, 20)
        Me.txtQtyRel.TabIndex = 286
        Me.txtQtyRel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(456, 787)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 19)
        Me.Label10.TabIndex = 285
        Me.Label10.Text = "Qty to Release"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtLineNo
        '
        Me.txtLineNo.Enabled = False
        Me.txtLineNo.Location = New System.Drawing.Point(447, 746)
        Me.txtLineNo.Name = "txtLineNo"
        Me.txtLineNo.Size = New System.Drawing.Size(55, 20)
        Me.txtLineNo.TabIndex = 284
        Me.txtLineNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblLineNo
        '
        Me.lblLineNo.AutoSize = True
        Me.lblLineNo.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLineNo.Location = New System.Drawing.Point(332, 746)
        Me.lblLineNo.Name = "lblLineNo"
        Me.lblLineNo.Size = New System.Drawing.Size(104, 19)
        Me.lblLineNo.TabIndex = 283
        Me.lblLineNo.Text = "Line Number"
        Me.lblLineNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEmpRecs
        '
        Me.btnEmpRecs.Location = New System.Drawing.Point(613, 171)
        Me.btnEmpRecs.Name = "btnEmpRecs"
        Me.btnEmpRecs.Size = New System.Drawing.Size(30, 23)
        Me.btnEmpRecs.TabIndex = 289
        Me.btnEmpRecs.Text = "..."
        Me.btnEmpRecs.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(900, 318)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(246, 19)
        Me.Label6.TabIndex = 290
        Me.Label6.Text = "RELEASE TRANSACTION DETAILS"
        '
        'txtEmpID
        '
        Me.txtEmpID.Enabled = False
        Me.txtEmpID.Location = New System.Drawing.Point(406, 173)
        Me.txtEmpID.Name = "txtEmpID"
        Me.txtEmpID.Size = New System.Drawing.Size(202, 20)
        Me.txtEmpID.TabIndex = 291
        '
        'txtRole
        '
        Me.txtRole.Enabled = False
        Me.txtRole.Location = New System.Drawing.Point(614, 203)
        Me.txtRole.Name = "txtRole"
        Me.txtRole.Size = New System.Drawing.Size(29, 20)
        Me.txtRole.TabIndex = 293
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
        Me.EmpRecBtn.Location = New System.Drawing.Point(1, 340)
        Me.EmpRecBtn.Name = "EmpRecBtn"
        Me.EmpRecBtn.Padding = New System.Windows.Forms.Padding(20, 0, 48, 0)
        Me.EmpRecBtn.Size = New System.Drawing.Size(204, 68)
        Me.EmpRecBtn.TabIndex = 26
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
        Me.CustRecBtn.Location = New System.Drawing.Point(2, 272)
        Me.CustRecBtn.Name = "CustRecBtn"
        Me.CustRecBtn.Padding = New System.Windows.Forms.Padding(20, 0, 47, 0)
        Me.CustRecBtn.Size = New System.Drawing.Size(203, 68)
        Me.CustRecBtn.TabIndex = 24
        Me.CustRecBtn.Text = "Customer"
        Me.CustRecBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CustRecBtn.UseVisualStyleBackColor = False
        '
        'RecordRelBtn
        '
        Me.RecordRelBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.RecordRelBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.RecordRelBtn.FlatAppearance.BorderSize = 0
        Me.RecordRelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RecordRelBtn.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecordRelBtn.Image = CType(resources.GetObject("RecordRelBtn.Image"), System.Drawing.Image)
        Me.RecordRelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RecordRelBtn.Location = New System.Drawing.Point(0, 136)
        Me.RecordRelBtn.Name = "RecordRelBtn"
        Me.RecordRelBtn.Padding = New System.Windows.Forms.Padding(20, 0, 16, 0)
        Me.RecordRelBtn.Size = New System.Drawing.Size(204, 68)
        Me.RecordRelBtn.TabIndex = 209
        Me.RecordRelBtn.Text = "Record Release"
        Me.RecordRelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RecordRelBtn.UseVisualStyleBackColor = False
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
        Me.CloseBtn.Location = New System.Drawing.Point(1, 472)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Padding = New System.Windows.Forms.Padding(20, 0, 76, 0)
        Me.CloseBtn.Size = New System.Drawing.Size(204, 68)
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
        Me.SalesRecBtn.Location = New System.Drawing.Point(1, 408)
        Me.SalesRecBtn.Name = "SalesRecBtn"
        Me.SalesRecBtn.Padding = New System.Windows.Forms.Padding(20, 0, 25, 0)
        Me.SalesRecBtn.Size = New System.Drawing.Size(204, 68)
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
        Me.SaleBtn.Location = New System.Drawing.Point(-1, 0)
        Me.SaleBtn.Name = "SaleBtn"
        Me.SaleBtn.Padding = New System.Windows.Forms.Padding(20, 0, 37, 0)
        Me.SaleBtn.Size = New System.Drawing.Size(204, 68)
        Me.SaleBtn.TabIndex = 19
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
        Me.DelivBtn.TabIndex = 21
        Me.DelivBtn.Text = "Record Delivery"
        Me.DelivBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DelivBtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.DagoyMaltoPorol.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(597, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(257, 164)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 208
        Me.PictureBox1.TabStop = False
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
        Me.OrderBtn.Location = New System.Drawing.Point(2, 204)
        Me.OrderBtn.Name = "OrderBtn"
        Me.OrderBtn.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.OrderBtn.Size = New System.Drawing.Size(202, 68)
        Me.OrderBtn.TabIndex = 211
        Me.OrderBtn.Text = "Record Order"
        Me.OrderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OrderBtn.UseVisualStyleBackColor = False
        '
        'FrmReleaseRec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1341, 989)
        Me.Controls.Add(Me.txtRole)
        Me.Controls.Add(Me.btnNewTrans)
        Me.Controls.Add(Me.txtEmpID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnEmpRecs)
        Me.Controls.Add(Me.txtUnitMeas)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtQtyRel)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtLineNo)
        Me.Controls.Add(Me.lblLineNo)
        Me.Controls.Add(Me.lblLineItem)
        Me.Controls.Add(Me.DGVRecDetails)
        Me.Controls.Add(Me.DGVReleaseRecList)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSearchIngredientName)
        Me.Controls.Add(Me.SearchLbl)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblIngrdID)
        Me.Controls.Add(Me.txtIngID)
        Me.Controls.Add(Me.DGVIngredientList)
        Me.Controls.Add(Me.ShowRoleTB)
        Me.Controls.Add(Me.RolettlTB)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.UserTitleTB)
        Me.Controls.Add(Me.EmployeeIDTB)
        Me.Controls.Add(Me.btnReleaseIng)
        Me.Controls.Add(Me.btnSaveRecord)
        Me.Controls.Add(Me.DateTB)
        Me.Controls.Add(Me.txtEmpName)
        Me.Controls.Add(Me.txtRONo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmReleaseRec"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Record Ingredient Release"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DGVIngredientList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVReleaseRecList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVRecDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRONo As System.Windows.Forms.TextBox
    Friend WithEvents DateTB As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSaveRecord As System.Windows.Forms.Button
    Friend WithEvents btnReleaseIng As System.Windows.Forms.Button
    Friend WithEvents VoidTooltip As System.Windows.Forms.ToolTip
    Friend WithEvents RecordTransTooltip As System.Windows.Forms.ToolTip
    Friend WithEvents ViewRecTooltip As System.Windows.Forms.ToolTip
    Friend WithEvents SaveCustRecTooltip As System.Windows.Forms.ToolTip
    Friend WithEvents EmployeeIDTB As System.Windows.Forms.TextBox
    Friend WithEvents UserTitleTB As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents EmpRecBtn As System.Windows.Forms.Button
    Friend WithEvents CustRecBtn As System.Windows.Forms.Button
    Friend WithEvents CloseBtn As System.Windows.Forms.Button
    Friend WithEvents SalesRecBtn As System.Windows.Forms.Button
    Friend WithEvents SaleBtn As System.Windows.Forms.Button
    Friend WithEvents DelivBtn As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents RolettlTB As System.Windows.Forms.TextBox
    Friend WithEvents ShowRoleTB As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblIngrdID As System.Windows.Forms.Label
    Friend WithEvents txtIngID As System.Windows.Forms.TextBox
    Friend WithEvents DGVIngredientList As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearchIngredientName As System.Windows.Forms.TextBox
    Friend WithEvents SearchLbl As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DGVReleaseRecList As System.Windows.Forms.DataGridView
    Friend WithEvents DGVRecDetails As System.Windows.Forms.DataGridView
    Friend WithEvents lblLineItem As System.Windows.Forms.Label
    Friend WithEvents txtUnitMeas As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtQtyRel As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtLineNo As System.Windows.Forms.TextBox
    Friend WithEvents lblLineNo As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RecordRelBtn As System.Windows.Forms.Button
    Friend WithEvents btnEmpRecs As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtEmpID As System.Windows.Forms.TextBox
    Friend WithEvents btnNewTrans As System.Windows.Forms.Button
    Friend WithEvents txtRole As System.Windows.Forms.TextBox
    Friend WithEvents OrderBtn As System.Windows.Forms.Button
End Class
