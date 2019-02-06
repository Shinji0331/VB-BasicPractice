Module Module1

    Sub Main()
        Dim Fruits As New Stack()

        Fruits.Push("バナナ")
        Fruits.Push("りんご")
        Fruits.Push("みかん")

        Do
            For Each Fruit In Fruits
                Console.WriteLine(Fruit.ToString())
            Next

            Console.WriteLine("======Pop=====")
            Fruits.Pop()
        Loop While Fruits.Count > 0

        Console.ReadLine()


    End Sub

End Module
