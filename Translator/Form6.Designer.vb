<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.lblDragSize = New System.Windows.Forms.Label()
        Me.tbxIntroduce = New System.Windows.Forms.TextBox()
        Me.trkbxCheck = New System.Windows.Forms.TrackBar()
        Me.lblCheck = New System.Windows.Forms.Label()
        CType(Me.trkbxCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDragSize
        '
        Me.lblDragSize.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDragSize.AutoSize = True
        Me.lblDragSize.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblDragSize.Location = New System.Drawing.Point(418, 172)
        Me.lblDragSize.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDragSize.Name = "lblDragSize"
        Me.lblDragSize.Size = New System.Drawing.Size(23, 12)
        Me.lblDragSize.TabIndex = 1
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
        Me.tbxIntroduce.Size = New System.Drawing.Size(428, 128)
        Me.tbxIntroduce.TabIndex = 2
        '
        'trkbxCheck
        '
        Me.trkbxCheck.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.trkbxCheck.Location = New System.Drawing.Point(12, 157)
        Me.trkbxCheck.Maximum = 254
        Me.trkbxCheck.Name = "trkbxCheck"
        Me.trkbxCheck.Size = New System.Drawing.Size(304, 45)
        Me.trkbxCheck.TabIndex = 3
        Me.trkbxCheck.Value = 200
        '
        'lblCheck
        '
        Me.lblCheck.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCheck.AutoSize = True
        Me.lblCheck.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCheck.Font = New System.Drawing.Font("宋体", 34.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblCheck.Image = CType(resources.GetObject("lblCheck.Image"), System.Drawing.Image)
        Me.lblCheck.Location = New System.Drawing.Point(322, 143)
        Me.lblCheck.Name = "lblCheck"
        Me.lblCheck.Size = New System.Drawing.Size(66, 46)
        Me.lblCheck.TabIndex = 4
        Me.lblCheck.Text = "  "
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(452, 193)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblCheck)
        Me.Controls.Add(Me.trkbxCheck)
        Me.Controls.Add(Me.tbxIntroduce)
        Me.Controls.Add(Me.lblDragSize)
        Me.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form6"
        Me.Opacity = 0.85R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form6"
        Me.TopMost = True
        CType(Me.trkbxCheck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDragSize As Label
    Friend WithEvents tbxIntroduce As TextBox
    Friend WithEvents trkbxCheck As TrackBar
    Friend WithEvents lblCheck As Label
End Class
