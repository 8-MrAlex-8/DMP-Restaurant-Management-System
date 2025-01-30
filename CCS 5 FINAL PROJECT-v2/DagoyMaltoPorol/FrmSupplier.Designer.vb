<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSupplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSupplier))
        Me.lblCRUDSupplier = New System.Windows.Forms.Label()
        Me.radbtnSuppID = New System.Windows.Forms.RadioButton()
        Me.radbtnSuppName = New System.Windows.Forms.RadioButton()
        Me.SortLbl = New System.Windows.Forms.Label()
        Me.DGVSuppliers = New System.Windows.Forms.DataGridView()
        Me.lblSuppName = New System.Windows.Forms.Label()
        Me.txtSuppName = New System.Windows.Forms.TextBox()
        Me.lblSuppID = New System.Windows.Forms.Label()
        Me.txtSuppID = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblContNo = New System.Windows.Forms.Label()
        Me.txtContNo = New System.Windows.Forms.TextBox()
        Me.DecorBtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DelivBtn = New System.Windows.Forms.Button()
        Me.SupplierRecBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RecallBtn = New System.Windows.Forms.Button()
        Me.OrderBtn = New System.Windows.Forms.Button()
        CType(Me.DGVSuppliers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCRUDSupplier
        '
        Me.lblCRUDSupplier.AutoSize = True
        Me.lblCRUDSupplier.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.75!)
        Me.lblCRUDSupplier.Location = New System.Drawing.Point(306, 217)
        Me.lblCRUDSupplier.Name = "lblCRUDSupplier"
        Me.lblCRUDSupplier.Size = New System.Drawing.Size(363, 26)
        Me.lblCRUDSupplier.TabIndex = 271
        Me.lblCRUDSupplier.Text = "Create/Edit/Delete Current Supplier Records"
        Me.lblCRUDSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'radbtnSuppID
        '
        Me.radbtnSuppID.AutoSize = True
        Me.radbtnSuppID.Location = New System.Drawing.Point(374, 383)
        Me.radbtnSuppID.Name = "radbtnSuppID"
        Me.radbtnSuppID.Size = New System.Drawing.Size(36, 17)
        Me.radbtnSuppID.TabIndex = 269
        Me.radbtnSuppID.TabStop = True
        Me.radbtnSuppID.Text = "ID"
        Me.radbtnSuppID.UseVisualStyleBackColor = True
        '
        'radbtnSuppName
        '
        Me.radbtnSuppName.AutoSize = True
        Me.radbtnSuppName.Location = New System.Drawing.Point(425, 383)
        Me.radbtnSuppName.Name = "radbtnSuppName"
        Me.radbtnSuppName.Size = New System.Drawing.Size(56, 17)
        Me.radbtnSuppName.TabIndex = 268
        Me.radbtnSuppName.TabStop = True
        Me.radbtnSuppName.Text = "NAME"
        Me.radbtnSuppName.UseVisualStyleBackColor = True
        '
        'SortLbl
        '
        Me.SortLbl.AutoSize = True
        Me.SortLbl.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SortLbl.Location = New System.Drawing.Point(283, 380)
        Me.SortLbl.Name = "SortLbl"
        Me.SortLbl.Size = New System.Drawing.Size(70, 24)
        Me.SortLbl.TabIndex = 267
        Me.SortLbl.Text = "SORT BY"
        Me.SortLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DGVSuppliers
        '
        Me.DGVSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSuppliers.Location = New System.Drawing.Point(287, 419)
        Me.DGVSuppliers.Margin = New System.Windows.Forms.Padding(2)
        Me.DGVSuppliers.Name = "DGVSuppliers"
        Me.DGVSuppliers.RowTemplate.Height = 24
        Me.DGVSuppliers.Size = New System.Drawing.Size(415, 252)
        Me.DGVSuppliers.TabIndex = 266
        '
        'lblSuppName
        '
        Me.lblSuppName.AutoSize = True
        Me.lblSuppName.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuppName.Location = New System.Drawing.Point(283, 294)
        Me.lblSuppName.Name = "lblSuppName"
        Me.lblSuppName.Size = New System.Drawing.Size(116, 19)
        Me.lblSuppName.TabIndex = 265
        Me.lblSuppName.Text = "Supplier Name"
        '
        'txtSuppName
        '
        Me.txtSuppName.Location = New System.Drawing.Point(467, 293)
        Me.txtSuppName.Name = "txtSuppName"
        Me.txtSuppName.Size = New System.Drawing.Size(202, 20)
        Me.txtSuppName.TabIndex = 264
        '
        'lblSuppID
        '
        Me.lblSuppID.AutoSize = True
        Me.lblSuppID.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuppID.Location = New System.Drawing.Point(283, 262)
        Me.lblSuppID.Name = "lblSuppID"
        Me.lblSuppID.Size = New System.Drawing.Size(88, 19)
        Me.lblSuppID.TabIndex = 263
        Me.lblSuppID.Text = "Supplier ID"
        '
        'txtSuppID
        '
        Me.txtSuppID.Enabled = False
        Me.txtSuppID.Location = New System.Drawing.Point(467, 261)
        Me.txtSuppID.Name = "txtSuppID"
        Me.txtSuppID.Size = New System.Drawing.Size(202, 20)
        Me.txtSuppID.TabIndex = 262
        '
        'btnDelete
        '
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Enabled = False
        Me.btnDelete.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(563, 692)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(127, 35)
        Me.btnDelete.TabIndex = 275
        Me.btnDelete.Text = "Delete Record"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.Enabled = False
        Me.btnEdit.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(432, 692)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(127, 35)
        Me.btnEdit.TabIndex = 274
        Me.btnEdit.Text = "Edit Record"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCreate.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.Location = New System.Drawing.Point(301, 692)
        Me.btnCreate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(127, 35)
        Me.btnCreate.TabIndex = 273
        Me.btnCreate.Text = "Create Record"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(829, 46)
        Me.Panel1.TabIndex = 276
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(440, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SUPPLIER RECORDS | RESTAURANT MANAGEMENT SYSTEM"
        '
        'lblContNo
        '
        Me.lblContNo.AutoSize = True
        Me.lblContNo.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContNo.Location = New System.Drawing.Point(283, 329)
        Me.lblContNo.Name = "lblContNo"
        Me.lblContNo.Size = New System.Drawing.Size(157, 19)
        Me.lblContNo.TabIndex = 279
        Me.lblContNo.Text = "Supplier Contact No."
        '
        'txtContNo
        '
        Me.txtContNo.Location = New System.Drawing.Point(467, 328)
        Me.txtContNo.Name = "txtContNo"
        Me.txtContNo.Size = New System.Drawing.Size(202, 20)
        Me.txtContNo.TabIndex = 278
        '
        'DecorBtn
        '
        Me.DecorBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.DecorBtn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.DecorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DecorBtn.Location = New System.Drawing.Point(0, 68)
        Me.DecorBtn.Name = "DecorBtn"
        Me.DecorBtn.Size = New System.Drawing.Size(9, 68)
        Me.DecorBtn.TabIndex = 25
        Me.DecorBtn.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.Controls.Add(Me.OrderBtn)
        Me.Panel2.Controls.Add(Me.DelivBtn)
        Me.Panel2.Controls.Add(Me.DecorBtn)
        Me.Panel2.Controls.Add(Me.SupplierRecBtn)
        Me.Panel2.Location = New System.Drawing.Point(-1, 47)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(203, 736)
        Me.Panel2.TabIndex = 281
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
        Me.DelivBtn.Location = New System.Drawing.Point(1, 0)
        Me.DelivBtn.Name = "DelivBtn"
        Me.DelivBtn.Padding = New System.Windows.Forms.Padding(20, 0, 12, 0)
        Me.DelivBtn.Size = New System.Drawing.Size(202, 68)
        Me.DelivBtn.TabIndex = 21
        Me.DelivBtn.Text = "Record Delivery"
        Me.DelivBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DelivBtn.UseVisualStyleBackColor = False
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
        Me.SupplierRecBtn.Location = New System.Drawing.Point(1, 68)
        Me.SupplierRecBtn.Name = "SupplierRecBtn"
        Me.SupplierRecBtn.Padding = New System.Windows.Forms.Padding(40, 0, 40, 0)
        Me.SupplierRecBtn.Size = New System.Drawing.Size(202, 68)
        Me.SupplierRecBtn.TabIndex = 27
        Me.SupplierRecBtn.Text = "Supplier"
        Me.SupplierRecBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SupplierRecBtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.DagoyMaltoPorol.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(389, 72)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(194, 131)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 272
        Me.PictureBox1.TabStop = False
        '
        'RecallBtn
        '
        Me.RecallBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RecallBtn.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecallBtn.Location = New System.Drawing.Point(674, 259)
        Me.RecallBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.RecallBtn.Name = "RecallBtn"
        Me.RecallBtn.Size = New System.Drawing.Size(56, 24)
        Me.RecallBtn.TabIndex = 282
        Me.RecallBtn.Text = "Recall"
        Me.RecallBtn.UseVisualStyleBackColor = True
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
        Me.OrderBtn.Location = New System.Drawing.Point(1, 0)
        Me.OrderBtn.Name = "OrderBtn"
        Me.OrderBtn.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.OrderBtn.Size = New System.Drawing.Size(202, 68)
        Me.OrderBtn.TabIndex = 324
        Me.OrderBtn.Text = "Record Order"
        Me.OrderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OrderBtn.UseVisualStyleBackColor = False
        '
        'FrmSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(829, 783)
        Me.Controls.Add(Me.RecallBtn)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblContNo)
        Me.Controls.Add(Me.txtContNo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblCRUDSupplier)
        Me.Controls.Add(Me.radbtnSuppID)
        Me.Controls.Add(Me.radbtnSuppName)
        Me.Controls.Add(Me.SortLbl)
        Me.Controls.Add(Me.DGVSuppliers)
        Me.Controls.Add(Me.lblSuppName)
        Me.Controls.Add(Me.txtSuppName)
        Me.Controls.Add(Me.lblSuppID)
        Me.Controls.Add(Me.txtSuppID)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Supplier Records"
        CType(Me.DGVSuppliers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCRUDSupplier As System.Windows.Forms.Label
    Friend WithEvents radbtnSuppID As System.Windows.Forms.RadioButton
    Friend WithEvents radbtnSuppName As System.Windows.Forms.RadioButton
    Friend WithEvents SortLbl As System.Windows.Forms.Label
    Friend WithEvents DGVSuppliers As System.Windows.Forms.DataGridView
    Friend WithEvents lblSuppName As System.Windows.Forms.Label
    Friend WithEvents txtSuppName As System.Windows.Forms.TextBox
    Friend WithEvents lblSuppID As System.Windows.Forms.Label
    Friend WithEvents txtSuppID As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblContNo As System.Windows.Forms.Label
    Friend WithEvents txtContNo As System.Windows.Forms.TextBox
    Friend WithEvents SupplierRecBtn As System.Windows.Forms.Button
    Friend WithEvents DelivBtn As System.Windows.Forms.Button
    Friend WithEvents DecorBtn As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents RecallBtn As System.Windows.Forms.Button
    Friend WithEvents OrderBtn As System.Windows.Forms.Button
End Class
