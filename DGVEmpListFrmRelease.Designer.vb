<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DGVEmpListFrmRelease
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DGVEmpListFrmRelease))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.dgvEmpRecs = New System.Windows.Forms.DataGridView()
        CType(Me.dgvEmpRecs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(28, 360)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(157, 36)
        Me.btnBack.TabIndex = 211
        Me.btnBack.Text = "Back to Release Page"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'dgvEmpRecs
        '
        Me.dgvEmpRecs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpRecs.Location = New System.Drawing.Point(28, 28)
        Me.dgvEmpRecs.Name = "dgvEmpRecs"
        Me.dgvEmpRecs.Size = New System.Drawing.Size(400, 312)
        Me.dgvEmpRecs.TabIndex = 210
        '
        'DGVEmpListFrmRelease
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(457, 425)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgvEmpRecs)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DGVEmpListFrmRelease"
        Me.Text = "DGVEmpListFrmRelease"
        CType(Me.dgvEmpRecs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents dgvEmpRecs As System.Windows.Forms.DataGridView
End Class
