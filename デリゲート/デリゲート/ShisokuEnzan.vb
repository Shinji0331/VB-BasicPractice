Delegate Sub Calculate(ByVal X As Integer, ByVal Y As Integer)

Public Class ShisokuEnzan
    Public Sub Tashizan(ByVal X As Integer, ByVal Y As Integer)
        Console.WriteLine("{0} + {1} = {2}", X, Y, X + Y)
    End Sub

    Public Sub Hikizan(ByVal X As Integer, ByVal Y As Integer)
        Console.WriteLine("{0} - {1} = {2}", X, Y, X - Y)
    End Sub

    Public Sub Kakezan(ByVal X As Integer, ByVal Y As Integer)
        Console.WriteLine("{0} * {1} = {2}", X, Y, X * Y)
    End Sub

    Public Sub Warizan(ByVal X As Integer, ByVal Y As Integer)
        Console.WriteLine("{0} / {1} = {2}", X, Y, X / Y)
    End Sub

End Class
