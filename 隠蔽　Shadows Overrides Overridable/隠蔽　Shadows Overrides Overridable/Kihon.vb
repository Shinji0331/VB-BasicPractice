Public Class Kihon

    Public Sub SayHello()
        Console.WriteLine("こんにちは")
    End Sub

    Public Overridable Sub SayHello(ByVal Name As String)
        Console.WriteLine("こんにちわ{0}さん", Name)
    End Sub

End Class
