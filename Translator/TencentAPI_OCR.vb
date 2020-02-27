Imports System.Text
Imports System.Net
Imports System.Security.Cryptography
Imports System.IO

Public Class TencentAPI_OCR

    '注意 是腾讯AI开发平台 图片翻译
    '设置APPID/ID/SK 
    Dim API_ID As String
    Dim API_KEY As String
    Dim ResultCode As Integer
    Dim ResultString As String = ""

    Public Event loggerPrint(logtext As String)

    Public Function Scan(PitturePath As String)

        Dim Image = PercentEncode(Convert.ToBase64String(File.ReadAllBytes(PitturePath)))

        Dim url As String = "https://api.ai.qq.com/fcgi-bin/nlp/nlp_imagetranslate"
        Dim ts As TimeSpan = (DateTime.UtcNow - New DateTime(1970, 1, 1, 0, 0, 0, 0))
        Dim time_stamp As String = Convert.ToInt64(ts.TotalSeconds).ToString()
        Dim nonce_str As String = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 32)
        Dim dic = New Dictionary(Of String, String) From {
            {"app_id", API_ID},
            {"image", Image},
            {"nonce_str", nonce_str},
            {"scene", "doc"},
            {"session_id", "2333333333"},
            {"source", "jp"},
            {"target", "zh"},
            {"time_stamp", time_stamp}
        }
        Dim dic_ = New Dictionary(Of String, String) From {
            {"app_id", API_ID},
            {"image", Image},
            {"session_id", "2333333333"},
            {"scene", "doc"},
            {"source", "jp"},
            {"target", "zh"},
            {"time_stamp", time_stamp},
            {"nonce_str", nonce_str},
            {"sign", getReqSign(dic, API_KEY)}
        }
        Return Post(url, dic_)

    End Function

    Private Function getReqSign(params As Dictionary(Of String, String), appkey As String)

        Dim str As String = ""

        For Each item As KeyValuePair(Of String, String) In params

            If item.Value <> "" Then

                If item.Key = "image" Then

                    str += item.Key + "=" + item.Value + "&"

                Else

                    str += item.Key + "=" + PercentEncode(item.Value) + "&"

                End If

            End If

        Next

        str += "app_key=" + appkey

        Return MD5Encry(str).ToUpper

    End Function

    Public Function MD5Encry(value As String)

        Dim TLS_MD5 As MD5 = MD5.Create()
        ' 将字符串转换成字节数组
        Dim byteOld As Byte() = Encoding.UTF8.GetBytes(value)
        ' 调用加密方法
        Dim byteNew As Byte() = TLS_MD5.ComputeHash(byteOld)

        Dim sTemp = ""

        For i As Integer = 0 To byteNew.Length - 1

            sTemp += byteNew(i).ToString("X").PadLeft(2, Chr(48))

        Next

        Return sTemp.ToLower

    End Function

    Public Function PercentEncode(value As String)

        Dim AstringBuilder = New StringBuilder()

        Dim text = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_.~"

        Dim bytes() = Encoding.GetEncoding("UTF-8").GetBytes(value)

        Dim value_ = value.ToCharArray

        For Each c As Byte In bytes

            If text.IndexOf(Chr(c)) >= 0 Then

                AstringBuilder.Append(Chr(c))

            Else

                If Chr(c) = Chr(32) Then

                    AstringBuilder.Append(Chr(43))

                Else

                    AstringBuilder.Append("%").Append(String.Format("{0:X2}", c))

                End If

            End If

        Next

        Return AstringBuilder.ToString()

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

            RaiseEvent loggerPrint("TencentAPI_OCR" + vbCrLf + vbCrLf + result + vbCrLf + vbCrLf)

            Dim temp As String = result
            Dim temp_ As String

            ResultString = ""

            If temp.IndexOf("source_text") < 0 Then

                ResultCode = 0

            Else

                While temp.IndexOf("source_text") >= 0

                    temp = temp.Substring(temp.IndexOf("source_text")).Substring(15)

                    temp_ = temp.Substring(0, temp.IndexOf(Chr(34)))

                    ResultString += temp_

                    temp = temp.Substring(temp.IndexOf(temp_)).Substring(temp_.Length)

                End While

                ResultCode = 1

            End If

            Return ResultCode

        Catch ex As Exception

            RaiseEvent loggerPrint("TencentAPI_OCR" + vbCrLf + vbCrLf + ex.ToString + vbCrLf + vbCrLf)

        End Try

    End Function

    Public Sub APIInit(AK As String, SK As String)

        '设置APPID/AK/SK 网易有道翻译
        API_ID = AK
        API_KEY = SK

    End Sub

    Public Function GetResult()

        Return ResultString

    End Function

End Class
