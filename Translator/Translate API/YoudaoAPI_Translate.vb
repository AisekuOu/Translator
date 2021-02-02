Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Security.Cryptography

Public Class YoudaoAPI_Translate

    '注意 是有道智云 · AI开放平台 翻译
    '设置APPID/AK/SK 网易有道翻译
    Dim appKey As String
    Dim appSecret As String
    Dim ResultCode As Integer
    Dim ResultString As String = ""

    Dim OriginLanguage As String

    Public Event loggerPrint(logtext As String)

    Public Function TranslateString(TranslateSource As String)

        Dim url As String = "https://openapi.youdao.com/api"
        Dim salt As String = DateTime.Now.Millisecond.ToString()
        Dim ts As TimeSpan = (DateTime.UtcNow - New DateTime(1970, 1, 1, 0, 0, 0, 0))
        Dim curtime As String = Convert.ToInt64(ts.TotalSeconds).ToString()
        Dim signStr As String = appKey + Truncate(TranslateSource) + salt + curtime + appSecret
        Dim sign As String = ComputeHash(signStr, New SHA256CryptoServiceProvider())
        Dim dic = New Dictionary(Of String, String) From {
            {"from", OriginLanguage},
            {"to", "zh-CHS"},
            {"signType", "v3"},
            {"curtime", curtime},
            {"q", WebUtility.UrlEncode(TranslateSource)},
            {"appKey", appKey},
            {"salt", salt},
            {"sign", sign}
        }
        Return Post(url, dic)

    End Function

    Private Function Post(url As String, dic As Dictionary(Of String, String))

        Try

            Dim result As String = ""
            Dim req As HttpWebRequest = WebRequest.Create(url)
            req.Method = "POST"
            req.ContentType = "application/x-www-form-urlencoded"
            Dim builder As StringBuilder = New StringBuilder()
            Dim i As Integer = 0
            For Each item As KeyValuePair(Of String, String) In dic

                If i > 0 Then
                    builder.Append("&")
                End If
                builder.AppendFormat("{0}={1}", item.Key, item.Value)
                i += 1

            Next
            Dim data As Byte() = Encoding.UTF8.GetBytes(builder.ToString())
            req.ContentLength = data.Length
            Using reqStream As IO.Stream = req.GetRequestStream()
                reqStream.Write(data, 0, data.Length)
                reqStream.Close()
            End Using
            Dim resp As HttpWebResponse = req.GetResponse()
            Dim stream As IO.Stream = resp.GetResponseStream()
            Using reader As StreamReader = New StreamReader(stream, Encoding.UTF8)
                result = reader.ReadToEnd()
            End Using
            Console.WriteLine(result)

            RaiseEvent loggerPrint("YoudaoAPI_Translate" + vbCrLf + vbCrLf + result + vbCrLf + vbCrLf)

            If result.IndexOf(Chr(34) + "translation" + Chr(34) + ":[" + Chr(34)) >= 0 Then

                result = result.Substring(result.IndexOf(Chr(34) + "translation" + Chr(34) + ":[" + Chr(34)))
                result = result.Substring(16, result.Length - 16)
                result = result.Substring(0, result.IndexOf(Chr(34)))

                ResultCode = 1

            Else

                result = ""

                ResultCode = 0

            End If

            ResultString = result

            Return ResultCode

        Catch ex As Exception

            RaiseEvent loggerPrint("YoudaoAPI_Translate" + vbCrLf + vbCrLf + ex.ToString + vbCrLf + vbCrLf)

        End Try

    End Function

    Private Function ComputeHash(input As String, algorithm As HashAlgorithm)

        Dim inputBytes As Byte() = Encoding.UTF8.GetBytes(input)
        Dim hashedBytes As Byte() = algorithm.ComputeHash(inputBytes)
        Return BitConverter.ToString(hashedBytes).Replace("-", "")

    End Function

    Private Function Truncate(q As String)

        If IsNothing(q) Then
            Debug.Print("nothing")
            Return ""

        End If

        Dim len As Integer = q.Length

        If len <= 20 Then

            Return q

        Else

            Return (q.Substring(0, 10) + len.ToString + q.Substring(len - 10, 10))

        End If

    End Function

    Public Sub APIInit(AK As String, SK As String)

        '设置APPID/AK/SK 网易有道翻译
        appKey = AK
        appSecret = SK

        Dim Language = My.Settings.Origin_Language

        Select Case Language

            Case "Jpn"

                OriginLanguage = "ja"

            Case "Eng"

                OriginLanguage = "en"

        End Select

    End Sub

    Public Function GetResult()

        Return ResultString

    End Function

End Class
