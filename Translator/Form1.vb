Imports System.Threading

Public Class Form1

    Private Dragging As Boolean
    Private Original As Point
    Private Now As Point

    Private WithEvents API_OCR_LOCAL As OCR_Tesseract = New OCR_Tesseract
    Private WithEvents API_OCR_BD As BaiduAPI_OCR = New BaiduAPI_OCR
    Private WithEvents API_OCR_TC As TencentAPI_OCR = New TencentAPI_OCR
    Private WithEvents API_Translate_BD As BaiduAPI_Translate = New BaiduAPI_Translate
    Private WithEvents WEB_Translate_BD As BaiduWEB_Translate = New BaiduWEB_Translate
    Private WithEvents API_Translate_YD As YoudaoAPI_Translate = New YoudaoAPI_Translate
    Private WithEvents WEB_Translate_YD As YoudaoWEB_Translate = New YoudaoWEB_Translate
    Private WithEvents API_Translate_TC As TencentAPI_Translate = New TencentAPI_Translate

    Private NoticeForm As Form9 = New Form9
    Private WithEvents ConfigForm As Form2 = New Form2
    Private WithEvents IntroduceForm As Form3 = New Form3

    Private Zoomit As XYDES = New XYDES

    Private loggerPrint As Logger = New Logger

    Private Sub Down(sender As Object, e As MouseEventArgs) Handles Me.MouseDown

        Dragging = True

        Original = New Point(e.X, e.Y)

    End Sub

    Private Sub Up(sender As Object, e As MouseEventArgs) Handles Me.MouseUp

        Dragging = False

    End Sub

    Private Sub Move_(sender As Object, e As MouseEventArgs) Handles Me.MouseMove

        If Dragging = True Then

            If State <> "Stop" Then

                Application_STOP()

            End If

            Now = PointToScreen(New Point(e.X, e.Y))

            Now.Offset(Original.X * -1, Original.Y * -1)

            Location = Now

            NoticeForm.FormPosition(Location）

        End If

    End Sub

    Private Sub lblDragSize_MouseDown(sender As Object, e As MouseEventArgs) Handles lblDragSize.MouseDown

        Dragging = True

        Original = New Point(e.X, e.Y)

    End Sub

    Private Sub lblDragSize_MouseUp(sender As Object, e As MouseEventArgs) Handles lblDragSize.MouseUp

        Dragging = False

    End Sub

    Private Sub lblDragSize_MouseMove(sender As Object, e As MouseEventArgs) Handles lblDragSize.MouseMove

        If Dragging = True Then

            If State <> "Stop" Then

                Application_STOP()

            End If

            Me.Width += e.X - Original.X

            Me.Height += e.Y - Original.Y

        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        FormStatusInit()

        picCapture("temp")

        picCapture("detect")

        IntroduceForm.Visible = True

        State = "Stop"

    End Sub

    Dim Result_String As String

    Private Sub Translate()

        Debug.Print("Detect Different Picture")

        If State <> "Step" Then

            State = "Translating"

            ShowStatus()

        End If

        '截取要翻译的截图
        Me.Opacity = 0
        picCapture("Trans")
        Me.Opacity = My.Settings.BackOpacity

        '进行图片识别文字
        Dim temp_ocr_num As Integer
        Dim temp_ocr_rslt As String = ""

        '进行OCR
        Select Case My.Settings.OCR_API_Choice

            Case "Tesseract"

                temp_ocr_num = API_OCR_LOCAL.Scan(IO.Directory.GetCurrentDirectory() + "/Trans.png")

                temp_ocr_rslt = API_OCR_LOCAL.GetResult()

            Case "Baidu"

                temp_ocr_num = API_OCR_BD.Scan(IO.Directory.GetCurrentDirectory() + "/Trans.png")

                temp_ocr_rslt = API_OCR_BD.GetResult()

            Case "Tencent"

                temp_ocr_num = API_OCR_TC.Scan(IO.Directory.GetCurrentDirectory() + "/Trans.png")

                temp_ocr_rslt = API_OCR_TC.GetResult()

        End Select

        If temp_ocr_num = 0 Then

            Result_String = "OCR获取失败"

            If State <> "Step" Then

                State = "Fail"

                ShowStatus()

            Else

                lbxTranslateResult.Text = Result_String
                LoseFocus()

            End If

            Exit Sub

        End If

        Dim temp_tls_num(4) As Integer
        Dim temp_tls_rslt As String = ""

        '进行翻译
        If My.Settings.TSL_Switch_BD_API = True Then

            temp_tls_num(0) = API_Translate_BD.TranslateString(temp_ocr_rslt)

            temp_tls_rslt += API_Translate_BD.GetResult() + "  百度API" + vbCrLf

        Else

            temp_tls_num(0) = 2

        End If

        If My.Settings.TSL_Switch_BD_WEB = True Then

            temp_tls_num(1) = WEB_Translate_BD.TranslateString(temp_ocr_rslt)

            temp_tls_rslt += WEB_Translate_BD.GetResult() + "  百度WEB" + vbCrLf

        Else

            temp_tls_num(1) = 2

        End If

        If My.Settings.TSL_Switch_YD_API = True Then

            temp_tls_num(2) = API_Translate_YD.TranslateString(temp_ocr_rslt)

            temp_tls_rslt += API_Translate_YD.GetResult() + "  有道API" + vbCrLf

        Else

            temp_tls_num(2) = 2

        End If

        If My.Settings.TSL_Switch_YD_WEB = True Then

            temp_tls_num(3) = WEB_Translate_YD.TranslateString(temp_ocr_rslt)

            temp_tls_rslt += WEB_Translate_YD.GetResult() + "  有道WEB" + vbCrLf

        Else

            temp_tls_num(3) = 2

        End If

        If My.Settings.TSL_Switch_TC_API = True Then

            temp_tls_num(4) = API_Translate_TC.TranslateString(temp_ocr_rslt)

            temp_tls_rslt += API_Translate_TC.GetResult() + "  腾讯API" + vbCrLf

        Else

            temp_tls_num(4) = 2

        End If

        For i As Integer = 0 To temp_tls_num.Length - 1

            If temp_tls_num(i) = 1 Then

                Result_String = temp_tls_rslt

                If State <> "Step" Then

                    State = "Success"

                    ShowStatus()

                Else

                    lbxTranslateResult.Text = Result_String
                    LoseFocus()

                End If

                Exit Sub

            End If

        Next

        For i As Integer = 0 To temp_tls_num.Length - 1

            If temp_tls_num(i) = 0 Then

                Result_String = "翻译获取失败"

                If State <> "Step" Then

                    State = "Fail"

                    ShowStatus()

                Else

                    lbxTranslateResult.Text = Result_String
                    LoseFocus()

                End If

                Exit Sub

            End If

        Next

        Result_String = "请开启翻译选项"

        If State <> "Step" Then

            State = "Success"

            ShowStatus()

        Else

            lbxTranslateResult.Text = Result_String
            LoseFocus()

        End If

    End Sub

    Dim result As Integer

    Dim pic1 As Bitmap
    Dim pic2 As Bitmap

    Private Sub picCapture(name As String)

        Dim percentage As Double = Zoomit.ScaleX

        Dim sizex As Integer

        Dim sizey As Integer

        If My.Settings.OCR_Scan_Mode = "AUTO" Then

            sizex = Convert.ToInt64(Me.Width * percentage)

            sizey = Convert.ToInt64(Me.Height * percentage)

        Else

            sizex = Convert.ToInt64((My.Settings.OCR_Detect_Down.X - My.Settings.OCR_Detect_Left.X) * percentage)

            sizey = Convert.ToInt64((My.Settings.OCR_Detect_Down.Y - My.Settings.OCR_Detect_Left.Y) * percentage)

        End If

        Dim sizeBackImage As New Size(sizex, sizey)

        Dim imgpnlLock As New Bitmap(sizex, sizey)

        Using g As Graphics = Graphics.FromImage(imgpnlLock)

            If My.Settings.OCR_Scan_Mode = "AUTO" Then

                Original.X = Location.X * percentage

                Original.Y = Location.Y * percentage

            Else

                Original.X = My.Settings.OCR_Detect_Left.X * percentage

                Original.Y = My.Settings.OCR_Detect_Left.Y * percentage

            End If

            Now.X = 0

            Now.Y = 0

            g.CopyFromScreen(Original, Now, sizeBackImage)

        End Using

        imgpnlLock.Save(IO.Directory.GetCurrentDirectory() + "/" + name + ".png")

    End Sub

    Private Sub picCompare(bitmap1 As Bitmap, bitmap2 As Bitmap)

        result = 0

        If IsNothing(bitmap1) Or IsNothing(bitmap2) Then

            result = -1

            Exit Sub

        End If

        If bitmap1.Width = bitmap2.Width And bitmap1.Height = bitmap2.Height Then

            For i As Integer = 0 To bitmap1.Width - 1

                For j As Integer = 0 To bitmap1.Height - 1

                    Dim color1 As Color = bitmap1.GetPixel(i, j)

                    Dim color2 As Color = bitmap2.GetPixel(i, j)

                    If color1 <> color2 Then

                        result = color1.ToArgb - color2.ToArgb

                        Exit Sub

                    End If

                Next

            Next

        ElseIf bitmap1.Width <> bitmap2.Width Then

            result = bitmap1.Width - bitmap2.Width

        ElseIf bitmap1.Height <> bitmap2.Height Then

            result = bitmap1.Height - bitmap2.Height

        End If

    End Sub

    Private Sub picTemp_Detect_Compare()

        '获取当前截图
        picCapture("temp")

        '对比之前的截图
        pic1 = New Bitmap(IO.Directory.GetCurrentDirectory() + "/temp.png")
        pic2 = New Bitmap(IO.Directory.GetCurrentDirectory() + "/detect.png")
        picCompare(pic1, pic2)
        pic1.Dispose()
        pic2.Dispose()

    End Sub

    Dim State As String
    Dim SameTimes As Integer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If State = "Rescan" Then

            picCapture("detect")

            State = "Scan"

            ShowStatus()

        End If

        If State = "Translating" Then

            Exit Sub

        End If

        If State = "Success" Then

            '对比截图
            picTemp_Detect_Compare()

            If result = 0 Then

                lbxTranslateResult.Text = Result_String
                LoseFocus()

                State = "Rescan"

                ShowStatus()

            Else

                State = "Scan"

                ShowStatus()

            End If

        End If

        If State = "Fail" Then

            lbxTranslateResult.Text = Result_String
            LoseFocus()

            If My.Settings.AUTO_STOP = True Then

                Application_STOP()

            Else

                State = "Scan"

                ShowStatus()

            End If

        End If

        If State = "Scan" Then

            '对比截图
            picTemp_Detect_Compare()

            '不同做处理
            If result <> 0 Then

                picCapture("detect")
                SameTimes = 1

            Else

                If SameTimes > 0 Then

                    SameTimes += 1

                End If

                If SameTimes > 3 Then

                    SameTimes = 0
                    Translate()

                End If

            End If

        End If

    End Sub

    Private Sub lblStart_Click(sender As Object, e As EventArgs) Handles lblStart.Click

        If Timer1.Enabled = True Then

            Application_STOP()

        Else

            Application_RUN()

        End If

    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click, tsmiQuit.Click

        Me.Close()

    End Sub

    Private Sub lblConfig_Click(sender As Object, e As EventArgs) Handles lblConfig.Click, tsmiConfig.Click

        If State <> "Stop" Then

            Application_STOP()

        End If

        Me.Visible = False

        NoticeForm.Visible = False

        ConfigForm.Visible = True

    End Sub

    Private Sub lblStartStep_Click(sender As Object, e As EventArgs) Handles lblStartStep.Click

        State = "Step"
        ShowStatus()
        Timer1.Enabled = False

        '按钮隐藏
        lbl_Visible_Set(False)
        LoseFocus()

        Translate()

    End Sub

    Private Sub SubFormClosed() Handles ConfigForm.FormClose

        Me.Visible = True

        NoticeForm.Visible = True

        FormStatusInit()

    End Sub

    Private Sub IntroduceFormClosed() Handles IntroduceForm.FormClose

        Me.TopMost = True

        Me.Opacity = My.Settings.BackOpacity

        NoticeForm.TopMost = True

        NoticeForm.Opacity = My.Settings.BackOpacity

        LoseFocus()

    End Sub

    Private Sub tsmiStart_Click(sender As Object, e As EventArgs) Handles tsmiStart.Click

        If Timer1.Enabled = False Then

            Application_RUN()

        End If

    End Sub

    Private Sub tsmiStop_Click(sender As Object, e As EventArgs) Handles tsmiStop.Click

        If Timer1.Enabled = True Then

            Application_STOP()

        End If

    End Sub

    Private Sub lbl_MouseEnter(sender As Object, e As EventArgs) Handles lblClose.MouseEnter, lblConfig.MouseEnter, lblStart.MouseEnter, lblDragSize.MouseEnter, lblStartStep.MouseEnter

        lbl_Color_Switch(sender， True)

    End Sub

    Private Sub lbl_MouseLeave(sender As Object, e As EventArgs) Handles lblClose.MouseLeave, lblConfig.MouseLeave, lblStart.MouseLeave, lblDragSize.MouseLeave, lblStartStep.MouseLeave

        lbl_Color_Switch(sender， False)

    End Sub

    Dim lblCloseImage As Image = My.Resources.close___
    Dim lblConfigImage As Image = My.Resources.option_
    Dim lblStartImage As Image = My.Resources.run_
    Dim lblDragSizeImage As Image = My.Resources.zoom_
    Dim lblStartStepImage As Image = My.Resources._step
    Dim lblLeftImage As Image = My.Resources.Right
    Dim lblRightImage As Image = My.Resources.Left
    Dim FormImage As Image = Nothing

    Private Sub lbl_Color_Switch(lbl As Object, swotch As Boolean)

        Dim lblList() As Object = {lblClose, lblConfig, lblStart, lblDragSize, lblStartStep}
        Dim lblNameList() As Object = {"lblClose", "lblConfig", "lblStart", "lblDragSize", "lblStartStep"}

        If State <> "Stop" Then

            For i As Integer = 0 To lblNameList.Length - 1

                If lbl Is lblList(i) Then

                    lbl_Color_Set_Single(lblNameList(i), swotch)

                End If

            Next

        End If

    End Sub

    Private Sub lbl_Visible_Set(visible_value As Boolean)

        Dim lbl_Lisr() As String = {"lblClose", "lblConfig", "lblStart", "lblDragSize", "lblStartStep", "lblLeft", "lblRight"}

        For i As Integer = 0 To lbl_Lisr.Length - 1

            lbl_Color_Set_Single(lbl_Lisr(i), visible_value)

        Next

    End Sub

    Private Sub lbl_Color_Set_Single(lbl_name As String, visible_value As Boolean)

        'FormBackColor = Me.BackColor

        Select Case lbl_name

            Case "lblClose"

                If visible_value = True Then

                    lblClose.Image = lblCloseImage

                Else

                    lblClose.Image = FormImage

                End If

            Case "lblConfig"

                If visible_value = True Then

                    lblConfig.Image = lblConfigImage

                Else

                    lblConfig.Image = FormImage

                End If

            Case "lblStart"

                If visible_value = True Then

                    lblStart.Image = lblStartImage

                Else

                    lblStart.Image = FormImage

                End If

            Case "lblDragSize"

                If visible_value = True Then

                    lblDragSize.Image = lblDragSizeImage

                Else

                    lblDragSize.Image = FormImage

                End If

            Case "lblStartStep"

                If visible_value = True Then

                    lblStartStep.Image = lblStartStepImage

                Else

                    lblStartStep.Image = FormImage

                End If

            Case "lblLeft"

                If visible_value = True Then

                    lblLeft.Image = lblLeftImage

                Else

                    lblLeft.Image = FormImage

                End If

            Case "lblRight"

                If visible_value = True Then

                    lblRight.Image = lblRightImage

                Else

                    lblRight.Image = FormImage

                End If

        End Select

    End Sub

    Private Sub loggerprintCallback(logtext As String) Handles API_OCR_LOCAL.loggerPrint, API_OCR_BD.loggerPrint, API_OCR_TC.loggerPrint, API_Translate_BD.loggerPrint, WEB_Translate_BD.loggerPrint, API_Translate_YD.loggerPrint, WEB_Translate_YD.loggerPrint, API_Translate_TC.loggerPrint

        loggerPrint.Logout(logtext)

    End Sub

    Private Sub FormStatusInit()

        Dim lblList() As Object = {lblClose, lblConfig, lblStart, lblDragSize, lblStartStep, lblLeft, lblRight}

        'OCR初始化
        Select Case My.Settings.OCR_API_Choice

            Case "Tesseract"

                API_OCR_LOCAL.APIInit(My.Settings.TesseractOCR_ThresholdNumberSet)

            Case "Baidu"

                API_OCR_BD.APIInit(My.Settings.BDOCR_API_KEY, My.Settings.BDOCR_SECRET_KEY)

            Case "Tencent"

                API_OCR_TC.APIInit(My.Settings.TCOCR_API_ID, My.Settings.TCOCR_API_KEY)

        End Select

        'TSL初始化
        If My.Settings.TSL_Switch_BD_API = True Then

            API_Translate_BD.APIInit(My.Settings.BDTSL_API_ID, My.Settings.BDTSL_API_KEY)

        End If

        If My.Settings.TSL_Switch_YD_API = True Then

            API_Translate_YD.APIInit(My.Settings.YDTSL_API_KEY, My.Settings.YDTSL_SECRET_KEY)

        End If

        If My.Settings.TSL_Switch_TC_API = True Then

            API_Translate_TC.APIInit(My.Settings.TCTSL_API_ID, My.Settings.TCTSL_API_KEY)

        End If

        Me.Opacity = My.Settings.BackOpacity

        NoticeForm.Opacity = My.Settings.BackOpacity

        Me.BackColor = My.Settings.BackCOLOR

        lbxTranslateResult.BackColor = My.Settings.BackCOLOR

        lbxTranslateResult.ForeColor = My.Settings.FontCOLOR

        lbxTranslateResult.Font = My.Settings.FontSTYLE

        For i As Integer = 0 To lblList.Length - 1

            lblList(i).BackColor = My.Settings.BackCOLOR

        Next

        NoticeForm.FormInit(Me.Location)

    End Sub

    Private Sub Application_RUN()

        State = "Scan"
        ShowStatus()
        Timer1.Enabled = True

        picCapture("detect")
        SameTimes = 1

        '按钮隐藏
        lbl_Visible_Set(False)
        LoseFocus()

    End Sub

    Private Sub Application_STOP()

        State = "Stop"
        ShowStatus()
        Timer1.Enabled = False

        '按钮显示
        lbl_Visible_Set(True)

    End Sub

    Private Sub ShowStatus()

        Dim NoticeMessage As String = ""

        Select Case State
            Case "Scan"

                NoticeMessage = "正在扫描"

            Case "Stop"

                NoticeMessage = "扫描停止"

            Case "Step"

                NoticeMessage = "单次扫描"

            Case "Translating"

                NoticeMessage = "正在翻译"

            Case "Success"

                NoticeMessage = "翻译成功"

            Case "Fail"

                NoticeMessage = "翻译失败"

        End Select

        NoticeForm.StringShow(NoticeMessage）

    End Sub

    Private Sub LoseFocus()

        tbx_Focus.Focus()

    End Sub

End Class
