Module Module1

    Sub Main()
        Dim prefecture As New ArrayList()
        prefecture.Add("青森")
        prefecture.Add("秋田")
        prefecture.Add("岩手")
        prefecture.Add("宮城")
        prefecture.Add("山形")
        prefecture.Add("福島")

        For I As Integer = 0 To 5
            Console.WriteLine(prefecture(I))
        Next

        Console.ReadLine()
    End Sub

End Module
