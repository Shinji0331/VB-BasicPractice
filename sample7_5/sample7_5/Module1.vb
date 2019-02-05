Module Module1

    Sub Main()
        Dim getabako As String()() = New String(3)() {}
        getabako(0) = New String() {"A", "B", "C"}
        getabako(1) = New String() {"D", "E"}
        getabako(2) = New String() {"F", "G", "H", "I"}

        For GYOU As Integer = 0 To 2
            Console.WriteLine("{0}行目", GYOU + 1)

            For Each KUTSU As String In getabako(GYOU)
                Console.WriteLine(KUTSU)
            Next
        Next

        Console.ReadLine()

    End Sub

End Module
