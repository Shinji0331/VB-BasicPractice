Module Module1

    Sub Main()
        Dim Cup As New Stack()
        Cup.Push(3)
        Cup.Push(2)
        Cup.Push(1)

        Do
            Console.WriteLine(Cup.Pop())
        Loop Until Cup.Count = 0

        Console.ReadLine()

    End Sub

End Module
