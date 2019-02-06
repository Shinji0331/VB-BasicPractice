Public Class Keisan
    Private HDD As Integer

    Public Sub New()
        HDD = 0
    End Sub

    Public Function Tashizan(ByVal X As Integer, ByVal Y As Integer) As Integer
        Return X + Y
    End Function

    Public Function Tashizan(ByVal X As Single, ByVal Y As Single) As Single
        Return X + Y
    End Function

    Public Function Tashizan(ByVal X As Integer, ByVal Y As Integer, ByVal Z As Integer)
        Return X + Y + Z
    End Function

End Class
