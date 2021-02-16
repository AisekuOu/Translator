Public Class Form1

#Region "Private Param"

    Private WithEvents API_OCR_LOCAL As OCR_Tesseract
    Private WithEvents API_OCR_BD As BaiduAPI_OCR
    Private WithEvents API_OCR_TC As TencentAPI_OCR
    Private WithEvents API_Translate_BD As BaiduAPI_Translate
    Private WithEvents WEB_Translate_BD As BaiduWEB_Translate
    Private WithEvents API_Translate_YD As YoudaoAPI_Translate
    Private WithEvents WEB_Translate_YD As YoudaoWEB_Translate
    Private WithEvents API_Translate_TC As TencentAPI_Translate

    Private OCR_Predeal_FIX As OCR_Predeal

    Private NoticeForm As Form9
    Private WithEvents ConfigForm As Form2
    Private WithEvents IntroduceForm As Form3
    Private WithEvents PictureFixForm As Form10

    Private Zoomit As XYDES

    Private loggerPrint As Logger

#End Region

#Region "Dragging window"

    Private Dragging As Boolean
    Private Original As Point
    Private Now As Point

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

#End Region

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Init API
        API_OCR_LOCAL = New OCR_Tesseract
        API_OCR_BD = New BaiduAPI_OCR
        API_OCR_TC = New TencentAPI_OCR
        API_Translate_BD = New BaiduAPI_Translate
        WEB_Translate_BD = New BaiduWEB_Translate
        API_Translate_YD = New YoudaoAPI_Translate
        WEB_Translate_YD = New YoudaoWEB_Translate
        API_Translate_TC = New TencentAPI_Translate

        OCR_Predeal_FIX = New OCR_Predeal

        'Init SubForm
        NoticeForm = New Form9
        ConfigForm = New Form2
        IntroduceForm = New Form3

        'Init Zoomit
        Zoomit = New XYDES

        'Init Logger
        loggerPrint = New Logger

        FormStatusInit()

        CapturePicture("temp")

        CapturePicture("detect")

        IntroduceForm.Visible = True

        State = "Stop"

    End Sub

#Region "Translate function"

    Dim Result_String As String

    Private Sub Translate()

        Debug.Print("Detect Different Picture")

        SetStatus("Translating")

        'If it is not textractor, need to capture picture
        If My.Settings.OCR_API_Choice <> "Textractor" Then

            '截取要翻译的截图
            Me.Opacity = 0

            CapturePicture("Trans")

            Me.Opacity = My.Settings.BackOpacity

            '图片预处理
            If My.Settings.OCR_Predeal_Switch = True Then

                OCR_Predeal_FIX.PreDealSave(IO.Directory.GetCurrentDirectory() + "/Trans.png", My.Settings.OCR_Predeal_Value)

            End If

        End If

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

            Case "Textractor"

                temp_ocr_num = 1

                temp_ocr_rslt = Clipboard.GetText()

        End Select

        If temp_ocr_num = 0 Then

            Result_String = "OCR获取失败"

            SetStatus("Fail")

            Exit Sub

        End If

        Dim temp_tls_num(4) As Integer
        Dim temp_tls_rslt As String = ""

        '进行翻译
        If My.Settings.TSL_Switch_BD_API = True Then

            temp_tls_num(0) = API_Translate_BD.TranslateString(temp_ocr_rslt)

            temp_tls_rslt += API_Translate_BD.GetResult() + vbCrLf

        Else

            temp_tls_num(0) = 2

        End If

        If My.Settings.TSL_Switch_BD_WEB = True Then

            temp_tls_num(1) = WEB_Translate_BD.TranslateString(temp_ocr_rslt)

            temp_tls_rslt += WEB_Translate_BD.GetResult() + vbCrLf

        Else

            temp_tls_num(1) = 2

        End If

        If My.Settings.TSL_Switch_YD_API = True Then

            temp_tls_num(2) = API_Translate_YD.TranslateString(temp_ocr_rslt)

            temp_tls_rslt += API_Translate_YD.GetResult() + vbCrLf

        Else

            temp_tls_num(2) = 2

        End If

        If My.Settings.TSL_Switch_YD_WEB = True Then

            temp_tls_num(3) = WEB_Translate_YD.TranslateString(temp_ocr_rslt)

            temp_tls_rslt += WEB_Translate_YD.GetResult() + vbCrLf

        Else

            temp_tls_num(3) = 2

        End If

        If My.Settings.TSL_Switch_TC_API = True Then

            temp_tls_num(4) = API_Translate_TC.TranslateString(temp_ocr_rslt)

            temp_tls_rslt += API_Translate_TC.GetResult() + vbCrLf

        Else

            temp_tls_num(4) = 2

        End If

        'Process Result
        Result_String = "请开启翻译选项"

        For i As Integer = 0 To temp_tls_num.Length - 1

            Select Case temp_tls_num(i)

                Case 0

                    Result_String = "翻译获取失败"

                Case 1

                    Result_String = temp_tls_rslt

                    Exit For

            End Select

        Next

        If Result_String = "翻译获取失败" Then

            SetStatus("Fail")

        Else

            SetStatus("Success")

        End If

    End Sub

