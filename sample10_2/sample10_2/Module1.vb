Module Module1

    Sub Main()
        Dim PC1 As New PersonalComputer()
        Dim PC2 As New PersonalComputer(3.0F)

        Console.WriteLine(PC1.CPU)
        Console.WriteLine(PC2.CPU)

        Console.ReadLine()

    End Sub

End Module
