Module Module1

    Sub DataChanged1()
        Console.WriteLine("データが変更されました")
    End Sub

    Sub DataChanged2()
        Console.WriteLine("Data was changed.")
    End Sub

    Sub Main()
        Dim sample1 As New EventSample

        AddHandler sample1.OnDataChanged, AddressOf DataChanged1
        sample1.TestMethod(3)

        RemoveHandler sample1.OnDataChanged, AddressOf DataChanged1

        AddHandler sample1.OnDataChanged, AddressOf DataChanged2

        sample1.TestMethod(2)

        Console.ReadLine()
    End Sub

End Module
