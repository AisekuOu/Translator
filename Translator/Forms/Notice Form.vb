Public Class Form3

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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        Me.Visible = False

        RaiseEvent FormClose()

    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles tbxIntroduce.Click

        Me.Visible = False

        RaiseEvent FormClose()

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles Me.Load

        tbxIntroduce.Text = "使用前请在设置中填写API信息，开始键重复按下就是停止，底部可以拖动窗口，将窗口拖动至覆盖待翻译文本处点击开始即可翻译(请将文字完整覆盖)，翻译是自动的，底部图片改变会触发翻译，玩的愉快。By Issac Wang（请单击任意处）"

    End Sub

    Private Sub Form3_Click(sender As Object, e As EventArgs) Handles Me.Click

        Me.Visible = False

        RaiseEvent FormClose()

    End Sub
End Class