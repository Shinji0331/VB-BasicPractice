Module Module1

    Sub Main()
        Dim Fruits(2) As String
        Console.WriteLine("あなたの好きなフルーツを３つ入力してください")

        'console.writeline("一つ目を入力してください")
        'fruits(0) = console.readline()
        'console.writeline("二つ目を入力してください")
        'fruits(1) = console.readline()
        'console.writeline("三つ目を入力してください")
        'fruits(2) = console.readline()
        For I As Integer = 0 To 2
            Console.WriteLine("{0}つ目を入力してください", I + 1)
            Fruits(I) = Console.ReadLine()
        Next

        For I As Integer = 0 To 2
            Console.WriteLine(Fruits(I))
        Next

        'Console.WriteLine(Fruits(0))
        'Console.WriteLine(Fruits(1))
        'Console.WriteLine(Fruits(2))

        Console.ReadLine()

    End Sub

End Module
