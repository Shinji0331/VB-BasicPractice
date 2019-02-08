Module Module1

    Sub Main()
        Dim msg As New Message()
        Dim dMsg As ShowMessage
        dMsg = New ShowMessage(AddressOf msg.SayHello)
        dMsg()

        Console.ReadLine()

    End Sub

End Module
