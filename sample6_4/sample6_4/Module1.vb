Module Module1

    Sub Main()
        Dim seviceNo As Integer = 0

        Console.WriteLine("******VB銀行へようこそ*****")
        Console.WriteLine("")
        Console.WriteLine("1:お引き出し")
        Console.WriteLine("2:残高照会")
        Console.WriteLine("3:ご入金")
        Console.WriteLine("9:終了")

        While seviceNo <> 9
            Console.WriteLine("ご希望のサービスコードを入力してください")
            seviceNo = Console.ReadLine()
            Console.WriteLine("")

            Select Case seviceNo
                Case 1
                    Console.WriteLine("お引き出し処理を開始します。")
                Case 2
                    Console.WriteLine("残高照会を開始します")
                Case 3
                    Console.WriteLine("ご入金処理を開始します")
                Case 9
                    Console.WriteLine("終了します")
                Case Else
                    Console.WriteLine("正しいサービスコードを入力してください")
            End Select

            If seviceNo >= 1 And seviceNo <= 3 Then
                Console.WriteLine("：")
                Console.WriteLine("処理中です")
                Console.WriteLine("：")
                Console.WriteLine("処理が完了しました")
                Console.WriteLine("")
            End If

        End While

        Console.WriteLine("ご利用ありがとうございました")
        Console.ReadLine()

    End Sub

End Module
