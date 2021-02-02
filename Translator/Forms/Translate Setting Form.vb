Public Class Form5

    Public Event FormClose()

    Private WithEvents ManualForm As Form4

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

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles Me.Load

        tbxIntroduceAuto.Text = "自动模式下，OCR扫描的区域是翻译窗体当前覆盖的区域。"
        tbxIntroduceManual.Text = "手动模式下，OCR扫描的区域是用户之前设定好的区域。"
        tbxAutoStop.Text = "出现获取失败时，在不停止的情况下，窗体会继续检测文本是否变化。"

        Select Case My.Settings.AUTO_STOP

            Case True

                lblAutoStopYes.BackColor = Color.Gray

            Case False

                lblAutoStopNo.BackColor = Color.Gray

        End Select

        Select Case My.Settings.OCR_Scan_Mode

            Case "AUTO"

                lblModeAUTO.BackColor = Color.Gray

            Case "MANUAL"

                lblModeManual.BackColor = Color.Gray

        End Select

        Select Case My.Settings.Origin_Language

            Case "Jpn"

                cbxLanguage.SelectedIndex = 0

            Case "Eng"

                cbxLanguage.SelectedIndex = 1

        End Select

    End Sub

    Private Sub lblMode_Click(sender As Object, e As EventArgs) Handles lblModeAUTO.Click, lblModeManual.Click

        Dim lblMode_Name() As Object = {"AUTO", "MANUAL"}

        Dim lblMode_List() As Object = {lblModeAUTO, lblModeManual}

        For i As Integer = 0 To lblMode_List.Length - 1

            lblMode_List(i).BackColor = Me.BackColor

        Next

        For i As Integer = 0 To lblMode_List.Length - 1

            If lblMode_List(i) Is sender Then

                Select Case lblMode_Name(i)

                    Case "AUTO"

                        My.Settings.OCR_Scan_Mode = "AUTO"

                        lblModeAUTO.BackColor = Color.Gray

                    Case "MANUAL"

                        My.Settings.OCR_Scan_Mode = "MANUAL"

                        lblModeManual.BackColor = Color.Gray

                        ManualForm = New Form4

                        ManualForm.Show()

                        Me.Visible = False

                End Select

            End If

        Next

    End Sub

    Private Sub ManualForm_Close() Handles ManualForm.FormClose

        Me.Visible = True

        ManualForm.Close()

    End Sub

    Private Sub lbl_MouseEnter(sender As Object, e As EventArgs) Handles lblModeAUTO.MouseEnter, lblModeManual.MouseEnter, lblAutoStopYes.MouseEnter, lblAutoStopNo.MouseEnter, lblMode.MouseEnter, lblStop.MouseEnter, lblLanguage.MouseEnter

        sender.BackColor = Color.Gray

    End Sub

    Private Sub lbl_MouseLeave(sender As Object, e As EventArgs) Handles lblModeAUTO.MouseLeave, lblModeManual.MouseLeave, lblAutoStopYes.MouseLeave, lblAutoStopNo.MouseLeave, lblMode.MouseLeave, lblStop.MouseLeave, lblLanguage.MouseLeave

        Dim lblMode_Name() As Object = {"AUTO", "MANUAL"}

        Dim lblMode_List() As Object = {lblModeAUTO, lblModeManual}

        Dim lblAutoStop_Name() As Object = {True, False}

        Dim lblAutoStop_List() As Object = {lblAutoStopYes, lblAutoStopNo}

        For i As Integer = 0 To lblMode_List.Length - 1

            If lblMode_List(i) Is sender Then

                If My.Settings.OCR_Scan_Mode <> lblMode_Name(i) Then

                    sender.BackColor = Me.BackColor

                End If

                Exit Sub

            End If

        Next

        For i As Integer = 0 To lblAutoStop_List.Length - 1

            If lblAutoStop_List(i) Is sender Then

                If My.Settings.AUTO_STOP <> lblAutoStop_Name(i) Then

                    sender.BackColor = Me.BackColor

                End If

                Exit Sub

            End If

        Next

        sender.BackColor = Me.BackColor

    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click

        RaiseEvent FormClose()

        Me.Visible = False

    End Sub

    Private Sub lblAutoStop_Click(sender As Object, e As EventArgs) Handles lblAutoStopYes.Click, lblAutoStopNo.Click

        Dim lblAutoStop_Name() As Object = {True, False}

        Dim lblAutoStop_List() As Object = {lblAutoStopYes, lblAutoStopNo}

        For i As Integer = 0 To lblAutoStop_List.Length - 1

            lblAutoStop_List(i).BackColor = Me.BackColor

        Next

        For i As Integer = 0 To lblAutoStop_List.Length - 1

            If lblAutoStop_List(i) Is sender Then

                Select Case lblAutoStop_Name(i)

                    Case True

                        My.Settings.AUTO_STOP = True

                        lblAutoStopYes.BackColor = Color.Gray

                    Case False

                        My.Settings.AUTO_STOP = False

                        lblAutoStopNo.BackColor = Color.Gray

                End Select

            End If

        Next

    End Sub

    Private Sub lbl_Click(sender As Object, e As EventArgs) Handles lblMode.Click, lblStop.Click, lblLanguage.Click

        Dim lbl_List() As Object = {lblMode, lblStop, lblLanguage}

        Dim pl_List() As Object = {plOCRMode, plAUTOStop, plLanguage}

        For i As Integer = 0 To pl_List.Length - 1

            pl_List(i).Visible = False

        Next

        For i As Integer = 0 To lbl_List.Length - 1

            If lbl_List(i) Is sender Then

                pl_List(i).Visible = True

            End If

        Next

    End Sub

    Private Sub cbxLanguage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxLanguage.SelectedIndexChanged

        Select Case cbxLanguage.SelectedIndex

            Case 0

                My.Settings.Origin_Language = "Jpn"

            Case 1

                My.Settings.Origin_Language = "Eng"

        End Select

    End Sub

End Class