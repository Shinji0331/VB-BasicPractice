Public Class EventSample

    Public Event OnTimeOver()

    Public Sub TestMethod()
        System.Threading.Thread.Sleep(3000)
        RaiseEvent OnTimeOver()

    End Sub

End Class
