Module Module1

    Sub Main()
        Dim prefecture As New SortedList()
        prefecture.Add(1, "青森")
        prefecture.Add(2, "秋田")
        prefecture.Add(3, "岩手")
        prefecture.Add(5, "宮城")
        prefecture.Add(6, "山形")
        prefecture.Add(4, "福島")

        For I As Integer = 0 To 5
            Console.WriteLine(prefecture.GetByIndex(I))
        Next

        Console.ReadLine()
    End Sub

End Module
