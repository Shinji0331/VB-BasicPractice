Module Module1

    Sub Main()
        Dim PC1 As New Notebook()
        Dim PC2 As New Desktop()

        Console.WriteLine("=====Notebookクラスのインスタンス=====")
        PC1.SayHello()
        PC1.DispCPU()

        Console.WriteLine("=====Desktopクラスのインスタンス=====")
        PC2.SayHello()
        PC2.DispCPU()

        Console.ReadLine()

    End Sub

End Module
