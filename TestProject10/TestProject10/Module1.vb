Module Module1

    Sub Main()

    End Sub

    Structure Keisan
        Private HDD As Integer

        Public Function Tashizan(ByVal X As Integer, ByVal Y As Integer) As Integer
            Return X + Y
        End Function

        Public Function Tashizan(ByVal X As Single, ByVal Y As Single) As Single
            Return X + Y
        End Function

        Public Function Tashizan(ByVal X As Integer, ByVal Y As Integer, ByVal Z As Integer)
            Return X + Y + Z
        End Function
    End Structure

End Module
