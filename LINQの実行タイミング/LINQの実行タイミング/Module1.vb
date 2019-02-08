Module Module1

    Sub Main()
        Dim numbers As New List(Of Integer)
        numbers.Add(5)
        numbers.Add(3)
        numbers.Add(6)

        '通常の場合、遅延実行される
        'Dim data = From No In numbers Select No

        '即時実行なら、後の追加は認めない
        Dim data = (From No In numbers Select No).ToList()

        numbers.Add(-1)

        For Each num In data
            Console.WriteLine(num)
        Next

        Console.ReadLine()

    End Sub

End Module