#End Region

#Region "Picture compare"

    Dim picCompareResult As Integer

    Dim pic1 As Bitmap
    Dim pic2 As Bitmap

    Private Sub CapturePicture(name As String)

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

        picCompareResult = 0

        If IsNothing(bitmap1) Or IsNothing(bitmap2) Then

            picCompareResult = -1

            Exit Sub

        End If

        If bitmap1.Width = bitmap2.Width And bitmap1.Height = bitmap2.Height Then

            For i As Integer = 0 To bitmap1.Width - 1

                For j As Integer = 0 To bitmap1.Height - 1

                    Dim color1 As Color = bitmap1.GetPixel(i, j)

                    Dim color2 As Color = bitmap2.GetPixel(i, j)

                    If color1 <> color2 Then

                        picCompareResult = color1.ToArgb - color2.ToArgb

                        Exit Sub

                    End If

                Next

            Next

        ElseIf bitmap1.Width <> bitmap2.Width Then

            picCompareResult = bitmap1.Width - bitmap2.Width

        ElseIf bitmap1.Height <> bitmap2.Height Then

            picCompareResult = bitmap1.Height - bitmap2.Height

        End If

    End Sub

    Private Sub picTemp_Detect_Compare()

        '获取当前截图
        CapturePicture("temp")

        '对比之前的截图
        pic1 = New Bitmap(IO.Directory.GetCurrentDirectory() + "/temp.png")
        pic2 = New Bitmap(IO.Directory.GetCurrentDirectory() + "/detect.png")
        picCompare(pic1, pic2)
        pic1.Dispose()
        pic2.Dispose()

    End Sub

#End Region

#Region "State check"

    Dim State As String
    Dim SameTimes As Integer
    Dim ClipboardString As String

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Select Case My.Settings.OCR_API_Choice

            Case "Tesseract", "Baidu", "Tencent"

                Select Case State

                    Case "Scan"

                        '对比截图
                        picTemp_Detect_Compare()

                        '不同做处理
                        If picCompareResult <> 0 Then

                            CapturePicture("detect")

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

                    Case "Success"

                        '对比截图
                        picTemp_Detect_Compare()

                        If picCompareResult = 0 Then

                            UpdateTranslateResult()

                            SetStatus("Rescan")

                        Else

                            SetStatus("Scan")

                        End If

                    Case "Fail"

                        UpdateTranslateResult()

                        If My.Settings.AUTO_STOP = True Then

                            Application_STOP()

                        Else

                            SetStatus("Scan")

                        End If

                    Case "Rescan"

                        CapturePicture("detect")

                        SetStatus("Scan")

                End Select

            Case "Textractor"

                Select Case State

                    Case "Scan"

                        If ClipboardString <> Clipboard.GetText() Then

                            ClipboardString = Clipboard.GetText()

                            Translate()

                        End If

                    Case "Success"

                        If ClipboardString = Clipboard.GetText() Then

                            UpdateTranslateResult()

                        End If

                        SetStatus("Scan")

                    Case "Fail"

                        UpdateTranslateResult()

                        If My.Settings.AUTO_STOP = True Then

                            Application_STOP()

                        Else

                            ClipboardString = ""

                            SetStatus("Scan")

                        End If

                End Select

        End Select

    End Sub

#End Region

#Region "Button click handler"

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

        SetStatus("Step")

        '按钮隐藏
        SetButtonVisible(False)

        Translate()

    End Sub

    Private Sub lblFix_Click(sender As Object, e As EventArgs) Handles lblFix.Click

        If State <> "Stop" Then

            Application_STOP()

        End If

        Me.Opacity = 0
        CapturePicture("test")
        Me.Opacity = My.Settings.BackOpacity

        Me.Visible = False

        NoticeForm.Visible = False

        PictureFixForm = New Form10

        PictureFixForm.Show()

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

