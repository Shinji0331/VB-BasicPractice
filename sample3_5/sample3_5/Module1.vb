Module Module1

    Sub Main()
        Dim weight As Single  '体重格納用変数
        Dim height As Single  '身長格納用変数
        Dim BMI As Single     'BMI格納用変数

        'メッセージの表示
        Console.WriteLine("BMI値を求めます！！")
        Console.WriteLine("あなたの体重（kg）を入力してください。")

        '体重を取得
        weight = CSng(Console.ReadLine())
        'メッセージの表示
        Console.WriteLine("あなたの身長（m）を教えてください")
        '身長の取得
        height = CSng(Console.ReadLine())
        'BMIの計算
        BMI = weight / (height * height)
        Console.Write("あなたのBMI値は　" & CStr(BMI) & "　です。")

        Console.ReadLine()

    End Sub

End Module
