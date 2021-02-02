Imports Tesseract
Imports OpenCvSharp

Public Class OCR_Tesseract

    Dim ResultCode As Integer
    Dim ResultString As String

    Dim OriginLanguage As String

    Public Event loggerPrint(logtext As String)

    Public Function Scan(imgPath As String)

        Try

            Dim engine = New TesseractEngine("tessdata", OriginLanguage, EngineMode.Default)

            'Dim src = New Mat(imgPath, ImreadModes.Color)

            'Dim result = src.Threshold(29, 255, ThresholdTypes.Binary)

            'src.ImWrite(imgPath)

            'Dim src = Bitmap.FromFile(imgPath)

            'Dim rst = Threshold_Tool(src, ThresholdNumberSet)

            'src.Dispose()

            'rst.Save(imgPath)

            Dim img = Pix.LoadFromFile(imgPath)

            Dim page = engine.Process(img)

            ResultString = ""

            ResultString = page.GetText().Replace("\r", String.Empty).Replace("\n", String.Empty).Replace("\t", String.Empty)

            RaiseEvent loggerPrint("OCR_Tesseract" + vbCrLf + vbCrLf + ResultString + vbCrLf + vbCrLf)

            If ResultString <> "" Then

                ResultCode = 1

            Else

                ResultCode = 0

            End If

            Return ResultCode

        Catch ex As Exception

            RaiseEvent loggerPrint("OCR_Tesseract" + vbCrLf + vbCrLf + ex.ToString + vbCrLf + vbCrLf)

        End Try

    End Function

    Public Function Threshold_Tool(ImageOriginal As Bitmap, ThresholdNumber As Integer)

        If (ThresholdNumber <= 0) Then

            Return ImageOriginal

        End If

        Dim ImageBaseOriginal = ImageOriginal
        Dim mat1 = OpenCvSharp.Extensions.BitmapConverter.ToMat(ImageBaseOriginal)
        Dim mat2 = New Mat()
        Dim mat8 = mat1.EmptyClone()
        Cv2.CvtColor(mat1, mat2, ColorConversionCodes.BGR2GRAY, 0) '转灰度图
        Cv2.Threshold(mat2, mat2, ThresholdNumber, 255, ThresholdTypes.Binary) '二值化
        '读取轮廓
        Dim contours()() As OpenCvSharp.Point
        Dim hierarchy() As HierarchyIndex
        Cv2.FindContours(mat2, contours, hierarchy, RetrievalModes.CComp, ContourApproximationModes.ApproxSimple, Nothing)
        '得到轮廓绘制
        For i As Integer = 0 To hierarchy.Length - 1

            '大图像慢就慢在这里
            Cv2.DrawContours(mat8, contours, i, Scalar.White, 1, LineTypes.Link8, hierarchy, 0, New OpenCvSharp.Point(0, 0))

        Next

        ImageBaseOriginal = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(mat8)
        mat1.Dispose()
        mat2.Dispose()
        mat8.Dispose()
        Return ImageBaseOriginal

    End Function

    Public Sub APIInit()

        Dim Language = My.Settings.Origin_Language

        Select Case Language

            Case "Jpn"

                OriginLanguage = "jpn"

            Case "Eng"

                OriginLanguage = "eng"

        End Select

    End Sub

    Public Function GetResult()

        Return ResultString

    End Function

End Class
