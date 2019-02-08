Module Module1
    WithEvents EventSampleClass As New EventSample

    Sub TimeOver() Handles EventSampleClass.OnTimeOver
        Console.WriteLine("3秒経過しました")
    End Sub

    Sub Main()
        EventSampleClass.TestMethod()
        Console.ReadLine()

    End Sub

End Module
