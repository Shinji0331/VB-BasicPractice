Public Class Notebook
    Inherits PersonalComputer

    Private _HasBattery As Boolean

    Public Property HasBattery() As Boolean
        Get
            Return _HasBattery
        End Get
        Set(ByVal value As Boolean)
            _HasBattery = value
        End Set
    End Property

    Private _HasWireLessLan As Boolean

    Public Property HasWirelessLan() As Boolean
        Get
            Return _HasBattery
        End Get
        Set(ByVal value As Boolean)
            _HasBattery = value
        End Set
    End Property

    Public Sub DispHardware()
        If _HasBattery = True Then
            Console.WriteLine("バッテリーを搭載しています")
        Else
            Console.WriteLine("バッテリーを搭載していません")
        End If

        If _HasWireLessLan = True Then
            Console.WriteLine("無線LANを搭載しています")
        Else
            Console.WriteLine("無線LANを搭載していません")
        End If
    End Sub

End Class
