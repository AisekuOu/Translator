Public Class Form2

    Public Event FormClose()

    Private Dragging As Boolean
    Private Original As Point
    Private Now As Point

    Private WithEvents ScanModeForm As Form5
    Private WithEvents OCR_ThresholdForm As Form6
    Private WithEvents TSL_SwitchForm As Form8

    Private Sub Down(sender As Object, e As MouseEventArgs) Handles Me.MouseDown

        Dragging = True

        Original = New Point(e.X, e.Y)

    End Sub

    Private Sub Up(sender As Object, e As MouseEventArgs) Handles Me.MouseUp

        Dragging = False

    End Sub

    Private Sub Move_(sender As Object, e As MouseEventArgs) Handles Me.MouseMove

        If Dragging = True Then

            Now = PointToScreen(New Point(e.X, e.Y))

            Now.Offset(Original.X * -1, Original.Y * -1)

            Location = Now

        End If

    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click

        Me.Visible = False

        RaiseEvent FormClose()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load

        Select Case My.Settings.OCR_API_Choice

            Case "Tesseract"

                lblOCR_1.Visible = False

                lblOCR_2.Visible = False

                txtOCR_1.Visible = False

                txtOCR_2.Visible = False

                lblTesseractOCR.BackColor = Color.Gray

            Case "Baidu"

                lblOCR_1.Visible = True

                lblOCR_2.Visible = True

                lblOCR_1.Text = "API_KEY"

                lblOCR_2.Text = "SECRET_KEY"

                txtOCR_1.Visible = True

                txtOCR_2.Visible = True

                txtOCR_1.Text = My.Settings.BDOCR_API_KEY

                txtOCR_2.Text = My.Settings.BDOCR_SECRET_KEY

                lblBaiduOCR.BackColor = Color.Gray

            Case "Tencent"

                lblOCR_1.Visible = True

                lblOCR_2.Visible = True

                lblOCR_1.Text = "API_ID"

                lblOCR_2.Text = "API_KEY"

                txtOCR_1.Visible = True

                txtOCR_2.Visible = True

                txtOCR_1.Text = My.Settings.TCOCR_API_ID

                txtOCR_2.Text = My.Settings.TCOCR_API_KEY

                lblTencentOCR.BackColor = Color.Gray

        End Select

        Select Case My.Settings.TSL_API_Choice

            Case "Baidu"

                txtTSL_1.Text = My.Settings.BDTSL_API_ID

                txtTSL_2.Text = My.Settings.BDTSL_API_KEY

                lblTSL_1.Text = "API_ID"

                lblTSL_2.Text = "API_KEY"

                lblBaiduTLS.BackColor = Color.Gray

            Case "Youdao"

                txtTSL_1.Text = My.Settings.YDTSL_API_KEY

                txtTSL_2.Text = My.Settings.YDTSL_SECRET_KEY

                lblTSL_1.Text = "API_KEY"

                lblTSL_2.Text = "SECRET_KEY"

                lblYoudaoTLS.BackColor = Color.Gray

            Case "Tencent"

                txtTSL_1.Text = My.Settings.TCTSL_API_ID

                txtTSL_2.Text = My.Settings.TCTSL_API_KEY

                lblTSL_1.Text = "API_ID"

                lblTSL_2.Text = "API_KEY"

                lblTencentTLS.BackColor = Color.Gray

        End Select

        FontDialog1.ShowColor = True

        FontDialog1.Color = My.Settings.FontCOLOR

        FontDialog1.Font = My.Settings.FontSTYLE

        tbxOpacity.Value = My.Settings.BackOpacity * 100

        Me.Opacity = My.Settings.BackOpacity

        If My.Settings.LOG_Switch = True Then

            lblDebug.BackColor = Color.Gray

        Else

            lblDebug.BackColor = Me.BackColor

        End If

    End Sub

    Private Sub lblFont_Click(sender As Object, e As EventArgs) Handles lblFont.Click

        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            My.Settings.FontCOLOR = FontDialog1.Color

            My.Settings.FontSTYLE = FontDialog1.Font

        End If

    End Sub

    Private Sub lblBackColor_Click(sender As Object, e As EventArgs) Handles lblBackColor.Click

        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            My.Settings.BackCOLOR = ColorDialog1.Color

        End If

    End Sub

    Private Sub tbxOpacity_Scroll(sender As Object, e As EventArgs) Handles tbxOpacity.Scroll

        Me.Opacity = tbxOpacity.Value / 100

        My.Settings.BackOpacity = Me.Opacity

    End Sub

    Private Sub txtOCR_1_TextChanged(sender As Object, e As EventArgs) Handles txtOCR_1.TextChanged

        Select Case My.Settings.OCR_API_Choice

            Case "Baidu"

                My.Settings.BDOCR_API_KEY = txtOCR_1.Text

            Case "Tencent"

                My.Settings.TCOCR_API_ID = txtOCR_1.Text

        End Select

    End Sub

    Private Sub txtOCR_2_TextChanged(sender As Object, e As EventArgs) Handles txtOCR_2.TextChanged

        Select Case My.Settings.OCR_API_Choice

            Case "Baidu"

                My.Settings.BDOCR_SECRET_KEY = txtOCR_2.Text

            Case "Tencent"

                My.Settings.TCOCR_API_KEY = txtOCR_2.Text

        End Select

    End Sub

    Private Sub txtTSL_1_TextChanged(sender As Object, e As EventArgs) Handles txtTSL_1.TextChanged

        Select Case My.Settings.TSL_API_Choice

            Case "Baidu"

                My.Settings.BDTSL_API_ID = txtTSL_1.Text

            Case "Youdao"

                My.Settings.YDTSL_API_KEY = txtTSL_1.Text

            Case "Tencent"

                My.Settings.TCTSL_API_ID = txtTSL_1.Text

        End Select

    End Sub

    Private Sub txtTSL_2_TextChanged(sender As Object, e As EventArgs) Handles txtTSL_2.TextChanged

        Select Case My.Settings.TSL_API_Choice

            Case "Baidu"

                My.Settings.BDTSL_API_KEY = txtTSL_2.Text

            Case "Youdao"

                My.Settings.YDTSL_SECRET_KEY = txtTSL_2.Text

            Case "Tencent"

                My.Settings.TCTSL_API_KEY = txtTSL_2.Text

        End Select

    End Sub

    Private Sub lbl_MouseEnter(sender As Object, e As EventArgs) Handles lblFont.MouseEnter, lblBackColor.MouseEnter, lblOCR.MouseEnter, lblTSL.MouseEnter, lblOTH.MouseEnter, lblTesseractOCR.MouseEnter, lblBaiduOCR.MouseEnter, lblTencentOCR.MouseEnter, lblBaiduTLS.MouseEnter, lblYoudaoTLS.MouseEnter, lblTencentTLS.MouseEnter, lblScanMode.MouseEnter, lblOCR_Threshold.MouseEnter, lblDebug.MouseEnter, lblTSLSwitch.MouseEnter

        sender.BackColor = Color.Gray

    End Sub

    Private Sub lbl_MouseLeave(sender As Object, e As EventArgs) Handles lblFont.MouseLeave, lblBackColor.MouseLeave, lblOCR.MouseLeave, lblTSL.MouseLeave, lblOTH.MouseLeave, lblTesseractOCR.MouseLeave, lblBaiduOCR.MouseLeave, lblTencentOCR.MouseLeave, lblBaiduTLS.MouseLeave, lblYoudaoTLS.MouseLeave, lblTencentTLS.MouseLeave, lblScanMode.MouseLeave, lblOCR_Threshold.MouseLeave, lblDebug.MouseLeave, lblTSLSwitch.MouseLeave

        Dim OCR_API_Choice_Name() = {"Tesseract", "Baidu", "Tencent"}
        Dim OCR_API_Choice_NObject() = {lblTesseractOCR, lblBaiduOCR， lblTencentOCR}

        Dim TSL_API_Choice_Name() = {"Baidu", "Youdao", "Tencent"}
        Dim TSL_API_Choice_NObject() = {lblBaiduTLS, lblYoudaoTLS, lblTencentTLS}

        For i As Integer = 0 To OCR_API_Choice_NObject.Length - 1

            If OCR_API_Choice_NObject(i) Is sender Then

                If OCR_API_Choice_Name（i） = My.Settings.OCR_API_Choice Then

                    Exit Sub

                End If

            End If

        Next

        For i As Integer = 0 To TSL_API_Choice_NObject.Length - 1

            If TSL_API_Choice_NObject(i) Is sender Then

                If TSL_API_Choice_Name（i） = My.Settings.TSL_API_Choice Then

                    Exit Sub

                End If

            End If

        Next

        If My.Settings.LOG_Switch = True And sender Is lblDebug Then

            Exit Sub

        End If

        sender.BackColor = Me.BackColor

    End Sub

    Private Sub lbl_TSL_Click(sender As Object, e As EventArgs) Handles lblBaiduTLS.Click, lblYoudaoTLS.Click, lblTencentTLS.Click

        Dim sender_name As String = ""
        Dim TSL_API_Choice_Name() = {"Baidu", "Youdao", "Tencent"}
        Dim TSL_API_Choice_NObject() = {lblBaiduTLS, lblYoudaoTLS, lblTencentTLS}

        For i As Integer = 0 To TSL_API_Choice_NObject.Length - 1

            TSL_API_Choice_NObject(i).BackColor = Me.BackColor

        Next

        For i As Integer = 0 To TSL_API_Choice_NObject.Length - 1

            If sender Is TSL_API_Choice_NObject(i) Then

                sender_name = TSL_API_Choice_Name(i)

                Exit For

            End If

        Next

        Select Case sender_name

            Case "Baidu"

                My.Settings.TSL_API_Choice = "Baidu"

                txtTSL_1.Text = My.Settings.BDTSL_API_ID

                txtTSL_2.Text = My.Settings.BDTSL_API_KEY

                lblTSL_1.Text = "API_ID"

                lblTSL_2.Text = "API_KEY"

                lblBaiduTLS.BackColor = Color.Gray

            Case "Youdao"

                My.Settings.TSL_API_Choice = "Youdao"

                txtTSL_1.Text = My.Settings.YDTSL_API_KEY

                txtTSL_2.Text = My.Settings.YDTSL_SECRET_KEY

                lblTSL_1.Text = "API_KEY"

                lblTSL_2.Text = "SECRET_KEY"

                lblYoudaoTLS.BackColor = Color.Gray

            Case "Tencent"

                My.Settings.TSL_API_Choice = "Tencent"

                txtTSL_1.Text = My.Settings.TCTSL_API_ID

                txtTSL_2.Text = My.Settings.TCTSL_API_KEY

                lblTSL_1.Text = "API_ID"

                lblTSL_2.Text = "API_KEY"

                lblTencentTLS.BackColor = Color.Gray

        End Select

    End Sub

    Private Sub lblMENU_Click(sender As Object, e As EventArgs) Handles lblOCR.Click, lblTSL.Click, lblOTH.Click

        Dim lblMENU_Object() = {lblOCR, lblTSL, lblOTH}
        Dim Panel_Object() = {PanelOCR, PanelTSL, PanelOther}

        For i As Integer = 0 To Panel_Object.Length - 1

            If lblMENU_Object(i) Is sender Then

                If Panel_Object(i).Visible = True Then

                    Exit Sub

                End If

            End If

            Panel_Object(i).Visible = False

        Next

        For i As Integer = 0 To lblMENU_Object.Length - 1

            If lblMENU_Object(i) Is sender Then

                Panel_Object(i).Visible = True

            End If

        Next

    End Sub

    Private Sub lblScanMode_Click(sender As Object, e As EventArgs) Handles lblScanMode.Click

        ScanModeForm = New Form5

        ScanModeForm.Show()

        Me.Visible = False

    End Sub

    Private Sub ScanModeForm_Close() Handles ScanModeForm.FormClose

        Me.Visible = True

        ScanModeForm.Close()

    End Sub

    Private Sub lblOCR_Threshold_Click(sender As Object, e As EventArgs) Handles lblOCR_Threshold.Click

        OCR_ThresholdForm = New Form6

        OCR_ThresholdForm.Show()

        Me.Visible = False

    End Sub

    Private Sub OCR_ThresholdForm_Close() Handles OCR_ThresholdForm.FormClose

        Me.Visible = True

        OCR_ThresholdForm.Close()

    End Sub

    Private Sub lbl_OCR_Click(sender As Object, e As EventArgs) Handles lblTesseractOCR.Click, lblBaiduOCR.Click, lblTencentOCR.Click

        Dim sender_name As String = ""
        Dim OCR_API_Choice_Name() = {"Tesseract", "Baidu", "Tencent"}
        Dim OCR_API_Choice_NObject() = {lblTesseractOCR, lblBaiduOCR， lblTencentOCR}

        For i As Integer = 0 To OCR_API_Choice_NObject.Length - 1

            OCR_API_Choice_NObject(i).BackColor = Me.BackColor

        Next

        For i As Integer = 0 To OCR_API_Choice_NObject.Length - 1

            If sender Is OCR_API_Choice_NObject(i) Then

                sender_name = OCR_API_Choice_Name(i)

                Exit For

            End If

        Next

        Select Case sender_name

            Case "Tesseract"

                My.Settings.OCR_API_Choice = "Tesseract"

                lblOCR_1.Visible = False

                lblOCR_2.Visible = False

                txtOCR_1.Visible = False

                txtOCR_2.Visible = False

                lblTesseractOCR.BackColor = Color.Gray

            Case "Baidu"

                My.Settings.OCR_API_Choice = "Baidu"

                lblOCR_1.Visible = True

                lblOCR_2.Visible = True

                lblOCR_1.Text = "API_KEY"

                lblOCR_2.Text = "SECRET_KEY"

                txtOCR_1.Visible = True

                txtOCR_2.Visible = True

                txtOCR_1.Text = My.Settings.BDOCR_API_KEY

                txtOCR_2.Text = My.Settings.BDOCR_SECRET_KEY

                lblBaiduOCR.BackColor = Color.Gray

            Case "Tencent"

                My.Settings.OCR_API_Choice = "Tencent"

                lblOCR_1.Visible = True

                lblOCR_2.Visible = True

                lblOCR_1.Text = "API_ID"

                lblOCR_2.Text = "API_KEY"

                txtOCR_1.Visible = True

                txtOCR_2.Visible = True

                txtOCR_1.Text = My.Settings.TCOCR_API_ID

                txtOCR_2.Text = My.Settings.TCOCR_API_KEY

                lblTencentOCR.BackColor = Color.Gray

        End Select

    End Sub

    Private Sub lblDebug_Click(sender As Object, e As EventArgs) Handles lblDebug.Click

        If My.Settings.LOG_Switch = True Then

            My.Settings.LOG_Switch = False

            lblDebug.BackColor = Me.BackColor

        Else

            My.Settings.LOG_Switch = True

            lblDebug.BackColor = Color.Gray

        End If

    End Sub

    Private Sub lblTSLSwitch_Click(sender As Object, e As EventArgs) Handles lblTSLSwitch.Click

        TSL_SwitchForm = New Form8

        TSL_SwitchForm.Show()

        Me.Visible = False

    End Sub

    Private Sub TSL_SwitchForm_Close() Handles TSL_SwitchForm.FormClose

        Me.Visible = True

        TSL_SwitchForm.Close()

    End Sub

End Class