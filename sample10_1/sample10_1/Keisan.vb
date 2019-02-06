Public Class Keisan

    Public Overloads Function Kakezan(ByVal X As Integer, ByVal Y As Integer) As Long
        Return X * Y
    End Function

    Public Overloads Function Kakezan(ByVal X As Single, ByVal Y As Single) As Double
        Return X * Y
    End Function

    Public Overloads Function Kakezan(ByVal X As Integer, ByVal Y As Integer, ByVal Z As Integer) As Long
        Return X * Y * Z
    End Function

End Class
