Public Class Form4

    Public Event FormClose()

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

        My.Settings.OCR_Detect_Left = Location

        Dim newpoint = New Point(Location.X + Me.Width, Location.Y + Me.Height)

        My.Settings.OCR_Detect_Down = newpoint

        RaiseEvent FormClose()

        Me.Visible = False

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles Me.Load

        tbxIntroduce.Text = "请将窗口拖动至待翻译文本上方并拉伸窗体使其完全覆盖文本，完成此操作后请双击本窗体"

    End Sub

End Class