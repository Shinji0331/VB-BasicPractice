Public Class PersonalComputer
    Private _CPU As Single

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
