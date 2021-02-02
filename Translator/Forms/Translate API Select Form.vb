Public Class Form8

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

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click

        RaiseEvent FormClose()

        Me.Visible = False

    End Sub

    Private Sub lbl_Click(sender As Object, e As EventArgs) Handles lblBaiduTLS.Click, lblBaiduTLSWEB.Click， lblYoudaoTLS.Click, lblYoudaoTLSWEB.Click， lblTencentTLS.Click

        Dim lbl_List() As Object = {lblBaiduTLS, lblBaiduTLSWEB, lblYoudaoTLS, lblYoudaoTLSWEB, lblTencentTLS}

        Dim Setting_List() As Object = {My.Settings.TSL_Switch_BD_API, My.Settings.TSL_Switch_BD_WEB, My.Settings.TSL_Switch_YD_API, My.Settings.TSL_Switch_YD_WEB, My.Settings.TSL_Switch_TC_API}

        For i As Integer = 0 To lbl_List.Length - 1

            If sender Is lbl_List(i) Then

                If Setting_List(i) = True Then

                    lbl_List(i).BackColor = Me.BackColor

                    Setting_List_Set(sender, False)

                Else

                    lbl_List(i).BackColor = Color.Gray

                    Setting_List_Set(sender, True)

                End If

            End If

        Next

    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim lbl_List() As Object = {lblBaiduTLS, lblBaiduTLSWEB, lblYoudaoTLS, lblYoudaoTLSWEB, lblTencentTLS}

        Dim Setting_List() As Object = {My.Settings.TSL_Switch_BD_API, My.Settings.TSL_Switch_BD_WEB, My.Settings.TSL_Switch_YD_API, My.Settings.TSL_Switch_YD_WEB, My.Settings.TSL_Switch_TC_API}

        For i As Integer = 0 To Setting_List.Length - 1

            If Setting_List(i) = True Then

                lbl_List(i).BackColor = Color.Gray

            Else

                lbl_List(i).BackColor = Me.BackColor

            End If

        Next

    End Sub

    Private Sub Setting_List_Set(sender As Object, bool As Boolean)

        Dim lbl_List() As Object = {lblBaiduTLS, lblBaiduTLSWEB, lblYoudaoTLS, lblYoudaoTLSWEB, lblTencentTLS}

        For i As Integer = 0 To lbl_List.Length - 1

            If sender Is lbl_List(i) Then

                Select Case i

                    Case 0

                        My.Settings.TSL_Switch_BD_API = bool

                    Case 1

                        My.Settings.TSL_Switch_BD_WEB = bool

                    Case 2

                        My.Settings.TSL_Switch_YD_API = bool

                    Case 3

                        My.Settings.TSL_Switch_YD_WEB = bool

                    Case 4

                        My.Settings.TSL_Switch_TC_API = bool

                End Select

            End If

        Next

    End Sub

    Private Sub lbl_MouseEnter(sender As Object, e As EventArgs) Handles lblBaiduTLS.MouseEnter, lblBaiduTLSWEB.MouseEnter， lblYoudaoTLS.MouseEnter, lblYoudaoTLSWEB.MouseEnter， lblTencentTLS.MouseEnter

        sender.BackColor = Color.Gray

    End Sub

    Private Sub lbl_MouseLeave(sender As Object, e As EventArgs) Handles lblBaiduTLS.MouseLeave, lblBaiduTLSWEB.MouseLeave， lblYoudaoTLS.MouseLeave, lblYoudaoTLSWEB.MouseLeave， lblTencentTLS.MouseLeave

        Dim lbl_List() As Object = {lblBaiduTLS, lblBaiduTLSWEB, lblYoudaoTLS, lblYoudaoTLSWEB, lblTencentTLS}

        For i As Integer = 0 To lbl_List.Length - 1

            If sender Is lbl_List(i) Then

                Select Case i

                    Case 0

                        lbl_Setting_Backcolor(sender, My.Settings.TSL_Switch_BD_API)

                    Case 1

                        lbl_Setting_Backcolor(sender, My.Settings.TSL_Switch_BD_WEB)

                    Case 2

                        lbl_Setting_Backcolor(sender, My.Settings.TSL_Switch_YD_API)

                    Case 3

                        lbl_Setting_Backcolor(sender, My.Settings.TSL_Switch_YD_WEB)

                    Case 4

                        lbl_Setting_Backcolor(sender, My.Settings.TSL_Switch_TC_API)

                End Select

            End If

        Next

    End Sub

    Private Sub lbl_Setting_Backcolor(sender As Object, bool As Boolean)

        If bool = True Then

            sender.BackColor = Color.Gray

        Else

            sender.BackColor = Me.BackColor

        End If

    End Sub

End Class