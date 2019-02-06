Public Class PersonalComputer
    Private _CPU As Single

    Public Sub New()
        _CPU = 2.6
    End Sub

    Public Sub New(ByVal CPU As Single)
        _CPU = CPU
    End Sub

    Public Property CPU() As Single
        Get
            Return _CPU
        End Get
        Set(ByVal value As Single)
            If value >= 1.0 And value <= 4.0 Then
                _CPU = value
            Else
                _CPU = 0.0
            End If
        End Set
    End Property


End Class
