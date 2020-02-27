Public Class Form9

    Public Sub StringShow(s As String)

        '设置字体
        Label1.Text = s

        Me.Width = Label1.Width + 6

        Me.Height = Label1.Height + 6

    End Sub

    Public Sub FormInit(p As Point)

        Me.Show()

        FormPosition(p)

    End Sub

    Public Sub FormPosition(p As Point)

        Dim FormLocation As Point

        '设置字体
        Label1.Text = "Translator"

        Me.Width = Label1.Width + 6

        Me.Height = Label1.Height + 6

        '设置窗口位置
        FormLocation = New Point(p.X, p.Y - Me.Height - 4)

        Me.Location = FormLocation

    End Sub

End Class