<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.lblTSL_2 = New System.Windows.Forms.Label()
        Me.lblTSL_1 = New System.Windows.Forms.Label()
        Me.txtTSL_2 = New System.Windows.Forms.TextBox()
        Me.txtTSL_1 = New System.Windows.Forms.TextBox()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.tbxOpacity = New System.Windows.Forms.TrackBar()
        Me.lblOCR_2 = New System.Windows.Forms.Label()
        Me.txtOCR_2 = New System.Windows.Forms.TextBox()
        Me.lblOCR_1 = New System.Windows.Forms.Label()
        Me.txtOCR_1 = New System.Windows.Forms.TextBox()
        Me.PanelOther = New System.Windows.Forms.Panel()
        Me.lblDebug = New System.Windows.Forms.Label()
        Me.lblBackColor = New System.Windows.Forms.Label()
        Me.lblFont = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PanelTSL = New System.Windows.Forms.Panel()
        Me.lblTSLSwitch = New System.Windows.Forms.Label()
        Me.lblBaiduTLS = New System.Windows.Forms.Label()
        Me.lblYoudaoTLS = New System.Windows.Forms.Label()
        Me.lblTencentTLS = New System.Windows.Forms.Label()
        Me.PanelOCR = New System.Windows.Forms.Panel()
        Me.lblTesseractOCR = New System.Windows.Forms.Label()
        Me.lblTencentOCR = New System.Windows.Forms.Label()
        Me.lblScanMode = New System.Windows.Forms.Label()
        Me.lblBaiduOCR = New System.Windows.Forms.Label()
        Me.lblOTH = New System.Windows.Forms.Label()
        Me.lblTSL = New System.Windows.Forms.Label()
        Me.lblOCR = New System.Windows.Forms.Label()
        Me.lblUpgrade = New System.Windows.Forms.Label()
        CType(Me.tbxOpacity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelOther.SuspendLayout()
        Me.PanelTSL.SuspendLayout()
        Me.PanelOCR.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTSL_2
        '
        Me.lblTSL_2.AutoSize = True
        Me.lblTSL_2.Font = New System.Drawing.Font("Microsoft JhengHei UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTSL_2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTSL_2.Location = New System.Drawing.Point(14, 240)
        Me.lblTSL_2.Name = "lblTSL_2"
        Me.lblTSL_2.Size = New System.Drawing.Size(90, 18)
        Me.lblTSL_2.TabIndex = 5
        Me.lblTSL_2.Text = "SECRET_KEY"
        '
        'lblTSL_1
        '
        Me.lblTSL_1.AutoSize = True
        Me.lblTSL_1.Font = New System.Drawing.Font("Microsoft JhengHei UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTSL_1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTSL_1.Location = New System.Drawing.Point(28, 209)
        Me.lblTSL_1.Name = "lblTSL_1"
        Me.lblTSL_1.Size = New System.Drawing.Size(63, 18)
        Me.lblTSL_1.TabIndex = 4
        Me.lblTSL_1.Text = "API_KEY"
        '
        'txtTSL_2
        '
        Me.txtTSL_2.BackColor = System.Drawing.Color.Gray
        Me.txtTSL_2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTSL_2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtTSL_2.Location = New System.Drawing.Point(118, 240)
        Me.txtTSL_2.Name = "txtTSL_2"
        Me.txtTSL_2.Size = New System.Drawing.Size(140, 16)
        Me.txtTSL_2.TabIndex = 9
        '
        'txtTSL_1
        '
        Me.txtTSL_1.BackColor = System.Drawing.Color.Gray
        Me.txtTSL_1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTSL_1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtTSL_1.Location = New System.Drawing.Point(118, 204)
        Me.txtTSL_1.Name = "txtTSL_1"
        Me.txtTSL_1.Size = New System.Drawing.Size(140, 16)
        Me.txtTSL_1.TabIndex = 8
        '
        'lblClose
        '
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblClose.Location = New System.Drawing.Point(268, 9)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(16, 15)
        Me.lblClose.TabIndex = 12
        Me.lblClose.Text = "..."
        '
        'tbxOpacity
        '
        Me.tbxOpacity.Location = New System.Drawing.Point(126, 225)
        Me.tbxOpacity.Maximum = 90
        Me.tbxOpacity.Minimum = 20
        Me.tbxOpacity.Name = "tbxOpacity"
        Me.tbxOpacity.Size = New System.Drawing.Size(132, 45)
        Me.tbxOpacity.TabIndex = 13
        Me.tbxOpacity.Value = 20
        '
        'lblOCR_2
        '
        Me.lblOCR_2.AutoSize = True
        Me.lblOCR_2.Font = New System.Drawing.Font("Microsoft JhengHei UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOCR_2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblOCR_2.Location = New System.Drawing.Point(14, 240)
        Me.lblOCR_2.Name = "lblOCR_2"
        Me.lblOCR_2.Size = New System.Drawing.Size(90, 18)
        Me.lblOCR_2.TabIndex = 10
        Me.lblOCR_2.Text = "SECRET_KEY"
        '
        'txtOCR_2
        '
        Me.txtOCR_2.BackColor = System.Drawing.Color.Gray
        Me.txtOCR_2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOCR_2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtOCR_2.Location = New System.Drawing.Point(118, 240)
        Me.txtOCR_2.Name = "txtOCR_2"
        Me.txtOCR_2.Size = New System.Drawing.Size(140, 16)
        Me.txtOCR_2.TabIndex = 12
        '
        'lblOCR_1
        '
        Me.lblOCR_1.AutoSize = True
        Me.lblOCR_1.Font = New System.Drawing.Font("Microsoft JhengHei UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOCR_1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblOCR_1.Location = New System.Drawing.Point(28, 209)
        Me.lblOCR_1.Name = "lblOCR_1"
        Me.lblOCR_1.Size = New System.Drawing.Size(63, 18)
        Me.lblOCR_1.TabIndex = 9
        Me.lblOCR_1.Text = "API_KEY"
        '
        'txtOCR_1
        '
        Me.txtOCR_1.BackColor = System.Drawing.Color.Gray
        Me.txtOCR_1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOCR_1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtOCR_1.Location = New System.Drawing.Point(118, 204)
        Me.txtOCR_1.Name = "txtOCR_1"
        Me.txtOCR_1.Size = New System.Drawing.Size(140, 16)
        Me.txtOCR_1.TabIndex = 11
        '
        'PanelOther
        '
        Me.PanelOther.Controls.Add(Me.lblDebug)
        Me.PanelOther.Controls.Add(Me.lblBackColor)
        Me.PanelOther.Controls.Add(Me.lblFont)
        Me.PanelOther.Controls.Add(Me.Label2)
        Me.PanelOther.Controls.Add(Me.tbxOpacity)
        Me.PanelOther.Controls.Add(Me.Label7)
        Me.PanelOther.Controls.Add(Me.Label6)
        Me.PanelOther.Location = New System.Drawing.Point(12, 52)
        Me.PanelOther.Name = "PanelOther"
        Me.PanelOther.Size = New System.Drawing.Size(275, 332)
        Me.PanelOther.TabIndex = 16
        Me.PanelOther.Visible = False
        '
        'lblDebug
        '
        Me.lblDebug.AutoSize = True
        Me.lblDebug.Font = New System.Drawing.Font("Microsoft JhengHei UI", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDebug.Image = CType(resources.GetObject("lblDebug.Image"), System.Drawing.Image)
        Me.lblDebug.Location = New System.Drawing.Point(226, 0)
        Me.lblDebug.Name = "lblDebug"
        Me.lblDebug.Size = New System.Drawing.Size(49, 38)
        Me.lblDebug.TabIndex = 22
        Me.lblDebug.Text = "    "
        '
        'lblBackColor
        '
        Me.lblBackColor.AutoSize = True
        Me.lblBackColor.Font = New System.Drawing.Font("Microsoft JhengHei UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBackColor.Image = CType(resources.GetObject("lblBackColor.Image"), System.Drawing.Image)
        Me.lblBackColor.Location = New System.Drawing.Point(170, 135)
        Me.lblBackColor.Name = "lblBackColor"
        Me.lblBackColor.Size = New System.Drawing.Size(36, 35)
        Me.lblBackColor.TabIndex = 19
        Me.lblBackColor.Text = "   "
        '
        'lblFont
        '
        Me.lblFont.AutoSize = True
        Me.lblFont.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFont.Font = New System.Drawing.Font("Microsoft JhengHei UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFont.Image = CType(resources.GetObject("lblFont.Image"), System.Drawing.Image)
        Me.lblFont.Location = New System.Drawing.Point(170, 32)
        Me.lblFont.Name = "lblFont"
        Me.lblFont.Size = New System.Drawing.Size(36, 35)
        Me.lblFont.TabIndex = 18
        Me.lblFont.Text = "   "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft JhengHei UI", 45.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(28, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 77)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "  "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft JhengHei UI", 45.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.Location = New System.Drawing.Point(3, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 77)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "     "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft JhengHei UI", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.Location = New System.Drawing.Point(3, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 77)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "     "
        '
        'PanelTSL
        '
        Me.PanelTSL.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelTSL.Controls.Add(Me.lblTSLSwitch)
        Me.PanelTSL.Controls.Add(Me.lblTSL_1)
        Me.PanelTSL.Controls.Add(Me.lblBaiduTLS)
        Me.PanelTSL.Controls.Add(Me.lblYoudaoTLS)
        Me.PanelTSL.Controls.Add(Me.lblTSL_2)
        Me.PanelTSL.Controls.Add(Me.lblTencentTLS)
        Me.PanelTSL.Controls.Add(Me.txtTSL_1)
        Me.PanelTSL.Controls.Add(Me.txtTSL_2)
        Me.PanelTSL.Location = New System.Drawing.Point(12, 52)
        Me.PanelTSL.Name = "PanelTSL"
        Me.PanelTSL.Size = New System.Drawing.Size(275, 332)
        Me.PanelTSL.TabIndex = 17
        Me.PanelTSL.Visible = False
        '
        'lblTSLSwitch
        '
        Me.lblTSLSwitch.AutoSize = True
        Me.lblTSLSwitch.Font = New System.Drawing.Font("Microsoft JhengHei UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTSLSwitch.Image = CType(resources.GetObject("lblTSLSwitch.Image"), System.Drawing.Image)
        Me.lblTSLSwitch.Location = New System.Drawing.Point(236, 0)
        Me.lblTSLSwitch.Name = "lblTSLSwitch"
        Me.lblTSLSwitch.Size = New System.Drawing.Size(36, 35)
        Me.lblTSLSwitch.TabIndex = 23
        Me.lblTSLSwitch.Text = "   "
        '
        'lblBaiduTLS
        '
        Me.lblBaiduTLS.AutoSize = True
        Me.lblBaiduTLS.Font = New System.Drawing.Font("Microsoft JhengHei UI", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBaiduTLS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblBaiduTLS.Image = CType(resources.GetObject("lblBaiduTLS.Image"), System.Drawing.Image)
        Me.lblBaiduTLS.Location = New System.Drawing.Point(24, 18)
        Me.lblBaiduTLS.Name = "lblBaiduTLS"
        Me.lblBaiduTLS.Size = New System.Drawing.Size(209, 38)
        Me.lblBaiduTLS.TabIndex = 16
        Me.lblBaiduTLS.Text = "                        "
        '
        'lblYoudaoTLS
        '
        Me.lblYoudaoTLS.AutoSize = True
        Me.lblYoudaoTLS.Font = New System.Drawing.Font("Microsoft JhengHei UI", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYoudaoTLS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblYoudaoTLS.Image = CType(resources.GetObject("lblYoudaoTLS.Image"), System.Drawing.Image)
        Me.lblYoudaoTLS.Location = New System.Drawing.Point(24, 128)
        Me.lblYoudaoTLS.Name = "lblYoudaoTLS"
        Me.lblYoudaoTLS.Size = New System.Drawing.Size(182, 44)
        Me.lblYoudaoTLS.TabIndex = 17
        Me.lblYoudaoTLS.Text = "                  "
        '
        'lblTencentTLS
        '
        Me.lblTencentTLS.AutoSize = True
        Me.lblTencentTLS.Font = New System.Drawing.Font("Microsoft JhengHei UI", 29.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTencentTLS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTencentTLS.Image = CType(resources.GetObject("lblTencentTLS.Image"), System.Drawing.Image)
        Me.lblTencentTLS.Location = New System.Drawing.Point(76, 67)
        Me.lblTencentTLS.Name = "lblTencentTLS"
        Me.lblTencentTLS.Size = New System.Drawing.Size(182, 49)
        Me.lblTencentTLS.TabIndex = 18
        Me.lblTencentTLS.Text = "                "
        '
        'PanelOCR
        '
        Me.PanelOCR.Controls.Add(Me.lblTesseractOCR)
        Me.PanelOCR.Controls.Add(Me.lblTencentOCR)
        Me.PanelOCR.Controls.Add(Me.lblScanMode)
        Me.PanelOCR.Controls.Add(Me.lblOCR_2)
        Me.PanelOCR.Controls.Add(Me.lblBaiduOCR)
        Me.PanelOCR.Controls.Add(Me.lblOCR_1)
        Me.PanelOCR.Controls.Add(Me.txtOCR_2)
        Me.PanelOCR.Controls.Add(Me.txtOCR_1)
        Me.PanelOCR.Location = New System.Drawing.Point(12, 52)
        Me.PanelOCR.Name = "PanelOCR"
        Me.PanelOCR.Size = New System.Drawing.Size(275, 332)
        Me.PanelOCR.TabIndex = 18
        '
        'lblTesseractOCR
        '
        Me.lblTesseractOCR.AutoSize = True
        Me.lblTesseractOCR.Font = New System.Drawing.Font("Microsoft JhengHei UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTesseractOCR.ForeColor = System.Drawing.Color.Silver
        Me.lblTesseractOCR.Image = CType(resources.GetObject("lblTesseractOCR.Image"), System.Drawing.Image)
        Me.lblTesseractOCR.Location = New System.Drawing.Point(11, 128)
        Me.lblTesseractOCR.Name = "lblTesseractOCR"
        Me.lblTesseractOCR.Size = New System.Drawing.Size(218, 35)
        Me.lblTesseractOCR.TabIndex = 23
        Me.lblTesseractOCR.Text = "                             "
        '
        'lblTencentOCR
        '
        Me.lblTencentOCR.AutoSize = True
        Me.lblTencentOCR.Font = New System.Drawing.Font("Microsoft JhengHei UI", 29.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTencentOCR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTencentOCR.Image = CType(resources.GetObject("lblTencentOCR.Image"), System.Drawing.Image)
        Me.lblTencentOCR.Location = New System.Drawing.Point(76, 67)
        Me.lblTencentOCR.Name = "lblTencentOCR"
        Me.lblTencentOCR.Size = New System.Drawing.Size(182, 49)
        Me.lblTencentOCR.TabIndex = 25
        Me.lblTencentOCR.Text = "                "
        '
        'lblScanMode
        '
        Me.lblScanMode.AutoSize = True
        Me.lblScanMode.Font = New System.Drawing.Font("Microsoft JhengHei UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScanMode.Image = CType(resources.GetObject("lblScanMode.Image"), System.Drawing.Image)
        Me.lblScanMode.Location = New System.Drawing.Point(236, 0)
        Me.lblScanMode.Name = "lblScanMode"
        Me.lblScanMode.Size = New System.Drawing.Size(36, 35)
        Me.lblScanMode.TabIndex = 22
        Me.lblScanMode.Text = "   "
        '
        'lblBaiduOCR
        '
        Me.lblBaiduOCR.AutoSize = True
        Me.lblBaiduOCR.Font = New System.Drawing.Font("Microsoft JhengHei UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBaiduOCR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblBaiduOCR.Image = CType(resources.GetObject("lblBaiduOCR.Image"), System.Drawing.Image)
        Me.lblBaiduOCR.Location = New System.Drawing.Point(45, 18)
        Me.lblBaiduOCR.Name = "lblBaiduOCR"
        Me.lblBaiduOCR.Size = New System.Drawing.Size(141, 35)
        Me.lblBaiduOCR.TabIndex = 17
        Me.lblBaiduOCR.Text = "                  "
        '
        'lblOTH
        '
        Me.lblOTH.AutoSize = True
        Me.lblOTH.Font = New System.Drawing.Font("Microsoft JhengHei UI", 23.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOTH.Image = CType(resources.GetObject("lblOTH.Image"), System.Drawing.Image)
        Me.lblOTH.Location = New System.Drawing.Point(106, 9)
        Me.lblOTH.Name = "lblOTH"
        Me.lblOTH.Size = New System.Drawing.Size(41, 40)
        Me.lblOTH.TabIndex = 21
        Me.lblOTH.Text = "   "
        '
        'lblTSL
        '
        Me.lblTSL.AutoSize = True
        Me.lblTSL.Font = New System.Drawing.Font("Microsoft JhengHei UI", 23.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTSL.Image = CType(resources.GetObject("lblTSL.Image"), System.Drawing.Image)
        Me.lblTSL.Location = New System.Drawing.Point(59, 9)
        Me.lblTSL.Name = "lblTSL"
        Me.lblTSL.Size = New System.Drawing.Size(41, 40)
        Me.lblTSL.TabIndex = 20
        Me.lblTSL.Text = "   "
        '
        'lblOCR
        '
        Me.lblOCR.AutoSize = True
        Me.lblOCR.Font = New System.Drawing.Font("Microsoft JhengHei UI", 23.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOCR.Image = CType(resources.GetObject("lblOCR.Image"), System.Drawing.Image)
        Me.lblOCR.Location = New System.Drawing.Point(12, 9)
        Me.lblOCR.Name = "lblOCR"
        Me.lblOCR.Size = New System.Drawing.Size(41, 40)
        Me.lblOCR.TabIndex = 19
        Me.lblOCR.Text = "   "
        '
        'lblUpgrade
        '
        Me.lblUpgrade.AutoSize = True
        Me.lblUpgrade.Font = New System.Drawing.Font("Microsoft JhengHei UI", 23.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpgrade.Image = CType(resources.GetObject("lblUpgrade.Image"), System.Drawing.Image)
        Me.lblUpgrade.Location = New System.Drawing.Point(153, 9)
        Me.lblUpgrade.Name = "lblUpgrade"
        Me.lblUpgrade.Size = New System.Drawing.Size(33, 40)
        Me.lblUpgrade.TabIndex = 22
        Me.lblUpgrade.Text = "  "
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(295, 392)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblUpgrade)
        Me.Controls.Add(Me.lblOTH)
        Me.Controls.Add(Me.lblTSL)
        Me.Controls.Add(Me.lblOCR)
        Me.Controls.Add(Me.PanelOCR)
        Me.Controls.Add(Me.PanelTSL)
        Me.Controls.Add(Me.PanelOther)
        Me.Controls.Add(Me.lblClose)
        Me.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.TopMost = True
        CType(Me.tbxOpacity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelOther.ResumeLayout(False)
        Me.PanelOther.PerformLayout()
        Me.PanelTSL.ResumeLayout(False)
        Me.PanelTSL.PerformLayout()
        Me.PanelOCR.ResumeLayout(False)
        Me.PanelOCR.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTSL_2 As Label
    Friend WithEvents lblTSL_1 As Label
    Friend WithEvents txtTSL_2 As TextBox
    Friend WithEvents txtTSL_1 As TextBox
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents lblClose As Label
    Friend WithEvents tbxOpacity As TrackBar
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblBaiduTLS As Label
    Friend WithEvents lblYoudaoTLS As Label
    Friend WithEvents lblTencentTLS As Label
    Friend WithEvents lblOCR_2 As Label
    Friend WithEvents txtOCR_2 As TextBox
    Friend WithEvents lblOCR_1 As Label
    Friend WithEvents txtOCR_1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PanelOther As Panel
    Friend WithEvents lblBackColor As Label
    Friend WithEvents lblFont As Label
    Friend WithEvents PanelTSL As Panel
    Friend WithEvents PanelOCR As Panel
    Friend WithEvents lblBaiduOCR As Label
    Friend WithEvents lblOCR As Label
    Friend WithEvents lblTSL As Label
    Friend WithEvents lblOTH As Label
    Friend WithEvents lblScanMode As Label
    Friend WithEvents lblTesseractOCR As Label
    Friend WithEvents lblTencentOCR As Label
    Friend WithEvents lblDebug As Label
    Friend WithEvents lblTSLSwitch As Label
    Friend WithEvents lblUpgrade As Label
End Class
