<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DGVAllDeliveries
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DGVAllDeliveries))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.dgvALLDelReceiptRec = New System.Windows.Forms.DataGridView()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.dgvAllDelTrans = New System.Windows.Forms.DataGridView()
        CType(Me.dgvALLDelReceiptRec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAllDelTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(28, 356)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(157, 36)
        Me.btnBack.TabIndex = 213
        Me.btnBack.Text = "Back to Delivery Page"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'dgvALLDelReceiptRec
        '
        Me.dgvALLDelReceiptRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvALLDelReceiptRec.Location = New System.Drawing.Point(28, 24)
        Me.dgvALLDelReceiptRec.Name = "dgvALLDelReceiptRec"
        Me.dgvALLDelReceiptRec.Size = New System.Drawing.Size(400, 312)
        Me.dgvALLDelReceiptRec.TabIndex = 212
        '
        'btnRefresh
        '
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(755, 356)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(99, 36)
        Me.btnRefresh.TabIndex = 214
        Me.btnRefresh.Text = "Refresh DGVs"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'dgvAllDelTrans
        '
        Me.dgvAllDelTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAllDelTrans.Location = New System.Drawing.Point(454, 24)
        Me.dgvAllDelTrans.Name = "dgvAllDelTrans"
        Me.dgvAllDelTrans.Size = New System.Drawing.Size(400, 312)
        Me.dgvAllDelTrans.TabIndex = 215
        '
        'DGVAllDeliveries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(881, 437)
        Me.Controls.Add(Me.dgvAllDelTrans)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgvALLDelReceiptRec)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DGVAllDeliveries"
        Me.Text = "All Deliveries"
        CType(Me.dgvALLDelReceiptRec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAllDelTrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents dgvALLDelReceiptRec As System.Windows.Forms.DataGridView
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents dgvAllDelTrans As System.Windows.Forms.DataGridView
End Class
