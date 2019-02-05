Module Module1

    Sub Main()
        For I As Integer = 1 To 10
            Console.Write("数字{0}は", I)
            If I Mod 2 = 1 Then
                Console.WriteLine("奇数です")
            Else
                Console.WriteLine("偶数です")
            End If
        Next

        Console.ReadLine()

    End Sub

End Module
