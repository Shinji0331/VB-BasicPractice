Public Class Hasei
    Inherits Kihon

    Public Sub DispYesterday()
        Console.WriteLine(DateTime.Now.AddDays(-1))
    End Sub

End Class
