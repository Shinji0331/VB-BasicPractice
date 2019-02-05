Module Module1

    Sub Main()
        Dim weight As Single
        Dim height As Single
        Dim BMI As Single

        Console.WriteLine("体系を判定します！！")
        Console.WriteLine("あなたの体重(kg)を入力してください")

        weight = Console.ReadLine()

        Console.WriteLine("あなたの身長（m）を教えてください")
        height = Console.ReadLine()

        BMI = weight / (height * height)

        Console.Write("あなたのBMI値は{0}で", BMI)

        If BMI < 18.5 Then
            Console.WriteLine("「やせ体型」です")
        ElseIf BMI < 25 Then
            Console.WriteLine("「標準体型」です")
        Else
            Console.WriteLine("「肥満体型」です")
        End If

        Console.ReadLine()

    End Sub

End Module
