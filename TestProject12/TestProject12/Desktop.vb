Imports TestProject12

Public Class Desktop
    Implements PersonalComputer

    Public Sub PowerOn() Implements PersonalComputer.PowerOn
        Console.WriteLine("電源を入れました")
    End Sub
End Class
