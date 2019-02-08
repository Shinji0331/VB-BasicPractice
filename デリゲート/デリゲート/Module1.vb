Module Module1

    Sub Main()
        Dim enzan As New ShisokuEnzan()


        '=========デリゲート============
        'Dim keisan As Calculate

        'keisan = New Calculate(AddressOf enzan.Tashizan)
        'keisan(3, 5)

        'keisan = New Calculate(AddressOf enzan.Hikizan)
        'keisan(5, 3)

        'keisan = New Calculate(AddressOf enzan.Kakezan)
        'keisan(2, 4)

        'keisan = New Calculate(AddressOf enzan.Warizan)
        'keisan(6, 2)

        '=========マルチキャストデリゲート============
        Dim keisan1 As Calculate = AddressOf enzan.Tashizan
        Dim keisan2 As Calculate = AddressOf enzan.Hikizan
        Dim keisan3 As Calculate = AddressOf enzan.Kakezan
        Dim keisan4 As Calculate = AddressOf enzan.Warizan

        keisan1 = System.Delegate.Combine(keisan1, keisan2, keisan3, keisan4)

        keisan1(10, 2)

        Console.ReadLine()

    End Sub

End Module
