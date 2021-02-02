﻿Public Class YoudaoWEB_Translate

    Dim ResultString As String = ""

    Private webBrowser As WebBrowser

    Public Event loggerPrint(logtext As String)

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

    Public Function TranslateString(TranslateSource As String)

        Try

            ResultString = ""

            webBrowser = New WebBrowser()

            webBrowser.ScriptErrorsSuppressed = True

            webBrowser.Navigate("http://fanyi.youdao.com/")

            If waitpageload() = False Then

                Return 0

            End If

            Dim doc = webBrowser.Document

            Dim text = doc.GetElementById("inputOriginal")

            Dim btn = doc.GetElementById("transMachine")

            text.SetAttribute("value", TranslateSource)

            btn.InvokeMember("click")

            delay(1000)

            Dim rst = webBrowser.Document.Body.InnerHtml

            webBrowser.Dispose()

            RaiseEvent loggerPrint("YoudaoWEB_Translate" + vbCrLf + vbCrLf + rst + vbCrLf + vbCrLf)

            Dim temp = rst

            If temp.IndexOf("transTarget") < 0 Then

                Return 0

            End If

            temp = temp.Substring(temp.IndexOf("transTarget"))

            'If temp.IndexOf("transTarget") < 0 Then

            '    Return 0

            'End If

            'temp = temp.Substring(temp.IndexOf("transTarget"))

            For i As Integer = 1 To 2

                temp = temp.Substring(temp.IndexOf("<"))

                temp = temp.Substring(temp.IndexOf(">"))

            Next

            temp = temp.Substring(1, temp.IndexOf("</span>") - 1)

            If temp.IndexOf("</textarea>") >= 0 Then

                Return 0

            End If

            ResultString = temp

            Return 1

        Catch ex As Exception

            RaiseEvent loggerPrint("YoudaoWEB_Translate" + vbCrLf + vbCrLf + ex.ToString + vbCrLf + vbCrLf)

        End Try

    End Function

    Public Function GetResult()

        Return ResultString

    End Function

End Class
