Module Module1

    Sub Main()
        Dim PC As New PersonalComputer(0.0F)
        PC.CPU = 3.0F
        PC.SayHello()
        Console.ReadLine()

    End Sub

    Structure PersonalComputer
        Sub New(ByVal CPU As Single)
            _CPU = CPU
        End Sub

        Private _CPU As Single

        Public Property CPU() As Single
            Get
                Return _CPU
            End Get
            Set(ByVal value As Single)
                _CPU = value
            End Set
        End Property

        Public Sub SayHello()
            Console.WriteLine("こんにちわ！！このパソコンのCPUは{0}GHzです。", _CPU)
        End Sub

    End Structure

End Module
