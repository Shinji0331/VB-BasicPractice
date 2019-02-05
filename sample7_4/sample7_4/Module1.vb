Module Module1

    Sub Main()
        Dim getabako(,) As String = {{"A", "B"}, {"C", "D"}, {"E", "F"}}

        For GYOU As Integer = 0 To 2
            For RETSU As Integer = 0 To 1
                Console.WriteLine("({0},{1}) = {2}", GYOU, RETSU, getabako(GYOU, RETSU))
            Next
        Next

        Console.ReadLine()

    End Sub

End Module
