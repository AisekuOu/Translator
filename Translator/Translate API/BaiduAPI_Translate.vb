Imports System.Text
Imports System.Net
Imports System.IO
Imports System.Security.Cryptography
Imports System.Globalization

Public Class BaiduAPI_Translate

    '注意 是百度翻译开放平台 翻译
    '设置APPID/ID/SK 百度图片识别
    Dim API_ID As String
    Dim SECRET_KEY As String
    Dim ResultString As String = ""

    Dim OriginLanguage As String

    Public Event loggerPrint(logtext As String)

    Public Function TranslateString(TranslateSource As String)

        Try

            ' 原文
            Dim q As String = TranslateSource
            ' 源语言
            Dim from As String = OriginLanguage
            ' 目标语言
            Dim TLS_to As String = "zh"
            ' 改成您的APP ID
            Dim appId As String = API_ID
            Dim rd As Random = New Random()
            Dim salt As String = rd.Next(100000).ToString()
            ' 改成您的密钥
            Dim secretKey As String = SECRET_KEY
            Dim sign As String = EncryptString(appId + q + salt + secretKey)
            Dim url As String = "http://api.fanyi.baidu.com/api/trans/vip/translate?"
            url += "q=" + WebUtility.UrlEncode(q)
            url += "&from=" + from
            url += "&to=" + TLS_to
            url += "&appid=" + appId
            url += "&salt=" + salt
            url += "&sign=" + sign
            Dim request As HttpWebRequest = WebRequest.Create(url)
            request.Method = "GET"
            request.ContentType = "text/html;charset=UTF-8"
            request.UserAgent = ""
            request.Timeout = 6000
            Dim response As HttpWebResponse = request.GetResponse()
            Dim myResponseStream As Stream = response.GetResponseStream()
            Dim myStreamReader As StreamReader = New StreamReader(myResponseStream, Encoding.GetEncoding("UTF-8"))
            Dim retString As String = myStreamReader.ReadToEnd()
            myStreamReader.Close()
            myResponseStream.Close()
            Console.WriteLine(retString)

            RaiseEvent loggerPrint("BaiduAPI_Translate" + vbCrLf + vbCrLf + retString + vbCrLf + vbCrLf)

            Dim temp As String = retString

            If temp.IndexOf("dst") < 0 Then

                Return 0

            End If

            temp = temp.Substring(temp.IndexOf(Chr(34) + "dst" + Chr(34) + ":" + Chr(34)))
            temp = temp.Substring(7, temp.Length - 7)
            temp = temp.Substring(0, temp.IndexOf(Chr(34)))

            ResultString = ""

            If temp.IndexOf("\u") <> 0 Then

                If temp.IndexOf("\u") < 0 Then

                    ResultString += temp

                Else

                    ResultString += temp.Substring(0, temp.IndexOf("\u"))

                    temp = temp.Substring(temp.IndexOf("\u"))

                End If

            End If

            While temp.IndexOf("\u") >= 0

                If temp.IndexOf("\u") = temp.LastIndexOf("\u") Then

                    '截取\uxxxx 或\uxxxxxxxxx
                    ResultString += ToCN(temp.Substring(0, 6))

                    If temp.Length > 6 Then

                        ResultString += temp.Substring(6)

                    End If

                    Exit While

                Else

                    '截取\uxxxx 或\uxxxxxxxxx
                    ResultString += ToCN(temp.Substring(0, 6))

                    '将其余部分接回去\uxxxx -> xxxxxxx <-
                    If temp.Substring(6).IndexOf("\u") <> 0 Then

                        ResultString += temp.Substring(6).Substring(0, temp.Substring(6).IndexOf("\u"))

                    End If

                    temp = temp.Substring(temp.Substring(6).IndexOf("\u") + 6)

                End If

            End While

            Return 1

        Catch ex As Exception

            RaiseEvent loggerPrint("BaiduAPI_Translate" + vbCrLf + vbCrLf + ex.ToString + vbCrLf + vbCrLf)

        End Try

    End Function

    Public Function ToCN(srcText As String)

        Dim Str As String = srcText.Substring(2)

        Dim bytes(2) As Byte

        bytes(1) = Byte.Parse(Integer.Parse(Str.Substring(0, 2), NumberStyles.HexNumber).ToString())

        bytes(0) = Byte.Parse(Integer.Parse(Str.Substring(2, 2), NumberStyles.HexNumber).ToString())

        Return Encoding.Unicode.GetString(bytes).Substring(0, 1)

    End Function

    Private Function EncryptString(str As String)

        Dim TLS_MD5 As MD5 = MD5.Create()
        ' 将字符串转换成字节数组
        Dim byteOld As Byte() = Encoding.UTF8.GetBytes(str)
        ' 调用加密方法
        Dim byteNew As Byte() = TLS_MD5.ComputeHash(byteOld)
        ' 将加密结果转换为字符串
        Dim sb As StringBuilder = New StringBuilder()
        For Each b As Byte In byteNew
            ' 将字节转换成16进制表示的字符串，
            sb.Append(b.ToString("x2"))
        Next
        ' 返回加密的字符串
        Return sb.ToString()

    End Function

    Public Sub APIInit(ID As String, SK As String)

        API_ID = ID
        SECRET_KEY = SK

        Dim Language = My.Settings.Origin_Language

        Select Case Language

            Case "Jpn"

                OriginLanguage = "jp"

            Case "Eng"

                OriginLanguage = "en"

        End Select

    End Sub

    Public Function GetResult()

        Return ResultString

    End Function

End Class
