<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lbxTranslateResult = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiStart = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiStop = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiConfig = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiQuit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbx_Focus = New System.Windows.Forms.TextBox()
        Me.lblLeft = New System.Windows.Forms.Label()
        Me.lblRight = New System.Windows.Forms.Label()
        Me.lblStartStep = New System.Windows.Forms.Label()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblConfig = New System.Windows.Forms.Label()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.lblDragSize = New System.Windows.Forms.Label()
        Me.lblFix = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbxTranslateResult
        '
        Me.lbxTranslateResult.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbxTranslateResult.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbxTranslateResult.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbxTranslateResult.Font = New System.Drawing.Font("Microsoft JhengHei UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxTranslateResult.ForeColor = System.Drawing.Color.White
        Me.lbxTranslateResult.Location = New System.Drawing.Point(0, 0)
        Me.lbxTranslateResult.Multiline = True
        Me.lbxTranslateResult.Name = "lbxTranslateResult"
        Me.lbxTranslateResult.ReadOnly = True
        Me.lbxTranslateResult.Size = New System.Drawing.Size(405, 46)
        Me.lbxTranslateResult.TabIndex = 4
        Me.lbxTranslateResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer1
        '
        Me.Timer1.Interval = 150
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiStart, Me.tsmiStop, Me.tsmiConfig, Me.tsmiQuit})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(125, 92)
        '
        'tsmiStart
        '
        Me.tsmiStart.Name = "tsmiStart"
        Me.tsmiStart.Size = New System.Drawing.Size(124, 22)
        Me.tsmiStart.Text = "开始翻译"
        '
        'tsmiStop
        '
        Me.tsmiStop.Name = "tsmiStop"
        Me.tsmiStop.Size = New System.Drawing.Size(124, 22)
        Me.tsmiStop.Text = "停止翻译"
        '
        'tsmiConfig
        '
        Me.tsmiConfig.Name = "tsmiConfig"
        Me.tsmiConfig.Size = New System.Drawing.Size(124, 22)
        Me.tsmiConfig.Text = "设置"
        '
        'tsmiQuit
        '
        Me.tsmiQuit.Name = "tsmiQuit"
        Me.tsmiQuit.Size = New System.Drawing.Size(124, 22)
        Me.tsmiQuit.Text = "退出"
        '
        'tbx_Focus
        '
        Me.tbx_Focus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbx_Focus.Location = New System.Drawing.Point(32, 62)
        Me.tbx_Focus.Name = "tbx_Focus"
        Me.tbx_Focus.Size = New System.Drawing.Size(0, 23)
        Me.tbx_Focus.TabIndex = 8
        '
        'lblLeft
        '
        Me.lblLeft.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblLeft.AutoSize = True
        Me.lblLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblLeft.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeft.Image = Global.Translator.My.Resources.Resources.Right
        Me.lblLeft.Location = New System.Drawing.Point(38, 56)
        Me.lblLeft.Name = "lblLeft"
        Me.lblLeft.Size = New System.Drawing.Size(21, 20)
        Me.lblLeft.TabIndex = 10
        Me.lblLeft.Text = "   "
        '
        'lblRight
        '
        Me.lblRight.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRight.AutoSize = True
        Me.lblRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblRight.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRight.Image = Global.Translator.My.Resources.Resources.Left
        Me.lblRight.Location = New System.Drawing.Point(106, 55)
        Me.lblRight.Name = "lblRight"
        Me.lblRight.Size = New System.Drawing.Size(21, 20)
        Me.lblRight.TabIndex = 9
        Me.lblRight.Text = "   "
        '
        'lblStartStep
        '
        Me.lblStartStep.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStartStep.AutoSize = True
        Me.lblStartStep.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblStartStep.Font = New System.Drawing.Font("Microsoft JhengHei UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartStep.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblStartStep.Image = Global.Translator.My.Resources.Resources._step
        Me.lblStartStep.Location = New System.Drawing.Point(259, 49)
        Me.lblStartStep.Name = "lblStartStep"
        Me.lblStartStep.Size = New System.Drawing.Size(36, 35)
        Me.lblStartStep.TabIndex = 7
        Me.lblStartStep.Text = "   "
        '
        'lblClose
        '
        Me.lblClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblClose.Font = New System.Drawing.Font("Microsoft JhengHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblClose.Image = Global.Translator.My.Resources.Resources.close___
        Me.lblClose.Location = New System.Drawing.Point(6, 58)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(20, 18)
        Me.lblClose.TabIndex = 6
        Me.lblClose.Text = "   "
        '
        'lblConfig
        '
        Me.lblConfig.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblConfig.AutoSize = True
        Me.lblConfig.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblConfig.Font = New System.Drawing.Font("Microsoft JhengHei UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfig.ForeColor = System.Drawing.Color.Yellow
        Me.lblConfig.Image = Global.Translator.My.Resources.Resources.option_
        Me.lblConfig.Location = New System.Drawing.Point(202, 49)
        Me.lblConfig.Name = "lblConfig"
        Me.lblConfig.Size = New System.Drawing.Size(43, 35)
        Me.lblConfig.TabIndex = 5
        Me.lblConfig.Text = "    "
        '
        'lblStart
        '
        Me.lblStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStart.AutoSize = True
        Me.lblStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblStart.Font = New System.Drawing.Font("Microsoft JhengHei UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblStart.Image = Global.Translator.My.Resources.Resources.run_
        Me.lblStart.Location = New System.Drawing.Point(309, 49)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(36, 35)
        Me.lblStart.TabIndex = 3
        Me.lblStart.Text = "   "
        '
        'lblDragSize
        '
        Me.lblDragSize.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDragSize.AutoSize = True
        Me.lblDragSize.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDragSize.Font = New System.Drawing.Font("Microsoft JhengHei UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDragSize.ForeColor = System.Drawing.Color.Fuchsia
        Me.lblDragSize.Image = Global.Translator.My.Resources.Resources.zoom_
        Me.lblDragSize.Location = New System.Drawing.Point(359, 49)
        Me.lblDragSize.Name = "lblDragSize"
        Me.lblDragSize.Size = New System.Drawing.Size(43, 35)
        Me.lblDragSize.TabIndex = 2
        Me.lblDragSize.Text = "    "
        '
        'lblFix
        '
        Me.lblFix.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFix.AutoSize = True
        Me.lblFix.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFix.Font = New System.Drawing.Font("Microsoft JhengHei UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFix.ForeColor = System.Drawing.Color.Yellow
        Me.lblFix.Image = Global.Translator.My.Resources.Resources.flow
        Me.lblFix.Location = New System.Drawing.Point(145, 49)
        Me.lblFix.Name = "lblFix"
        Me.lblFix.Size = New System.Drawing.Size(43, 35)
        Me.lblFix.TabIndex = 11
        Me.lblFix.Text = "    "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(405, 87)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblFix)
        Me.Controls.Add(Me.lblLeft)
        Me.Controls.Add(Me.lblRight)
        Me.Controls.Add(Me.tbx_Focus)
        Me.Controls.Add(Me.lblStartStep)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblConfig)
        Me.Controls.Add(Me.lbxTranslateResult)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.lblDragSize)
        Me.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimumSize = New System.Drawing.Size(405, 87)
        Me.Name = "Form1"
        Me.Opacity = 0R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Translator"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDragSize As Label
    Friend WithEvents lblStart As Label
    Friend WithEvents lbxTranslateResult As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblConfig As Label
    Friend WithEvents lblClose As Label
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents tsmiStart As ToolStripMenuItem
    Friend WithEvents tsmiStop As ToolStripMenuItem
    Friend WithEvents tsmiConfig As ToolStripMenuItem
    Friend WithEvents tsmiQuit As ToolStripMenuItem
    Friend WithEvents lblStartStep As Label
    Friend WithEvents tbx_Focus As TextBox
    Friend WithEvents lblRight As Label
    Friend WithEvents lblLeft As Label
    Friend WithEvents lblFix As Label
End Class
