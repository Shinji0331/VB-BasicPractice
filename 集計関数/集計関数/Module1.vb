Module Module1

    Sub Main()
        Dim numbers As Integer() = {4, 1, 3, 5, 2}

        Dim result1 = Aggregate num In numbers Into Average
        Dim result2 = Aggregate num In numbers Into Count
        Dim result3 = Aggregate num In numbers Into Min
        Dim result4 = Aggregate num In numbers Into Max
        Dim result5 = Aggregate num In numbers Into Sum

        Console.WriteLine("平均値は{0}", result1)
        Console.WriteLine("データ数は{0}", result2)
        Console.WriteLine("最小値は{0}", result3)
        Console.WriteLine("最大値は{0}", result4)
        Console.WriteLine("総和は{0}", result5)

        Console.ReadLine()
    End Sub

End Module
