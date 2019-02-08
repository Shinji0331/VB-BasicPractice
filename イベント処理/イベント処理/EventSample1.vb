Public Class EventSample1

    Public Event OnDataChanged()

    Public Sub TestMethod(ByRef X As Integer)
        X = X + 3
        Console.WriteLine(X)
        RaiseEvent OnDataChanged()
    End Sub

End Class
