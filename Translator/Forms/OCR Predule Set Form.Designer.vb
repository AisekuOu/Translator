<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form10
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.pbxOrigin = New System.Windows.Forms.PictureBox()
        Me.pbxFix = New System.Windows.Forms.PictureBox()
        Me.tbrFix = New System.Windows.Forms.TrackBar()
        Me.cbxFix = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pbxOrigin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxFix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrFix, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblClose
        '
        Me.lblClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblClose.Location = New System.Drawing.Point(377, 238)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(16, 15)
        Me.lblClose.TabIndex = 13
        Me.lblClose.Text = "..."
        '
        'pbxOrigin
        '
        Me.pbxOrigin.Dock = System.Windows.Forms.DockStyle.Top
        Me.pbxOrigin.Location = New System.Drawing.Point(0, 0)
        Me.pbxOrigin.Name = "pbxOrigin"
        Me.pbxOrigin.Size = New System.Drawing.Size(405, 87)
        Me.pbxOrigin.TabIndex = 14
        Me.pbxOrigin.TabStop = False
        '
        'pbxFix
        '
        Me.pbxFix.Dock = System.Windows.Forms.DockStyle.Top
        Me.pbxFix.Location = New System.Drawing.Point(0, 87)
        Me.pbxFix.Name = "pbxFix"
        Me.pbxFix.Size = New System.Drawing.Size(405, 87)
        Me.pbxFix.TabIndex = 15
        Me.pbxFix.TabStop = False
        '
        'tbrFix
        '
        Me.tbrFix.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbrFix.Location = New System.Drawing.Point(12, 190)
        Me.tbrFix.Maximum = 255
        Me.tbrFix.Name = "tbrFix"
        Me.tbrFix.Size = New System.Drawing.Size(381, 45)
        Me.tbrFix.TabIndex = 16
        '
        'cbxFix
        '
        Me.cbxFix.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbxFix.AutoSize = True
        Me.cbxFix.Location = New System.Drawing.Point(323, 239)
        Me.cbxFix.Name = "cbxFix"
        Me.cbxFix.Size = New System.Drawing.Size(15, 14)
        Me.cbxFix.TabIndex = 17
        Me.cbxFix.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(262, 238)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 15)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "是否启用"
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(405, 262)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxFix)
        Me.Controls.Add(Me.tbrFix)
        Me.Controls.Add(Me.pbxFix)
        Me.Controls.Add(Me.pbxOrigin)
        Me.Controls.Add(Me.lblClose)
        Me.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form10"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form10"
        CType(Me.pbxOrigin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxFix, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrFix, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblClose As Label
    Friend WithEvents pbxOrigin As PictureBox
    Friend WithEvents pbxFix As PictureBox
    Friend WithEvents tbrFix As TrackBar
    Friend WithEvents cbxFix As CheckBox
    Friend WithEvents Label1 As Label
End Class
