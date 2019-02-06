Public Class Ninja

    Private _Syuriken As String

    Public Property Syuriken() As String
        Get
            Return _Syuriken
        End Get
        Set(ByVal value As String)
            _Syuriken = value
        End Set
    End Property

    Public Sub Jump()
        Console.WriteLine("ジャンプしたよ")
    End Sub

End Class
