Imports System.Text

Public Class Form7

    Dim a As YoudaoWEB_Translate = New YoudaoWEB_Translate

    Private Declare Function FindWindow Lib "user32.dll" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr

    Private Declare Function FindWindowEx Lib "user32.dll" Alias "FindWindowExA" (ByVal hWndParent As IntPtr, ByVal hWndChildAfter As IntPtr, ByVal lpszClass As String, ByVal lpszWindow As String) As IntPtr

    Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByRef lParam As Integer) As Integer

    Private NoticeForm As Form9 = New Form9

    'Private Sub webBrowser_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles webBrowser.DocumentCompleted

    '    Debug.Print("加载完毕")

    '    Dim doc = Me.webBrowser.Document

    '    Dim text = doc.GetElementById("baidu_translate_input")

    '    Dim btn = doc.GetElementById("translate-button")

    '    If IsNothing(text) = True Or IsNothing(btn) = True Then

    '        Me.webBrowser.Navigate("https://fanyi.baidu.com/?aldtype=16047#auto/zh")

    '        Exit Sub

    '    End If

    '    text.SetAttribute("value", "俺の通う初月学固からバイト先である喫茶店に向かうと")

    '    'btn.InvokeMember("click")

    'End Sub

    Private Function waitpageload()

        Dim i As Integer = 0

        Dim surl As String

        While True

            delay(50)

            If webBrowser.ReadyState = WebBrowserReadyState.Complete Then

                If Not webBrowser.IsBusy Then

                    i = i + 1

                    If i = 2 Then

                        surl = webBrowser.Url.ToString

                        If surl.Contains("res") Then

                            Return False

                        Else

                            Return True

                        End If

                    End If

                    Continue While

                End If

                i = 0

            End If

        End While

    End Function

    Private Sub delay(millis As Integer)

        Dim current = Date.Now

        While current.AddMilliseconds(millis) > Date.Now

            Application.DoEvents()

        End While

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles Me.Load

        'If waitpageload() = False Then

        '    Debug.Print("fail to load")

        'End If

        'Dim doc = Me.webBrowser.Document

        ''Dim text = doc.GetElementById("baidu_translate_input")

        'Dim btn = doc.GetElementById("imageFile")

        '''Debug.Print(webBrowser.Document.Body.OuterHtml)

        ''Dim Transline = "俺の通う初月学固からバイト先である喫茶店に向かうと"

        ''text.SetAttribute("value", Transline)

        'btn.InvokeMember("click")

        'Dim tWnd = FindWindow(vbNullString, "选择要加载的文件")

        'Debug.Print(tWnd)

        ''Dim cWnd = FindWindowEx(tWnd, &H0, "ComboBoxEx32", vbNullString)

        ''Debug.Print(cWnd)

        ''Dim ccWnd = FindWindowEx(cWnd, 0, "ComboBox", vbNullString)

        ''Debug.Print(ccWnd)

        ''Dim eWnd = FindWindowEx(ccWnd, 0, "Edit", vbNullString)

        ''InputStr(eWnd, "aaaaaaaaaa")



        'Dim cWnd = FindWindowEx(tWnd, &H0, "Button", "取消")



        ''delay(500)

        ''Dim rst = webBrowser.Document.Body.OuterHtml

        ''Dim temp = rst

        ''Dim temp_ = "<p class=" + Chr(34) + "ordinary-output source-output" + Chr(34) + " style=" + Chr(34) + "display: none;" + Chr(34) + " dir=" + Chr(34) + "ltr" + Chr(34) + ">" + Transline + "</p>   <p class=" + Chr(34) + "ordinary-output target-output clearfix" + Chr(34) + "> <span space=" + Chr(34) + "" + Chr(34) + " right-pos=" + Chr(34) + "0|75" + Chr(34) + " left-pos=" + Chr(34) + "0|75" + Chr(34) + ">"

        ''temp = temp.Substring(temp.IndexOf(temp_) + temp_.Length)

        ''temp = temp.Substring(0, temp.IndexOf("</span>"))

        ''Debug.Print(temp)

        ''a.TranslateString("俺の通う初月学固からバイト先である喫茶店に向かうと、")

        ''Debug.Print(a.GetResult())

        'waitpageload()

        'Dim doc = webBrowser.Document

        'Dim text = doc.GetElementById("baidu_translate_input")

        'Dim btn = doc.GetElementById("translate-button")

        'text.SetAttribute("value", "俺の通う初月学固からバイト先である喫茶店に向かうと")

        'btn.InvokeMember("click")

        'delay(2000)

        'Debug.Print(webBrowser.Document.Body.InnerHtml)

        'NoticeForm.StringShow(Me.Location, "aaaaaaaaaaaaaaaa")

    End Sub

    Private Sub InputStr(myIntPtr As IntPtr, Input As String)

        Dim ch() = Encoding.ASCII.GetBytes(Input)

        For i As Integer = 0 To ch.Length - 1

            SendMessage(myIntPtr, &H102, ch(i), 0)

        Next

    End Sub

End Class