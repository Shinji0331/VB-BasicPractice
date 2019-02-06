Module Module1

    Sub Main()
        'Dim Z As Zukei

        'Z = New Triangle()
        'Z.DispMySelef()

        'Z = New Rectangle()
        'Z.DispMySelef()

        Dim Z(1) As Zukei

        Z(0) = New Triangle()
        Z(1) = New Rectangle()

        For Each katachi As Zukei In Z
            katachi.DispMySelef()
        Next

        Console.ReadLine()

    End Sub

End Module
