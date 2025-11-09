<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIngredients
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIngredients))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DecorBtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DelivBtn = New System.Windows.Forms.Button()
        Me.IngredientRecBtn = New System.Windows.Forms.Button()
        Me.lblIngdStock = New System.Windows.Forms.Label()
        Me.txtIngdStock = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.lblCRUDSupplier = New System.Windows.Forms.Label()
        Me.btnRfrshSupp = New System.Windows.Forms.Button()
        Me.radbtnSuppID = New System.Windows.Forms.RadioButton()
        Me.radbtnSuppName = New System.Windows.Forms.RadioButton()
        Me.SortLbl = New System.Windows.Forms.Label()
        Me.DGVIngredients = New System.Windows.Forms.DataGridView()
        Me.lblIngdName = New System.Windows.Forms.Label()
        Me.txtIngdName = New System.Windows.Forms.TextBox()
        Me.lblIngdID = New System.Windows.Forms.Label()
        Me.txtIngdID = New System.Windows.Forms.TextBox()
        Me.lblIngdQtyToOrder = New System.Windows.Forms.Label()
        Me.txtIngdQtyToOrder = New System.Windows.Forms.TextBox()
        Me.lblIngdRepPt = New System.Windows.Forms.Label()
        Me.txtIngdRepPt = New System.Windows.Forms.TextBox()
        Me.lblIngdExp = New System.Windows.Forms.Label()
        Me.txtIngdExp = New System.Windows.Forms.TextBox()
        Me.RecallBtn = New System.Windows.Forms.Button()
        Me.lblUnitMeas = New System.Windows.Forms.Label()
        Me.txtUnitMeas = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OrderBtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DGVIngredients, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(1118, 46)
        Me.Panel1.TabIndex = 296
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
        'DecorBtn
        '
        Me.DecorBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.DecorBtn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.DecorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DecorBtn.Location = New System.Drawing.Point(0, 67)
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
        Me.Panel2.Controls.Add(Me.IngredientRecBtn)
        Me.Panel2.Location = New System.Drawing.Point(0, 46)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(203, 764)
        Me.Panel2.TabIndex = 297
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
        Me.DelivBtn.Location = New System.Drawing.Point(1, -4)
        Me.DelivBtn.Name = "DelivBtn"
        Me.DelivBtn.Padding = New System.Windows.Forms.Padding(20, 0, 12, 0)
        Me.DelivBtn.Size = New System.Drawing.Size(202, 68)
        Me.DelivBtn.TabIndex = 21
        Me.DelivBtn.Text = "Record Delivery"
        Me.DelivBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DelivBtn.UseVisualStyleBackColor = False
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
        Me.IngredientRecBtn.Location = New System.Drawing.Point(3, 68)
        Me.IngredientRecBtn.Name = "IngredientRecBtn"
        Me.IngredientRecBtn.Padding = New System.Windows.Forms.Padding(40, 0, 17, 0)
        Me.IngredientRecBtn.Size = New System.Drawing.Size(202, 68)
        Me.IngredientRecBtn.TabIndex = 28
        Me.IngredientRecBtn.Text = "Ingredients"
        Me.IngredientRecBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IngredientRecBtn.UseVisualStyleBackColor = False
        '
        'lblIngdStock
        '
        Me.lblIngdStock.AutoSize = True
        Me.lblIngdStock.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngdStock.Location = New System.Drawing.Point(263, 338)
        Me.lblIngdStock.Name = "lblIngdStock"
        Me.lblIngdStock.Size = New System.Drawing.Size(94, 19)
        Me.lblIngdStock.TabIndex = 313
        Me.lblIngdStock.Text = "No. in Stock"
        '
        'txtIngdStock
        '
        Me.txtIngdStock.Location = New System.Drawing.Point(405, 338)
        Me.txtIngdStock.Name = "txtIngdStock"
        Me.txtIngdStock.Size = New System.Drawing.Size(202, 20)
        Me.txtIngdStock.TabIndex = 312
        '
        'btnDelete
        '
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Enabled = False
        Me.btnDelete.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(740, 735)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(127, 35)
        Me.btnDelete.TabIndex = 311
        Me.btnDelete.Text = "Delete Record"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.Enabled = False
        Me.btnEdit.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(609, 735)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(127, 35)
        Me.btnEdit.TabIndex = 310
        Me.btnEdit.Text = "Edit Record"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCreate.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.Location = New System.Drawing.Point(478, 735)
        Me.btnCreate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(127, 35)
        Me.btnCreate.TabIndex = 309
        Me.btnCreate.Text = "Create Record"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'lblCRUDSupplier
        '
        Me.lblCRUDSupplier.AutoSize = True
        Me.lblCRUDSupplier.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCRUDSupplier.Location = New System.Drawing.Point(448, 205)
        Me.lblCRUDSupplier.Name = "lblCRUDSupplier"
        Me.lblCRUDSupplier.Size = New System.Drawing.Size(429, 30)
        Me.lblCRUDSupplier.TabIndex = 307
        Me.lblCRUDSupplier.Text = "Create/Edit/Delete Current Ingredient Records"
        Me.lblCRUDSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRfrshSupp
        '
        Me.btnRfrshSupp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRfrshSupp.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRfrshSupp.Location = New System.Drawing.Point(967, 421)
        Me.btnRfrshSupp.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRfrshSupp.Name = "btnRfrshSupp"
        Me.btnRfrshSupp.Size = New System.Drawing.Size(100, 24)
        Me.btnRfrshSupp.TabIndex = 306
        Me.btnRfrshSupp.Text = "Refresh DGV"
        Me.btnRfrshSupp.UseVisualStyleBackColor = True
        '
        'radbtnSuppID
        '
        Me.radbtnSuppID.AutoSize = True
        Me.radbtnSuppID.Location = New System.Drawing.Point(354, 424)
        Me.radbtnSuppID.Name = "radbtnSuppID"
        Me.radbtnSuppID.Size = New System.Drawing.Size(36, 17)
        Me.radbtnSuppID.TabIndex = 305
        Me.radbtnSuppID.TabStop = True
        Me.radbtnSuppID.Text = "ID"
        Me.radbtnSuppID.UseVisualStyleBackColor = True
        '
        'radbtnSuppName
        '
        Me.radbtnSuppName.AutoSize = True
        Me.radbtnSuppName.Location = New System.Drawing.Point(405, 424)
        Me.radbtnSuppName.Name = "radbtnSuppName"
        Me.radbtnSuppName.Size = New System.Drawing.Size(56, 17)
        Me.radbtnSuppName.TabIndex = 304
        Me.radbtnSuppName.TabStop = True
        Me.radbtnSuppName.Text = "NAME"
        Me.radbtnSuppName.UseVisualStyleBackColor = True
        '
        'SortLbl
        '
        Me.SortLbl.AutoSize = True
        Me.SortLbl.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SortLbl.Location = New System.Drawing.Point(263, 421)
        Me.SortLbl.Name = "SortLbl"
        Me.SortLbl.Size = New System.Drawing.Size(70, 24)
        Me.SortLbl.TabIndex = 303
        Me.SortLbl.Text = "SORT BY"
        Me.SortLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DGVIngredients
        '
        Me.DGVIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVIngredients.Location = New System.Drawing.Point(387, 463)
        Me.DGVIngredients.Margin = New System.Windows.Forms.Padding(2)
        Me.DGVIngredients.Name = "DGVIngredients"
        Me.DGVIngredients.RowTemplate.Height = 24
        Me.DGVIngredients.Size = New System.Drawing.Size(572, 252)
        Me.DGVIngredients.TabIndex = 302
        '
        'lblIngdName
        '
        Me.lblIngdName.AutoSize = True
        Me.lblIngdName.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngdName.Location = New System.Drawing.Point(263, 303)
        Me.lblIngdName.Name = "lblIngdName"
        Me.lblIngdName.Size = New System.Drawing.Size(134, 19)
        Me.lblIngdName.TabIndex = 301
        Me.lblIngdName.Text = "Ingredient Name"
        '
        'txtIngdName
        '
        Me.txtIngdName.Location = New System.Drawing.Point(405, 303)
        Me.txtIngdName.Name = "txtIngdName"
        Me.txtIngdName.Size = New System.Drawing.Size(202, 20)
        Me.txtIngdName.TabIndex = 300
        '
        'lblIngdID
        '
        Me.lblIngdID.AutoSize = True
        Me.lblIngdID.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngdID.Location = New System.Drawing.Point(263, 271)
        Me.lblIngdID.Name = "lblIngdID"
        Me.lblIngdID.Size = New System.Drawing.Size(106, 19)
        Me.lblIngdID.TabIndex = 299
        Me.lblIngdID.Text = "Ingredient ID"
        '
        'txtIngdID
        '
        Me.txtIngdID.Enabled = False
        Me.txtIngdID.Location = New System.Drawing.Point(405, 271)
        Me.txtIngdID.Name = "txtIngdID"
        Me.txtIngdID.Size = New System.Drawing.Size(202, 20)
        Me.txtIngdID.TabIndex = 298
        '
        'lblIngdQtyToOrder
        '
        Me.lblIngdQtyToOrder.AutoSize = True
        Me.lblIngdQtyToOrder.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngdQtyToOrder.Location = New System.Drawing.Point(698, 337)
        Me.lblIngdQtyToOrder.Name = "lblIngdQtyToOrder"
        Me.lblIngdQtyToOrder.Size = New System.Drawing.Size(100, 19)
        Me.lblIngdQtyToOrder.TabIndex = 319
        Me.lblIngdQtyToOrder.Text = "No. to Order"
        '
        'txtIngdQtyToOrder
        '
        Me.txtIngdQtyToOrder.Location = New System.Drawing.Point(876, 336)
        Me.txtIngdQtyToOrder.Name = "txtIngdQtyToOrder"
        Me.txtIngdQtyToOrder.Size = New System.Drawing.Size(191, 20)
        Me.txtIngdQtyToOrder.TabIndex = 318
        '
        'lblIngdRepPt
        '
        Me.lblIngdRepPt.AutoSize = True
        Me.lblIngdRepPt.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngdRepPt.Location = New System.Drawing.Point(698, 302)
        Me.lblIngdRepPt.Name = "lblIngdRepPt"
        Me.lblIngdRepPt.Size = New System.Drawing.Size(158, 19)
        Me.lblIngdRepPt.TabIndex = 317
        Me.lblIngdRepPt.Text = "Replenishment Point"
        '
        'txtIngdRepPt
        '
        Me.txtIngdRepPt.Location = New System.Drawing.Point(876, 301)
        Me.txtIngdRepPt.Name = "txtIngdRepPt"
        Me.txtIngdRepPt.Size = New System.Drawing.Size(191, 20)
        Me.txtIngdRepPt.TabIndex = 316
        '
        'lblIngdExp
        '
        Me.lblIngdExp.AutoSize = True
        Me.lblIngdExp.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngdExp.Location = New System.Drawing.Point(698, 270)
        Me.lblIngdExp.Name = "lblIngdExp"
        Me.lblIngdExp.Size = New System.Drawing.Size(93, 19)
        Me.lblIngdExp.TabIndex = 315
        Me.lblIngdExp.Text = "Expire Date"
        '
        'txtIngdExp
        '
        Me.txtIngdExp.Location = New System.Drawing.Point(876, 269)
        Me.txtIngdExp.Name = "txtIngdExp"
        Me.txtIngdExp.Size = New System.Drawing.Size(191, 20)
        Me.txtIngdExp.TabIndex = 314
        '
        'RecallBtn
        '
        Me.RecallBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RecallBtn.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecallBtn.Location = New System.Drawing.Point(612, 268)
        Me.RecallBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.RecallBtn.Name = "RecallBtn"
        Me.RecallBtn.Size = New System.Drawing.Size(56, 24)
        Me.RecallBtn.TabIndex = 320
        Me.RecallBtn.Text = "Recall"
        Me.RecallBtn.UseVisualStyleBackColor = True
        '
        'lblUnitMeas
        '
        Me.lblUnitMeas.AutoSize = True
        Me.lblUnitMeas.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnitMeas.Location = New System.Drawing.Point(698, 371)
        Me.lblUnitMeas.Name = "lblUnitMeas"
        Me.lblUnitMeas.Size = New System.Drawing.Size(163, 19)
        Me.lblUnitMeas.TabIndex = 322
        Me.lblUnitMeas.Text = "Unit of Measurement"
        '
        'txtUnitMeas
        '
        Me.txtUnitMeas.Location = New System.Drawing.Point(876, 370)
        Me.txtUnitMeas.Name = "txtUnitMeas"
        Me.txtUnitMeas.Size = New System.Drawing.Size(191, 20)
        Me.txtUnitMeas.TabIndex = 321
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.DagoyMaltoPorol.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(566, 61)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(194, 131)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 308
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
        Me.OrderBtn.Location = New System.Drawing.Point(2, 0)
        Me.OrderBtn.Name = "OrderBtn"
        Me.OrderBtn.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.OrderBtn.Size = New System.Drawing.Size(202, 68)
        Me.OrderBtn.TabIndex = 323
        Me.OrderBtn.Text = "Record Order"
        Me.OrderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OrderBtn.UseVisualStyleBackColor = False
        '
        'FrmIngredients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1135, 807)
        Me.Controls.Add(Me.lblUnitMeas)
        Me.Controls.Add(Me.txtUnitMeas)
        Me.Controls.Add(Me.RecallBtn)
        Me.Controls.Add(Me.lblIngdQtyToOrder)
        Me.Controls.Add(Me.txtIngdQtyToOrder)
        Me.Controls.Add(Me.lblIngdRepPt)
        Me.Controls.Add(Me.txtIngdRepPt)
        Me.Controls.Add(Me.lblIngdExp)
        Me.Controls.Add(Me.txtIngdExp)
        Me.Controls.Add(Me.lblIngdStock)
        Me.Controls.Add(Me.txtIngdStock)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblCRUDSupplier)
        Me.Controls.Add(Me.btnRfrshSupp)
        Me.Controls.Add(Me.radbtnSuppID)
        Me.Controls.Add(Me.radbtnSuppName)
        Me.Controls.Add(Me.SortLbl)
        Me.Controls.Add(Me.DGVIngredients)
        Me.Controls.Add(Me.lblIngdName)
        Me.Controls.Add(Me.txtIngdName)
        Me.Controls.Add(Me.lblIngdID)
        Me.Controls.Add(Me.txtIngdID)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmIngredients"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingredient Records"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DGVIngredients, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DelivBtn As System.Windows.Forms.Button
    Friend WithEvents DecorBtn As System.Windows.Forms.Button
    Friend WithEvents IngredientRecBtn As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblIngdStock As System.Windows.Forms.Label
    Friend WithEvents txtIngdStock As System.Windows.Forms.TextBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblCRUDSupplier As System.Windows.Forms.Label
    Friend WithEvents btnRfrshSupp As System.Windows.Forms.Button
    Friend WithEvents radbtnSuppID As System.Windows.Forms.RadioButton
    Friend WithEvents radbtnSuppName As System.Windows.Forms.RadioButton
    Friend WithEvents SortLbl As System.Windows.Forms.Label
    Friend WithEvents DGVIngredients As System.Windows.Forms.DataGridView
    Friend WithEvents lblIngdName As System.Windows.Forms.Label
    Friend WithEvents txtIngdName As System.Windows.Forms.TextBox
    Friend WithEvents lblIngdID As System.Windows.Forms.Label
    Friend WithEvents txtIngdID As System.Windows.Forms.TextBox
    Friend WithEvents lblIngdQtyToOrder As System.Windows.Forms.Label
    Friend WithEvents txtIngdQtyToOrder As System.Windows.Forms.TextBox
    Friend WithEvents lblIngdRepPt As System.Windows.Forms.Label
    Friend WithEvents txtIngdRepPt As System.Windows.Forms.TextBox
    Friend WithEvents lblIngdExp As System.Windows.Forms.Label
    Friend WithEvents txtIngdExp As System.Windows.Forms.TextBox
    Friend WithEvents RecallBtn As System.Windows.Forms.Button
    Friend WithEvents lblUnitMeas As System.Windows.Forms.Label
    Friend WithEvents txtUnitMeas As System.Windows.Forms.TextBox
    Friend WithEvents OrderBtn As System.Windows.Forms.Button
End Class
