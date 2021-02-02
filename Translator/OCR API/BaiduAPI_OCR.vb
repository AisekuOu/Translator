Public Class BaiduAPI_OCR

    '注意 是百度智能云 文字识别
    '设置APPID/AK/SK
    Dim API_KEY As String
    Dim SECRET_KEY As String
    Dim client As Baidu.Aip.Ocr.Ocr
    Dim ResultCode As Integer
    Dim ResultString As String

    Dim OriginLanguage As String

    Public Event loggerPrint(logtext As String)

    Public Function Scan(PitturePath As String)

        Try

            Dim Image = IO.File.ReadAllBytes(PitturePath)

            Dim options = New Dictionary(Of String, Object) From {
            {"language_type", OriginLanguage},
            {"detect_direction", "true"},
            {"detect_language", "true"},
            {"probability", "false"}
        }

            ' 带参数调用通用文字识别, 图片参数为本地图片
            Dim result = client.GeneralBasic(Image, options).ToString

            Console.WriteLine(result)

            RaiseEvent loggerPrint("BaiduAPI_OCR" + vbCrLf + vbCrLf + result + vbCrLf + vbCrLf)

            '计算有多少句话
            Dim result_num As Integer
            Dim temp As String = result

            If temp.IndexOf("words_result_num") < 0 Then

                ResultCode = 0

            Else

                temp = temp.Substring(temp.IndexOf(Chr(34) + "words_result_num" + Chr(34) + ": "))
                temp = temp.Substring(20, temp.Length - 20)
                temp = temp.Substring(0, temp.IndexOf(Chr(44)))
                result_num = Int32.Parse(temp)

                temp = result

                Dim result_fin As String = ""

                If result_num > 0 Then

                    For i As Integer = 1 To result_num

                        temp = temp.Substring(temp.IndexOf(Chr(34) + "words" + Chr(34) + ": " + Chr(34)))
                        temp = temp.Substring(10, temp.Length - 10)
                        result_fin += temp.Substring(0, temp.IndexOf(Chr(34)))
                        temp = temp.Substring(temp.IndexOf(Chr(34)))

                    Next

                    ResultCode = 1

                Else

                    result_fin = ""

                    ResultCode = 0

                End If

                ResultString = result_fin

            End If

            Return ResultCode

        Catch ex As Exception

            RaiseEvent loggerPrint("BaiduAPI_OCR" + vbCrLf + vbCrLf + ex.ToString + vbCrLf + vbCrLf)

        End Try

    End Function

    Public Sub APIInit(AK As String, SK As String)

        API_KEY = AK
        SECRET_KEY = SK

        client = New Baidu.Aip.Ocr.Ocr(API_KEY, SECRET_KEY)
        client.Timeout = 60000

        Dim Language = My.Settings.Origin_Language

        Select Case Language

            Case "Jpn"

                OriginLanguage = "JAP"

            Case "Eng"

                OriginLanguage = "ENG"

        End Select

    End Sub

    Public Function GetResult()

        Return ResultString

    End Function

End Class
