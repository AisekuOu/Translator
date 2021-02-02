Public Class XYDES


    Declare Function GetDC Lib "user32" Alias "GetDC" (ByVal hwnd As IntPtr) As IntPtr

    Declare Function GetDeviceCaps Lib "gdi32" Alias "GetDeviceCaps" (ByVal hdc As IntPtr, ByVal nIndex As Integer) As Integer

    Declare Function ReleaseDC Lib "user32" Alias "ReleaseDC" (ByVal hwnd As IntPtr, ByVal hdc As IntPtr) As IntPtr

    Dim HORZRES As Integer = 8
    Dim VERTRES As Integer = 10
    Dim LOGPIXELSX As Integer = 88
    Dim LOGPIXELSY As Integer = 90
    Dim DESKTOPVERTRES As Integer = 117
    Dim DESKTOPHORZRES As Integer = 118

    Public Function ScaleX()

        Dim hdc = GetDC(IntPtr.Zero)
        Dim t = GetDeviceCaps(hdc, DESKTOPHORZRES)
        Dim d = GetDeviceCaps(hdc, HORZRES)
        Dim ScaleX_ = GetDeviceCaps(hdc, DESKTOPHORZRES) / GetDeviceCaps(hdc, HORZRES)
        ReleaseDC(IntPtr.Zero, hdc)

        Return Double.Parse(ScaleX_.ToString("#.00"))

    End Function

End Class
