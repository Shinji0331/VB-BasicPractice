Module Module1

    Sub Main()
        Dim Alphabet(,) As String = {
            {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M"},
            {"N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
            }
        For I As Integer = 0 To 1
            For X As Integer = 0 To 12
                Console.WriteLine(Alphabet(I, X))
            Next
        Next

        Console.ReadLine()
    End Sub

End Module
