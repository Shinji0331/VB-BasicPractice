Module Module1

    Sub Main()
        Dim Colors() As String = {"RED", "YELLOW", "GREEN", "BLUE", "BROWN", "PURPLE"}

        For Each color As String In Colors
            Console.WriteLine(color)
        Next

        Console.ReadLine()
    End Sub

End Module
