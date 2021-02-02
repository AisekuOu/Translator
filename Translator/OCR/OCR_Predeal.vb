Imports OpenCvSharp

Public Class OCR_Predeal

    Public Function PreDeal(srcPath As String， thresholdValue As Integer)

        Dim srcPicture = New Mat(srcPath, ImreadModes.Grayscale)

        srcPicture = FixPictureMode_2(srcPicture, thresholdValue)

        Dim outPicture = Extensions.BitmapConverter.ToBitmap(srcPicture)

        Return outPicture

    End Function

    Public Sub PreDealSave(srcPath As String， thresholdValue As Integer)

        Dim srcPicture = New Mat(srcPath, ImreadModes.Grayscale)

        srcPicture = FixPictureMode_2(srcPicture, thresholdValue)

        Dim outPicture = Extensions.BitmapConverter.ToBitmap(srcPicture)

        outPicture.Save(srcPath)

    End Sub

    Public Function FixPictureMode_1(srcPicture As Mat)

        Cv2.Normalize(srcPicture, srcPicture, 0, 255, NormTypes.MinMax)

        Cv2.Threshold(srcPicture, srcPicture, 0, 255, ThresholdTypes.Otsu)

        Cv2.Erode(srcPicture, srcPicture, New Mat())

        Cv2.Dilate(srcPicture, srcPicture, New Mat(), New Point(0, 0), 9)

        Return srcPicture

    End Function

    Public Function FixPictureMode_2(srcPicture As Mat, thresholdValue As Integer)

        Cv2.Threshold(srcPicture, srcPicture, thresholdValue, 255, ThresholdTypes.Binary)

        Return srcPicture

    End Function

    Public Function reverse(srcPicture As Mat)

        Dim gray As Byte

        For height As Integer = 0 To srcPicture.Height - 1

            For width As Integer = 0 To srcPicture.Width - 1

                gray = 255 - srcPicture.At(Of Byte)(height, width)

                srcPicture.Set(Of Vec3b)(height, width, New Vec3b(gray, gray, gray))

            Next

        Next

        Return srcPicture

    End Function

End Class
