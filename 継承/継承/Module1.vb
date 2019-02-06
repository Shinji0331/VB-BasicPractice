Module Module1

    Sub Main()
        Dim PC1 As New Notebook()
        Dim PC2 As New Desktop()

        Console.WriteLine("=====Notebookクラスのインスタンス=====")
        PC1.CPU = 2.2
        PC1.DispCPU()
        PC1.SayHello()
        PC1.HasBattery = True
        PC1.HasWirelessLan = True
        PC1.DispHardware()


        Console.WriteLine("=====Desktopクラスのインスタンス=====")
        PC2.CPU = 3.2
        PC2.DispCPU()
        PC2.SayHello()
        PC2.HasDvdRom = True
        PC2.HasMediaReader = True
        PC2.DispHardware()


        Console.ReadLine()

    End Sub

End Module
