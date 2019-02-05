Module Module1

    Sub Main()
        Dim Total As Integer = 0
        Dim X As Integer = 0

        Do While Total < 100
            Console.Write("{0} + {1} = ", Total, X)
            Total += X
            Console.WriteLine(Total)
            X += 1
        Loop

        Console.ReadLine()

    End Sub

End Module
