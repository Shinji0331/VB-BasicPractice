Module Module1

    Sub Main()
        Dim service As Integer

        Console.WriteLine("*****　VB銀行へようこそ　*****")
        Console.WriteLine("")
        Console.WriteLine("1：お引き出し")
        Console.WriteLine("2：残高照会")
        Console.WriteLine("3：ご入金")
        Console.WriteLine("")
        Console.WriteLine("ご希望のサービスコードを入力してください")

        service = Console.ReadLine()
        Console.WriteLine("")

        Select Case service
            Case 1
                Console.WriteLine("お引き出し処理を開始します。")
            Case 2
                Console.WriteLine("残高照会を開始します。")
            Case 3
                Console.WriteLine("ご入金処理を開始します。")
            Case Else
                Console.WriteLine("正しいサービスコードではないため終了します。")
                Console.ReadLine()
                Exit Sub
        End Select

        Console.WriteLine(":")
        Console.WriteLine("処理中です")
        Console.WriteLine("：")
        Console.WriteLine("処理が完了しました")
        Console.WriteLine("ご利用ありがとうございました")

        Console.ReadLine()

    End Sub

End Module
