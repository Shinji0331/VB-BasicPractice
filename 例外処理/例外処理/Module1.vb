Module Module1

    Sub Main()
        Dim X As Integer = 0
        Dim Y As Integer = 0

        Try
            Console.WriteLine("一つ目の数値を入力してください")
            X = CInt(Console.ReadLine())
            Console.WriteLine("2つ目の数値を入力してください")
            Y = CInt(Console.ReadLine())
            Console.WriteLine("{0} + {1} = {2}", X, Y, X + Y)

        Catch ex As Exception
            Console.WriteLine("エラーが発生したのでプログラムを終了します")

        Finally
            Console.WriteLine("終了")

        End Try

        Console.ReadLine()

    End Sub

End Module
