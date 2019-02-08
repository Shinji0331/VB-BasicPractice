Module Module1

    Sub Main()

        Try
            Throw New MyException("独自のエラーが発生しました")

        Catch ex As MyException
            Console.WriteLine(ex.Message)

        End Try

        Console.ReadLine()

    End Sub

End Module
