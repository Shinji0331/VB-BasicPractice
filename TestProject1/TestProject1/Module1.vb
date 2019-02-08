Module Module1

    Sub Main()

        Dim Numbers = New Integer() {1, 2, 3, 4, 5}
        Try
            Console.WriteLine(Numbers(7))
        Catch ex As IndexOutOfRangeException
            Console.WriteLine(ex.Message)

        End Try

        Console.ReadLine()

    End Sub

End Module
