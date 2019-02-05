Module Module1

    Sub Main()
        Dim strMenu As String
        Dim menu As Integer

        Console.WriteLine("*****うどん屋VBへようこそ*****")
        Console.WriteLine("1：かけうどん")
        Console.WriteLine("2：ざるうどん")
        Console.WriteLine("3：天ぷらうどん")
        Console.WriteLine("4：たぬきうどん")
        Console.WriteLine("5：きつねうどん")

        Console.WriteLine("ご希望のメニューの番号を入力してください")
        strMenu = Console.ReadLine()

        If IsNumeric(strMenu) Then
            menu = CInt(strMenu)
        Else
            Console.WriteLine("数値を入力してください。")
            Console.ReadLine()
            Exit Sub
        End If

        Select Case menu
            Case 1
                Console.WriteLine("かけうどんは400円になります")
            Case 2
                Console.WriteLine("ざるうどんは410円になります")
            Case 3
                Console.WriteLine("天ぷらうどんは800円になります")
            Case 4
                Console.WriteLine("たぬきうどんは650円になります")
            Case 5
                Console.WriteLine("きつねうどんは700円になります")
            Case Else
                Console.WriteLine("入力された番号のメニューがありません。最初からやり直してください")
        End Select

        Console.ReadLine()

    End Sub

End Module
