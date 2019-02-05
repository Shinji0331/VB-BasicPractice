Module Module1

    Sub Main()
        Dim Fruits(2) As String
        Console.WriteLine("好きな果物を３つ入力してください")

        For I As Integer = 0 To 2
            Fruits(I) = Console.ReadLine()
        Next

        Console.WriteLine("好きな果物をあと２つ入力してください")
        ReDim Preserve Fruits(4)

        For I As Integer = 0 To 1
            Fruits(I + 3) = Console.ReadLine()
        Next

        For I As Integer = 0 To 4
            Console.WriteLine(Fruits(I))
        Next

        Console.ReadLine()

    End Sub

End Module
