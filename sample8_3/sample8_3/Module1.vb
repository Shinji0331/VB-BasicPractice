Module Module1

    Sub Main()
        Dim Fruits As New SortedList()

        Fruits.Add(2, "りんご")
        Fruits.Add(3, "みかん")
        Fruits.Add(1, "バナナ")

        For I As Integer = 0 To Fruits.Count - 1
            Console.WriteLine(Fruits.GetByIndex(I))
        Next

        Console.ReadLine()

    End Sub

End Module
