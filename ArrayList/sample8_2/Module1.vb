Module Module1

    Sub Main()
        Dim Kisu As New ArrayList()

        For I = 1 To 9 Step 2
            Kisu.Add(I)
        Next

        For Each kazu In Kisu
            Console.WriteLine(kazu)
        Next

        Console.ReadLine()

    End Sub

End Module
