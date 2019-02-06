Public Class PersonalComputer

    Public Sub New()
        _CPU = 2.6
        Console.WriteLine("CPUの値を{0}GHzで初期化しました", _CPU)
    End Sub

    Public Sub SayHello()
        Console.WriteLine("こんにちは")
    End Sub

    Public Sub DispCPU()
        Console.WriteLine("CPUは{0}GHzです。", _CPU)
    End Sub

    Private _CPU As Single

    Property CPU() As Single
        Get
            Return _CPU
        End Get
        Set(ByVal value As Single)
            _CPU = value
        End Set
    End Property

End Class
