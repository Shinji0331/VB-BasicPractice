Module Module1

    Sub Main()
        '4-1==================================
        Console.WriteLine(2 ^ 3)
        Console.WriteLine(2 + 2 * 3 + 2 ^ 3 / 2)
        Console.WriteLine(10 / 3)
        Console.WriteLine(10 \ 3)
        Console.WriteLine(10 Mod 3)
        Console.WriteLine("")

        '4-2==================================
        Dim kotae As Integer = 12 / 2
        Console.WriteLine(kotae)
        Dim A As Integer = 2
        A ^= 3
        Console.WriteLine(A)
        Dim B As Integer = 2
        B *= 3
        Console.WriteLine(B)
        Dim C As Integer = 10
        C /= 10
        Console.WriteLine(C)
        Dim D As Integer = 10
        D \= 3
        Console.WriteLine(D)
        Dim E As Integer = 5
        E += 3
        Console.WriteLine(E)
        Dim F As Integer = 5
        F -= 3
        Console.WriteLine(F)
        Console.WriteLine("")

        '4-3====================================
        Console.WriteLine(8 >> 2)
        Console.WriteLine(2 << 3)
        Console.WriteLine("")

        '4-4======================================
        Console.WriteLine(3 = 5)
        Console.WriteLine(3 <> 5)
        Console.WriteLine(3 > 5)
        Console.WriteLine(3 >= 5)
        Console.WriteLine(3 < 5)
        Console.WriteLine(3 <= 5)
        Console.WriteLine("")

        '4-5======================================
        Console.WriteLine("Visual " & "Basic")
        Console.WriteLine("")

        '4-6=======================================
        Console.WriteLine(3 < 5 And 2 > 4)
        Console.WriteLine(3 < 5 Or 2 > 4)
        Console.WriteLine(3 < 5 Xor 2 > 4)
        Console.WriteLine(Not 1 < 5)
        Console.WriteLine(5 < 1 AndAlso 2 < 4)
        Console.WriteLine(5 < 1 OrElse 2 < 4)

        Console.ReadLine()

    End Sub

End Module
