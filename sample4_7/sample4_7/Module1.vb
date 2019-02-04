Module Module1

    Sub Main()
        '変数の宣言
        Dim msg As String
        Dim Name As String
        Dim Age As String

        '名前の取得
        Console.WriteLine("名前を入力してください")
        Name = Console.ReadLine()

        '年齢の取得
        Console.WriteLine("年齢を入力してください")
        Age = Console.ReadLine()

        'メッセージを作成して表示する
        msg = "あなたは　" & Name & " さん、" & Age & "歳ですね"
        Console.WriteLine(msg)

        Console.ReadLine()

    End Sub

End Module
