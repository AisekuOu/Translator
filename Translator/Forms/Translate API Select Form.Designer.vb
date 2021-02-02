<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblBaiduTLS = New System.Windows.Forms.Label()
        Me.lblTencentTLS = New System.Windows.Forms.Label()
        Me.lblYoudaoTLS = New System.Windows.Forms.Label()
        Me.lblBaiduTLSWEB = New System.Windows.Forms.Label()
        Me.lblYoudaoTLSWEB = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblClose
        '
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblClose.Location = New System.Drawing.Point(268, 9)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(16, 15)
        Me.lblClose.TabIndex = 13
        Me.lblClose.Text = "..."
        '
        'lblBaiduTLS
        '
        Me.lblBaiduTLS.AutoSize = True
        Me.lblBaiduTLS.Font = New System.Drawing.Font("Microsoft JhengHei UI", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBaiduTLS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblBaiduTLS.Image = CType(resources.GetObject("lblBaiduTLS.Image"), System.Drawing.Image)
        Me.lblBaiduTLS.Location = New System.Drawing.Point(17, 131)
        Me.lblBaiduTLS.Name = "lblBaiduTLS"
        Me.lblBaiduTLS.Size = New System.Drawing.Size(209, 38)
        Me.lblBaiduTLS.TabIndex = 17
        Me.lblBaiduTLS.Text = "                        "
        '
        'lblTencentTLS
        '
        Me.lblTencentTLS.AutoSize = True
        Me.lblTencentTLS.Font = New System.Drawing.Font("Microsoft JhengHei UI", 29.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTencentTLS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTencentTLS.Image = CType(resources.GetObject("lblTencentTLS.Image"), System.Drawing.Image)
        Me.lblTencentTLS.Location = New System.Drawing.Point(97, 192)
        Me.lblTencentTLS.Name = "lblTencentTLS"
        Me.lblTencentTLS.Size = New System.Drawing.Size(182, 49)
        Me.lblTencentTLS.TabIndex = 19
        Me.lblTencentTLS.Text = "                "
        '
        'lblYoudaoTLS
        '
        Me.lblYoudaoTLS.AutoSize = True
        Me.lblYoudaoTLS.Font = New System.Drawing.Font("Microsoft JhengHei UI", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYoudaoTLS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblYoudaoTLS.Image = CType(resources.GetObject("lblYoudaoTLS.Image"), System.Drawing.Image)
        Me.lblYoudaoTLS.Location = New System.Drawing.Point(16, 264)
        Me.lblYoudaoTLS.Name = "lblYoudaoTLS"
        Me.lblYoudaoTLS.Size = New System.Drawing.Size(182, 44)
        Me.lblYoudaoTLS.TabIndex = 20
        Me.lblYoudaoTLS.Text = "                  "
        '
        'lblBaiduTLSWEB
        '
        Me.lblBaiduTLSWEB.AutoSize = True
        Me.lblBaiduTLSWEB.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblBaiduTLSWEB.Font = New System.Drawing.Font("Microsoft JhengHei UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBaiduTLSWEB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblBaiduTLSWEB.Image = CType(resources.GetObject("lblBaiduTLSWEB.Image"), System.Drawing.Image)
        Me.lblBaiduTLSWEB.Location = New System.Drawing.Point(173, 70)
        Me.lblBaiduTLSWEB.Name = "lblBaiduTLSWEB"
        Me.lblBaiduTLSWEB.Size = New System.Drawing.Size(106, 41)
        Me.lblBaiduTLSWEB.TabIndex = 21
        Me.lblBaiduTLSWEB.Text = "           "
        '
        'lblYoudaoTLSWEB
        '
        Me.lblYoudaoTLSWEB.AutoSize = True
        Me.lblYoudaoTLSWEB.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblYoudaoTLSWEB.Font = New System.Drawing.Font("Microsoft JhengHei UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYoudaoTLSWEB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblYoudaoTLSWEB.Image = CType(resources.GetObject("lblYoudaoTLSWEB.Image"), System.Drawing.Image)
        Me.lblYoudaoTLSWEB.Location = New System.Drawing.Point(35, 70)
        Me.lblYoudaoTLSWEB.Name = "lblYoudaoTLSWEB"
        Me.lblYoudaoTLSWEB.Size = New System.Drawing.Size(122, 41)
        Me.lblYoudaoTLSWEB.TabIndex = 22
        Me.lblYoudaoTLSWEB.Text = "             "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 21)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "翻译接口启用选项"
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(295, 392)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblYoudaoTLSWEB)
        Me.Controls.Add(Me.lblBaiduTLSWEB)
        Me.Controls.Add(Me.lblYoudaoTLS)
        Me.Controls.Add(Me.lblTencentTLS)
        Me.Controls.Add(Me.lblBaiduTLS)
        Me.Controls.Add(Me.lblClose)
        Me.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form8"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form8"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblClose As Label
    Friend WithEvents lblBaiduTLS As Label
    Friend WithEvents lblTencentTLS As Label
    Friend WithEvents lblYoudaoTLS As Label
    Friend WithEvents lblBaiduTLSWEB As Label
    Friend WithEvents lblYoudaoTLSWEB As Label
    Friend WithEvents Label1 As Label
End Class
