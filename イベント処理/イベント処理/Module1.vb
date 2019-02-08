Module Module1
    WithEvents EventSampleClass As New EventSample1

    Sub DataChanged() Handles EventSampleClass.OnDataChanged
        Console.WriteLine("データが変更されました")
    End Sub
    Sub Main()
        EventSampleClass.TestMethod(5)
        Console.ReadLine()
    End Sub

End Module
