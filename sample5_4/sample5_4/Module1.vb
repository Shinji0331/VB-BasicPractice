Module Module1

    Sub Main()
        Dim strAge As String
        Dim Age As Integer

        Console.WriteLine("あなたの年齢を入力してください")

        strAge = Console.ReadLine()

        If IsNumeric(strAge) Then
            Age = CInt(strAge)
        Else
            Console.WriteLine("年齢は数値で入力してください")
            Console.ReadLine()
            Exit Sub
        End If

        If Age < 6 Or Age >= 60 Then
            Console.WriteLine("入園料は無料です")
        Else
            Console.WriteLine("入園料は800円です")
        End If

        Console.ReadLine()
    End Sub

End Module
