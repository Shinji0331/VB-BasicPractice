Public Class SampleClass（Of T)

    Private hensu As T

    Private _CPU As T
    Public Property CPU() As T
        Get
            Return _CPU
        End Get
        Set(ByVal value As T)
            _CPU = value
        End Set
    End Property

    Public Sub Swap(ByRef X As T, ByRef Y As T)
        Dim Buff As T
        Buff = X
        X = Y
        Y = Buff
    End Sub
End Class
