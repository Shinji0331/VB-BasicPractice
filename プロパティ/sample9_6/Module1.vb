Module Module1

    Sub Main()
        Dim PC1 As New PersonalComputer()
        Dim PC2 As New PersonalComputer()

        PC1.CPU = 2.6
        PC2.CPU = 5.3

        Console.WriteLine("PC1のCPUは{0}GHzです", PC1.CPU)
        Console.WriteLine("PC2のCPUは{0}GHzです", PC2.CPU)

        Console.ReadLine()

    End Sub

End Module
