<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblDragSize = New System.Windows.Forms.Label()
        Me.tbxIntroduce = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblDragSize
        '
        Me.lblDragSize.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDragSize.AutoSize = True
        Me.lblDragSize.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblDragSize.Location = New System.Drawing.Point(417, 98)
        Me.lblDragSize.Name = "lblDragSize"
        Me.lblDragSize.Size = New System.Drawing.Size(23, 12)
        Me.lblDragSize.TabIndex = 0
        Me.lblDragSize.Text = "   "
        '
        'tbxIntroduce
        '
        Me.tbxIntroduce.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxIntroduce.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbxIntroduce.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxIntroduce.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.tbxIntroduce.ForeColor = System.Drawing.Color.Silver
        Me.tbxIntroduce.Location = New System.Drawing.Point(12, 12)
        Me.tbxIntroduce.Multiline = True
        Me.tbxIntroduce.Name = "tbxIntroduce"
        Me.tbxIntroduce.Size = New System.Drawing.Size(428, 74)
        Me.tbxIntroduce.TabIndex = 1
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(452, 119)
        Me.ControlBox = False
        Me.Controls.Add(Me.tbxIntroduce)
        Me.Controls.Add(Me.lblDragSize)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form4"
        Me.Opacity = 0.85R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDragSize As Label
    Friend WithEvents tbxIntroduce As TextBox
End Class
