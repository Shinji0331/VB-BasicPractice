Module Module1

    Sub Main()
        Dim kazu As Integer
        Dim moji As String

        Console.WriteLine("あなたの年齢を入力してください")
        kazu = Console.ReadLine()
        Console.WriteLine("あなたの名前を入力してください")
        moji = Console.ReadLine()

        Console.WriteLine(moji & "さんは" & CStr(kazu) & "歳です")
        Console.ReadLine()

    End Sub

End Module
