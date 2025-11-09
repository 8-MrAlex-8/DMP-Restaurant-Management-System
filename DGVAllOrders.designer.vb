<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DGVAllOrders
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DGVAllOrders))
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.DGVAllOrderRec = New System.Windows.Forms.DataGridView()
        Me.dgvAllOrderTran = New System.Windows.Forms.DataGridView()
        CType(Me.DGVAllOrderRec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAllOrderTran, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRefresh
        '
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(756, 360)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(99, 36)
        Me.btnRefresh.TabIndex = 217
        Me.btnRefresh.Text = "Refresh DGV"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(28, 360)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(157, 36)
        Me.btnBack.TabIndex = 216
        Me.btnBack.Text = "Back to Order Page"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'DGVAllOrderRec
        '
        Me.DGVAllOrderRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAllOrderRec.Location = New System.Drawing.Point(28, 28)
        Me.DGVAllOrderRec.Name = "DGVAllOrderRec"
        Me.DGVAllOrderRec.Size = New System.Drawing.Size(400, 312)
        Me.DGVAllOrderRec.TabIndex = 215
        '
        'dgvAllOrderTran
        '
        Me.dgvAllOrderTran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAllOrderTran.Location = New System.Drawing.Point(455, 28)
        Me.dgvAllOrderTran.Name = "dgvAllOrderTran"
        Me.dgvAllOrderTran.Size = New System.Drawing.Size(400, 312)
        Me.dgvAllOrderTran.TabIndex = 218
        '
        'DGVAllOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(881, 437)
        Me.Controls.Add(Me.dgvAllOrderTran)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.DGVAllOrderRec)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DGVAllOrders"
        Me.Text = "All Orders"
        CType(Me.DGVAllOrderRec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAllOrderTran, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents DGVAllOrderRec As System.Windows.Forms.DataGridView
    Friend WithEvents dgvAllOrderTran As System.Windows.Forms.DataGridView
End Class
