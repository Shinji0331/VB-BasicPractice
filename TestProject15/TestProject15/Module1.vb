Module Module1

    Sub Main()
        Dim fruits = New String() {"APPLE", "BANANA", "LEMON", "ORANGE"}
        Dim fruits5 = (From X In fruits Where X.Length > 5).ToList

        For Each result In fruits5
            Console.WriteLine(result)
        Next

        Dim numbers As Integer() = {6, 9, 8, 7, 5}
        Dim result1 = Aggregate num In numbers Into Average
        Dim result2 = Aggregate num In numbers Into Count
        Dim result3 = Aggregate num In numbers Into Min
        Dim result4 = Aggregate num In numbers Into Max
        Dim result5 = Aggregate num In numbers Into Sum

        Console.WriteLine(result1)
        Console.WriteLine(result2)
        Console.WriteLine(result3)
        Console.WriteLine(result4)
        Console.WriteLine(result5)

        Console.ReadLine()

    End Sub

End Module
