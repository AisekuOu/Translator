Public Class Form6

    Public Event FormClose()

    Private API_OCR_LOCAL As OCR_Tesseract = New OCR_Tesseract

    Private Zoomit As XYDES = New XYDES

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

            Now = PointToScreen(New Point(e.X, e.Y))

            Now.Offset(Original.X * -1, Original.Y * -1)

            Location = Now

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

            Me.Width += e.X - Original.X

            Me.Height += e.Y - Original.Y

        End If

    End Sub

    Private Sub Form4_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick, tbxIntroduce.DoubleClick

        'My.Settings.OCR_Detect_Left = Location

        'Dim newpoint = New Point(Location.X + Me.Width, Location.Y + Me.Height)

        'My.Settings.OCR_Detect_Down = newpoint

        My.Settings.TesseractOCR_ThresholdNumberSet = trkbxCheck.Value

        RaiseEvent FormClose()

        Me.Visible = False

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles Me.Load

        tbxIntroduce.Text = "设置Tesseract OCR识别参数 " + vbCrLf + "请将窗口拖动至待翻译文本上方并拉伸窗体使其完全覆盖文本，通过滑动滑杆点击查看按钮检测文本，重复此步骤至文本基本正确后双击窗口。"

        trkbxCheck.Value = My.Settings.TesseractOCR_ThresholdNumberSet

    End Sub

    Private Sub lblCheck_Click(sender As Object, e As EventArgs) Handles lblCheck.Click

        Me.Opacity = 0
        picCapture("Trans")
        Me.Opacity = 0.85

        API_OCR_LOCAL.Scan(IO.Directory.GetCurrentDirectory() + "/Trans.png")

        tbxIntroduce.Text = API_OCR_LOCAL.GetResult()

    End Sub

    Private Sub picCapture(name As String)

        Dim percentage As Double = Zoomit.ScaleX

        Dim sizex As Integer

        Dim sizey As Integer

        sizex = Convert.ToInt64(Me.Width * percentage)

        sizey = Convert.ToInt64(Me.Height * percentage)

        Dim sizeBackImage As New Size(sizex, sizey)

        Dim imgpnlLock As New Bitmap(sizex, sizey)

        Using g As Graphics = Graphics.FromImage(imgpnlLock)

            Original.X = Location.X * percentage

            Original.Y = Location.Y * percentage

            Now.X = 0

            Now.Y = 0

            g.CopyFromScreen(Original, Now, sizeBackImage)

        End Using

        imgpnlLock.Save(IO.Directory.GetCurrentDirectory() + "/" + name + ".png")

    End Sub

    Private Sub trkbxCheck_ValueChanged(sender As Object, e As EventArgs) Handles trkbxCheck.ValueChanged

        API_OCR_LOCAL.APIInit(trkbxCheck.Value)

    End Sub

End Class