<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.lblMode = New System.Windows.Forms.Label()
        Me.tbxIntroduceAuto = New System.Windows.Forms.TextBox()
        Me.lblModeAUTO = New System.Windows.Forms.Label()
        Me.lblModeManual = New System.Windows.Forms.Label()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.tbxIntroduceManual = New System.Windows.Forms.TextBox()
        Me.lblStop = New System.Windows.Forms.Label()
        Me.tbxAutoStop = New System.Windows.Forms.TextBox()
        Me.lblAutoStopYes = New System.Windows.Forms.Label()
        Me.lblAutoStopNo = New System.Windows.Forms.Label()
        Me.plOCRMode = New System.Windows.Forms.Panel()
        Me.plAUTOStop = New System.Windows.Forms.Panel()
        Me.lblLanguage = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxLanguage = New System.Windows.Forms.ComboBox()
        Me.plLanguage = New System.Windows.Forms.Panel()
        Me.plOCRMode.SuspendLayout()
        Me.plAUTOStop.SuspendLayout()
        Me.plLanguage.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMode
        '
        Me.lblMode.AutoSize = True
        Me.lblMode.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblMode.ForeColor = System.Drawing.Color.Silver
        Me.lblMode.Location = New System.Drawing.Point(12, 9)
        Me.lblMode.Name = "lblMode"
        Me.lblMode.Size = New System.Drawing.Size(76, 21)
        Me.lblMode.TabIndex = 1
        Me.lblMode.Text = "OCR模式"
        '
        'tbxIntroduceAuto
        '
        Me.tbxIntroduceAuto.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbxIntroduceAuto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxIntroduceAuto.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.tbxIntroduceAuto.ForeColor = System.Drawing.Color.Silver
        Me.tbxIntroduceAuto.Location = New System.Drawing.Point(89, 13)
        Me.tbxIntroduceAuto.Multiline = True
        Me.tbxIntroduceAuto.Name = "tbxIntroduceAuto"
        Me.tbxIntroduceAuto.ReadOnly = True
        Me.tbxIntroduceAuto.Size = New System.Drawing.Size(280, 89)
        Me.tbxIntroduceAuto.TabIndex = 2
        '
        'lblModeAUTO
        '
        Me.lblModeAUTO.AutoSize = True
        Me.lblModeAUTO.Font = New System.Drawing.Font("微软雅黑", 27.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblModeAUTO.ForeColor = System.Drawing.Color.Silver
        Me.lblModeAUTO.Image = CType(resources.GetObject("lblModeAUTO.Image"), System.Drawing.Image)
        Me.lblModeAUTO.Location = New System.Drawing.Point(15, 13)
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
        Me.lblModeManual.Location = New System.Drawing.Point(15, 108)
        Me.lblModeManual.Name = "lblModeManual"
        Me.lblModeManual.Size = New System.Drawing.Size(42, 47)
        Me.lblModeManual.TabIndex = 4
        Me.lblModeManual.Text = "  "
        '
        'lblClose
        '
        Me.lblClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblClose.Font = New System.Drawing.Font("宋体", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblClose.Location = New System.Drawing.Point(396, 10)
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
        Me.tbxIntroduceManual.Location = New System.Drawing.Point(89, 108)
        Me.tbxIntroduceManual.Multiline = True
        Me.tbxIntroduceManual.Name = "tbxIntroduceManual"
        Me.tbxIntroduceManual.ReadOnly = True
        Me.tbxIntroduceManual.Size = New System.Drawing.Size(280, 89)
        Me.tbxIntroduceManual.TabIndex = 14
        '
        'lblStop
        '
        Me.lblStop.AutoSize = True
        Me.lblStop.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblStop.ForeColor = System.Drawing.Color.Silver
        Me.lblStop.Location = New System.Drawing.Point(94, 9)
        Me.lblStop.Name = "lblStop"
        Me.lblStop.Size = New System.Drawing.Size(74, 21)
        Me.lblStop.TabIndex = 15
        Me.lblStop.Text = "自动停止"
        '
        'tbxAutoStop
        '
        Me.tbxAutoStop.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbxAutoStop.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxAutoStop.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.tbxAutoStop.ForeColor = System.Drawing.Color.Silver
        Me.tbxAutoStop.Location = New System.Drawing.Point(89, 13)
        Me.tbxAutoStop.Multiline = True
        Me.tbxAutoStop.Name = "tbxAutoStop"
        Me.tbxAutoStop.ReadOnly = True
        Me.tbxAutoStop.Size = New System.Drawing.Size(280, 131)
        Me.tbxAutoStop.TabIndex = 16
        '
        'lblAutoStopYes
        '
        Me.lblAutoStopYes.AutoSize = True
        Me.lblAutoStopYes.Font = New System.Drawing.Font("微软雅黑", 27.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblAutoStopYes.ForeColor = System.Drawing.Color.Silver
        Me.lblAutoStopYes.Image = CType(resources.GetObject("lblAutoStopYes.Image"), System.Drawing.Image)
        Me.lblAutoStopYes.Location = New System.Drawing.Point(17, 13)
        Me.lblAutoStopYes.Name = "lblAutoStopYes"
        Me.lblAutoStopYes.Size = New System.Drawing.Size(53, 47)
        Me.lblAutoStopYes.TabIndex = 17
        Me.lblAutoStopYes.Text = "   "
        '
        'lblAutoStopNo
        '
        Me.lblAutoStopNo.AutoSize = True
        Me.lblAutoStopNo.Font = New System.Drawing.Font("微软雅黑", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblAutoStopNo.ForeColor = System.Drawing.Color.Silver
        Me.lblAutoStopNo.Image = CType(resources.GetObject("lblAutoStopNo.Image"), System.Drawing.Image)
        Me.lblAutoStopNo.Location = New System.Drawing.Point(16, 105)
        Me.lblAutoStopNo.Name = "lblAutoStopNo"
        Me.lblAutoStopNo.Size = New System.Drawing.Size(55, 50)
        Me.lblAutoStopNo.TabIndex = 18
        Me.lblAutoStopNo.Text = "   "
        '
        'plOCRMode
        '
        Me.plOCRMode.Controls.Add(Me.tbxIntroduceAuto)
        Me.plOCRMode.Controls.Add(Me.lblModeAUTO)
        Me.plOCRMode.Controls.Add(Me.lblModeManual)
        Me.plOCRMode.Controls.Add(Me.tbxIntroduceManual)
        Me.plOCRMode.Location = New System.Drawing.Point(16, 33)
        Me.plOCRMode.Name = "plOCRMode"
        Me.plOCRMode.Size = New System.Drawing.Size(393, 252)
        Me.plOCRMode.TabIndex = 19
        '
        'plAUTOStop
        '
        Me.plAUTOStop.Controls.Add(Me.lblAutoStopYes)
        Me.plAUTOStop.Controls.Add(Me.tbxAutoStop)
        Me.plAUTOStop.Controls.Add(Me.lblAutoStopNo)
        Me.plAUTOStop.Location = New System.Drawing.Point(16, 33)
        Me.plAUTOStop.Name = "plAUTOStop"
        Me.plAUTOStop.Size = New System.Drawing.Size(393, 252)
        Me.plAUTOStop.TabIndex = 20
        Me.plAUTOStop.Visible = False
        '
        'lblLanguage
        '
        Me.lblLanguage.AutoSize = True
        Me.lblLanguage.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblLanguage.ForeColor = System.Drawing.Color.Silver
        Me.lblLanguage.Location = New System.Drawing.Point(174, 9)
        Me.lblLanguage.Name = "lblLanguage"
        Me.lblLanguage.Size = New System.Drawing.Size(74, 21)
        Me.lblLanguage.TabIndex = 21
        Me.lblLanguage.Text = "翻译语言"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(21, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 21)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "翻译源语言"
        '
        'cbxLanguage
        '
        Me.cbxLanguage.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxLanguage.ForeColor = System.Drawing.Color.Silver
        Me.cbxLanguage.FormattingEnabled = True
        Me.cbxLanguage.Items.AddRange(New Object() {"日本語", "English"})
        Me.cbxLanguage.Location = New System.Drawing.Point(25, 50)
        Me.cbxLanguage.Name = "cbxLanguage"
        Me.cbxLanguage.Size = New System.Drawing.Size(121, 20)
        Me.cbxLanguage.TabIndex = 24
        '
        'plLanguage
        '
        Me.plLanguage.Controls.Add(Me.Label2)
        Me.plLanguage.Controls.Add(Me.cbxLanguage)
        Me.plLanguage.Location = New System.Drawing.Point(16, 33)
        Me.plLanguage.Name = "plLanguage"
        Me.plLanguage.Size = New System.Drawing.Size(393, 252)
        Me.plLanguage.TabIndex = 25
        Me.plLanguage.Visible = False
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(427, 293)
        Me.ControlBox = False
        Me.Controls.Add(Me.plLanguage)
        Me.Controls.Add(Me.lblLanguage)
        Me.Controls.Add(Me.plAUTOStop)
        Me.Controls.Add(Me.plOCRMode)
        Me.Controls.Add(Me.lblStop)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblMode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form5"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form5"
        Me.TopMost = True
        Me.plOCRMode.ResumeLayout(False)
        Me.plOCRMode.PerformLayout()
        Me.plAUTOStop.ResumeLayout(False)
        Me.plAUTOStop.PerformLayout()
        Me.plLanguage.ResumeLayout(False)
        Me.plLanguage.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMode As Label
    Friend WithEvents tbxIntroduceAuto As TextBox
    Friend WithEvents lblModeAUTO As Label
    Friend WithEvents lblModeManual As Label
    Friend WithEvents lblClose As Label
    Friend WithEvents tbxIntroduceManual As TextBox
    Friend WithEvents lblStop As Label
    Friend WithEvents tbxAutoStop As TextBox
    Friend WithEvents lblAutoStopYes As Label
    Friend WithEvents lblAutoStopNo As Label
    Friend WithEvents plOCRMode As Panel
    Friend WithEvents plAUTOStop As Panel
    Friend WithEvents lblLanguage As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbxLanguage As ComboBox
    Friend WithEvents plLanguage As Panel
End Class
