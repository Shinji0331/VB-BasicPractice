Module Module1

    Sub Main()
        Dim K As New Keisan()
        Console.WriteLine(K.Kakezan(2, 3))
        Console.WriteLine(K.Kakezan(1.5F, 3.0F))
        Console.WriteLine(K.Kakezan(2, 3, 4))

        Console.ReadLine()
    End Sub

End Module