#End Region

#Region "SubForm closed handler"

    Private Sub SubFormClosed() Handles ConfigForm.FormClose, PictureFixForm.FormClose

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

#End Region

#Region "Button visible function"

    Private Sub lbl_MouseEnter(sender As Object, e As EventArgs) Handles lblClose.MouseEnter, lblConfig.MouseEnter, lblStart.MouseEnter, lblDragSize.MouseEnter, lblStartStep.MouseEnter, lblFix.MouseEnter

        lbl_Color_Switch(sender， True)

    End Sub

    Private Sub lbl_MouseLeave(sender As Object, e As EventArgs) Handles lblClose.MouseLeave, lblConfig.MouseLeave, lblStart.MouseLeave, lblDragSize.MouseLeave, lblStartStep.MouseLeave, lblFix.MouseLeave

        lbl_Color_Switch(sender， False)

    End Sub

    Dim lblCloseImage As Image = My.Resources.close___
    Dim lblConfigImage As Image = My.Resources.option_
    Dim lblStartImage As Image = My.Resources.run_
    Dim lblDragSizeImage As Image = My.Resources.zoom_
    Dim lblStartStepImage As Image = My.Resources._step
    Dim lblLeftImage As Image = My.Resources.Right
    Dim lblRightImage As Image = My.Resources.Left
    Dim lblFixImage As Image = My.Resources.flow
    Dim FormImage As Image = Nothing

    Private Sub lbl_Color_Switch(lbl As Object, swotch As Boolean)

        Dim lblList() As Object = {lblClose, lblConfig, lblStart, lblDragSize, lblStartStep, lblFix}
        Dim lblNameList() As Object = {"lblClose", "lblConfig", "lblStart", "lblDragSize", "lblStartStep", "lblFix"}

        If State <> "Stop" Then

            For i As Integer = 0 To lblNameList.Length - 1

                If lbl Is lblList(i) Then

                    lbl_Color_Set_Single(lblNameList(i), swotch)

                End If

            Next

        End If

    End Sub

    Private Sub SetButtonVisible(visible_value As Boolean)

        Dim lbl_Lisr() As String = {"lblClose", "lblConfig", "lblStart", "lblDragSize", "lblStartStep", "lblFix", "lblLeft", "lblRight"}

        For i As Integer = 0 To lbl_Lisr.Length - 1

            lbl_Color_Set_Single(lbl_Lisr(i), visible_value)

        Next

        If visible_value = False Then

            LoseFocus()

        End If

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

            Case "lblFix"

                If visible_value = True Then

                    lblFix.Image = lblFixImage

                Else

                    lblFix.Image = FormImage

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

#End Region

#Region "Other function"

    Private Sub loggerprintCallback(logtext As String) Handles API_OCR_LOCAL.loggerPrint, API_OCR_BD.loggerPrint, API_OCR_TC.loggerPrint, API_Translate_BD.loggerPrint, WEB_Translate_BD.loggerPrint, API_Translate_YD.loggerPrint, WEB_Translate_YD.loggerPrint, API_Translate_TC.loggerPrint

        loggerPrint.Logout(logtext)

    End Sub

    Private Sub FormStatusInit()

        Dim lblList() As Object = {lblClose, lblConfig, lblStart, lblDragSize, lblStartStep, lblLeft, lblRight}

        'OCR初始化
        Select Case My.Settings.OCR_API_Choice

            Case "Tesseract"

                API_OCR_LOCAL.APIInit()

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

        SetStatus("Scan")

        '按钮隐藏
        SetButtonVisible(False)

        If My.Settings.OCR_API_Choice <> "Textractor" Then

            CapturePicture("detect")

            SameTimes = 1

        Else

            ClipboardString = ""

        End If

    End Sub

    Private Sub Application_STOP()

        SetStatus("Stop")

        '按钮显示
        SetButtonVisible(True)

    End Sub

    Private Sub UpdateTranslateResult()

        lbxTranslateResult.Text = Result_String

        LoseFocus()

    End Sub

    Private Sub SetStatus(status As String)

        Select Case status

            Case "Scan"

                Timer1.Enabled = True

            Case "Stop", "Step"

                Timer1.Enabled = False

            Case "Fail", "Success", "Translating"

                If State = "Step" Then

                    If status <> "Translating" Then

                        UpdateTranslateResult()

                    End If

                    Exit Sub

                End If

        End Select

        State = status

        ShowStatus()

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

#End Region

End Class
