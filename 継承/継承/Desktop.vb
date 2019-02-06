Public Class Desktop
    Inherits PersonalComputer

    Private _HasDvdRom As Boolean

    Public Property HasDvdRom() As Boolean
        Get
            Return _HasDvdRom
        End Get
        Set(ByVal value As Boolean)
            _HasDvdRom = value
        End Set
    End Property

    Private _HasMediaReader As Boolean

    Public Property HasMediaReader() As Boolean
        Get
            Return _HasMediaReader
        End Get
        Set(ByVal value As Boolean)
            _HasMediaReader = value
        End Set
    End Property

    Public Sub DispHardware()
        If _HasDvdRom = True Then
            Console.WriteLine("DVD-ROMドライブを搭載しています")
        Else
            Console.WriteLine("DVD-ROMを搭載していません")
        End If

        If _HasMediaReader = True Then
            Console.WriteLine("メディアリーダーを搭載しています")
        Else
            Console.WriteLine("メディアリーダーを搭載していません")
        End If
    End Sub

End Class
