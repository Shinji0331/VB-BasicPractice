Module Module1

    Sub Main()
        Dim a As Integer
        Dim b As Single

        '単純代入
        a = 2
        Console.WriteLine("a = 2 : {0}", a)

        '加算代入
        a += 1
        Console.WriteLine("a += 1 : {0}", a)

        '減算代入
        a -= 1
        Console.WriteLine("a -= 1 : {0}", a)

        'べき乗代入
        a ^= 3
        Console.WriteLine("a ^= 3 : {0}", a)

        '乗算代入
        a *= 2
        Console.WriteLine(" a *= 2 : {0}", a)

        '単純代入
        b = 15
        Console.WriteLine(" b = 15 : {0}", b)

        '除算代入
        b /= 2
        Console.WriteLine("b /= 2 : {0}", b)

        '除算代入
        b \= 3
        Console.WriteLine("b \= 3 : {0}", b)

        Console.ReadLine()

    End Sub

End Module
