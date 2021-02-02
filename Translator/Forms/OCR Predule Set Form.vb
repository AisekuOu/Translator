Public Class Form10

    Public Event FormClose()

    Private Dragging As Boolean
    Private Original As Point
    Private Now As Point

    Private OCR_Predeal_FIX As OCR_Predeal = New OCR_Predeal

    Private path = IO.Directory.GetCurrentDirectory() + "/test.png"
    Private srcImage = Bitmap.FromFile(path)

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

        RaiseEvent FormClose()

        srcImage.Dispose()

        Me.Close()

    End Sub

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles Me.Load

        cbxFix.Checked = My.Settings.OCR_Predeal_Switch

        tbrFix.Value = My.Settings.OCR_Predeal_Value

        pbxOrigin.Image = srcImage

        pbxFix.Image = OCR_Predeal_FIX.PreDeal(path, tbrFix.Value)

        size_position()

    End Sub

    Private Sub size_position()

        Me.Width = pbxOrigin.Image.Width

        Me.Height = pbxOrigin.Image.Height * 2 + 88

        Me.Left = Me.Left - (Me.Width - 405) / 2

        Me.Top = Me.Top - (Me.Height - 262) / 2

    End Sub

    Private Sub tbrFix_ValueChanged(sender As Object, e As EventArgs) Handles tbrFix.ValueChanged

        pbxFix.Image = OCR_Predeal_FIX.PreDeal(path, tbrFix.Value)

        My.Settings.OCR_Predeal_Value = tbrFix.Value

    End Sub

    Private Sub cbxFix_CheckedChanged(sender As Object, e As EventArgs) Handles cbxFix.CheckedChanged

        My.Settings.OCR_Predeal_Switch = cbxFix.Checked

    End Sub

End Class