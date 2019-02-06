Module Module1

    Sub Main()
        Dim enzan As New ShisokuEnzan()
        Dim keisan As Calculate

        '=========デリゲート============
        'keisan = New Calculate(AddressOf enzan.Tashizan)
        'keisan(3, 5)

        'keisan = New Calculate(AddressOf enzan.Hikizan)
        'keisan(5, 3)

        'keisan = New Calculate(AddressOf enzan.Kakezan)
        'keisan(2, 4)

        'keisan = New Calculate(AddressOf enzan.Warizan)
        'keisan(6, 2)

        =========マルチキャストデリゲート============

        Console.ReadLine()

    End Sub

End Module
