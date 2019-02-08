Module Module1

    Sub Main()
        Dim X As Integer = 0
        Dim Y As Integer = 0

        Try
            Console.WriteLine("一つ目の数値を入力してください")
            X = Console.ReadLine()
            Console.WriteLine("二つ目の数値を入力してください")
            Y = Console.ReadLine()
            Console.WriteLine("{0} \ {1} = {2}", X, Y, X \ Y)

        Catch ex1 As DivideByZeroException
            Console.WriteLine("エラーが発生しました：{0}", ex1.Message)
            Console.WriteLine()
            Console.WriteLine("例外発生場所：{0}", ex1.StackTrace)

        Catch ex2 As InvalidCastException
            Console.WriteLine("エラーが発生しました：{0}", ex2.Message)
            Console.WriteLine()
            Console.WriteLine("例外情報：{0}", ex2.InnerException)

        Catch ex3 As Exception
            Console.WriteLine(ex3.Message)

        End Try

        Console.ReadLine()


    End Sub

End Module
