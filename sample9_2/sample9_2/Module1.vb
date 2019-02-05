Module Module1

    Sub Main()
        Dim PC1 As New PersonalComputer()
        Dim PC2 As New PersonalComputer()

        PC1.CPU = 2.6
        PC2.CPU = 3.0

        Console.WriteLine("PC1のCPUは{0}GHzです。", PC1.CPU)
        Console.WriteLine("PC2のCPUは{0}GHzです。", PC2.CPU)

        Console.ReadLine()

        Dim PC As New PersonalComputer
        Dim kotae As Integer = 0

        PC.Tashizan(3, 7)

        kotae = PC.Tashizan2(4, 6)

        Console.WriteLine(kotae)
        Console.ReadLine()
    End Sub

End Module
