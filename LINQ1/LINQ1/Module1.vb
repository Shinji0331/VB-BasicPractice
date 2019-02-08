Module Module1

    Sub Main()

        Dim numbers As Integer() = {5, 3, 6, 8, 4, 9, 2, 1, 7, 0}
        Dim data1 = From No In numbers
        For Each num In data1
            Console.WriteLine(num)
        Next
        Console.WriteLine("******************************")

        Dim data2 = From No In numbers Where No > 5
        For Each num In data2
            Console.WriteLine(num)
        Next
        Console.WriteLine("******************************")

        Dim data3 = From No In numbers Where No > 5 Select "***" & No & "***"
        For Each num In data3
            Console.WriteLine(num)
        Next
        Console.WriteLine("******************************")

        Dim fruits = New String() {"イチゴ", "パイナップル", "オレンジ"}
        Dim results = From name In fruits Select name, name.Length
        For Each fruit In results
            Console.WriteLine("{0},{1}", fruit.name, fruit.Length)
        Next
        Console.WriteLine("******************************")

        Dim data4 = From num In numbers Order By num Ascending
        For Each No In data4
            Console.WriteLine(No)
        Next
        Console.WriteLine("******************************")

        Console.ReadLine()

    End Sub

End Module
