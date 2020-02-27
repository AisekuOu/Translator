<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxIntroduceAuto = New System.Windows.Forms.TextBox()
        Me.lblModeAUTO = New System.Windows.Forms.Label()
        Me.lblModeManual = New System.Windows.Forms.Label()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.tbxIntroduceManual = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbxAutoStop = New System.Windows.Forms.TextBox()
        Me.lblAutoStopYes = New System.Windows.Forms.Label()
        Me.lblAutoStopNo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(18, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "OCR模式选择"
        '
        'tbxIntroduceAuto
        '
        Me.tbxIntroduceAuto.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbxIntroduceAuto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxIntroduceAuto.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.tbxIntroduceAuto.ForeColor = System.Drawing.Color.Silver
        Me.tbxIntroduceAuto.Location = New System.Drawing.Point(73, 47)
        Me.tbxIntroduceAuto.Multiline = True
        Me.tbxIntroduceAuto.Name = "tbxIntroduceAuto"
        Me.tbxIntroduceAuto.ReadOnly = True
        Me.tbxIntroduceAuto.Size = New System.Drawing.Size(145, 89)
        Me.tbxIntroduceAuto.TabIndex = 2
        '
        'lblModeAUTO
        '
        Me.lblModeAUTO.AutoSize = True
        Me.lblModeAUTO.Font = New System.Drawing.Font("微软雅黑", 27.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblModeAUTO.ForeColor = System.Drawing.Color.Silver
        Me.lblModeAUTO.Image = CType(resources.GetObject("lblModeAUTO.Image"), System.Drawing.Image)
        Me.lblModeAUTO.Location = New System.Drawing.Point(14, 47)
        Me.lblModeAUTO.Name = "lblModeAUTO"
        Me.lblModeAUTO.Size = New System.Drawing.Size(42, 47)
        Me.lblModeAUTO.TabIndex = 3
        Me.lblModeAUTO.Text = "  "
        '
        'lblModeManual
        '
        Me.lblModeManual.AutoSize = True
        Me.lblModeManual.Font = New System.Drawing.Font("微软雅黑", 27.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblModeManual.ForeColor = System.Drawing.Color.Silver
        Me.lblModeManual.Image = CType(resources.GetObject("lblModeManual.Image"), System.Drawing.Image)
        Me.lblModeManual.Location = New System.Drawing.Point(12, 150)
        Me.lblModeManual.Name = "lblModeManual"
        Me.lblModeManual.Size = New System.Drawing.Size(42, 47)
        Me.lblModeManual.TabIndex = 4
        Me.lblModeManual.Text = "  "
        '
        'lblClose
        '
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblClose.Font = New System.Drawing.Font("宋体", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblClose.Location = New System.Drawing.Point(206, 9)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(19, 20)
        Me.lblClose.TabIndex = 13
        Me.lblClose.Text = "."
        '
        'tbxIntroduceManual
        '
        Me.tbxIntroduceManual.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbxIntroduceManual.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxIntroduceManual.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.tbxIntroduceManual.ForeColor = System.Drawing.Color.Silver
        Me.tbxIntroduceManual.Location = New System.Drawing.Point(73, 150)
        Me.tbxIntroduceManual.Multiline = True
        Me.tbxIntroduceManual.Name = "tbxIntroduceManual"
        Me.tbxIntroduceManual.ReadOnly = True
        Me.tbxIntroduceManual.Size = New System.Drawing.Size(145, 89)
        Me.tbxIntroduceManual.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(18, 242)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 21)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "失败后是否自动停止"
        '
        'tbxAutoStop
        '
        Me.tbxAutoStop.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbxAutoStop.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxAutoStop.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.tbxAutoStop.ForeColor = System.Drawing.Color.Silver
        Me.tbxAutoStop.Location = New System.Drawing.Point(73, 277)
        Me.tbxAutoStop.Multiline = True
        Me.tbxAutoStop.Name = "tbxAutoStop"
        Me.tbxAutoStop.ReadOnly = True
        Me.tbxAutoStop.Size = New System.Drawing.Size(145, 104)
        Me.tbxAutoStop.TabIndex = 16
        '
        'lblAutoStopYes
        '
        Me.lblAutoStopYes.AutoSize = True
        Me.lblAutoStopYes.Font = New System.Drawing.Font("微软雅黑", 27.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblAutoStopYes.ForeColor = System.Drawing.Color.Silver
        Me.lblAutoStopYes.Image = CType(resources.GetObject("lblAutoStopYes.Image"), System.Drawing.Image)
        Me.lblAutoStopYes.Location = New System.Drawing.Point(14, 277)
        Me.lblAutoStopYes.Name = "lblAutoStopYes"
        Me.lblAutoStopYes.Size = New System.Drawing.Size(53, 47)
        Me.lblAutoStopYes.TabIndex = 17
        Me.lblAutoStopYes.Text = "   "
        '
        'lblAutoStopNo
        '
        Me.lblAutoStopNo.AutoSize = True
        Me.lblAutoStopNo.Font = New System.Drawing.Font("微软雅黑", 27.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblAutoStopNo.ForeColor = System.Drawing.Color.Silver
        Me.lblAutoStopNo.Image = CType(resources.GetObject("lblAutoStopNo.Image"), System.Drawing.Image)
        Me.lblAutoStopNo.Location = New System.Drawing.Point(14, 334)
        Me.lblAutoStopNo.Name = "lblAutoStopNo"
        Me.lblAutoStopNo.Size = New System.Drawing.Size(53, 47)
        Me.lblAutoStopNo.TabIndex = 18
        Me.lblAutoStopNo.Text = "   "
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(237, 389)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblAutoStopNo)
        Me.Controls.Add(Me.lblAutoStopYes)
        Me.Controls.Add(Me.tbxAutoStop)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbxIntroduceManual)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblModeManual)
        Me.Controls.Add(Me.lblModeAUTO)
        Me.Controls.Add(Me.tbxIntroduceAuto)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form5"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form5"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents tbxIntroduceAuto As TextBox
    Friend WithEvents lblModeAUTO As Label
    Friend WithEvents lblModeManual As Label
    Friend WithEvents lblClose As Label
    Friend WithEvents tbxIntroduceManual As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbxAutoStop As TextBox
    Friend WithEvents lblAutoStopYes As Label
    Friend WithEvents lblAutoStopNo As Label
End Class
