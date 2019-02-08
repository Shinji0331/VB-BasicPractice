Module Module1

    Sub Main()

        Dim ex1 As New List(Of String)
        ex1.Add("Test")
        Console.WriteLine(ex1(0))

        Dim ex2 As New SortedList(Of Integer, String)
        ex2.Add(1, "リンゴ")
        ex2.Add(3, "みかん")
        ex2.Add(2, "バナナ")
        For Each X As KeyValuePair(Of Integer, String) In ex2
            Console.WriteLine(X.Value)
        Next

        Dim ex3 As New Stack(Of Integer)
        ex3.Push(5)
        ex3.Push(8)
        Console.WriteLine(ex3.Pop())

        Dim ex4 As New Queue(Of String)
        ex4.Enqueue("りんご")
        ex4.Enqueue("みかん")
        ex4.Enqueue("バナナ")
        Console.WriteLine(ex4.Dequeue())

        Dim ex5 As New Dictionary(Of String, Integer)
        ex5.Add("リンゴ", 1)
        ex5.Add("みかん", 3)
        ex5.Add("バナナ", 2)
        Console.WriteLine(ex5("リンゴ"))



        Console.ReadLine()

    End Sub

End Module
