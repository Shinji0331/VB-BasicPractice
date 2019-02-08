Imports ジェネリッククラスの制約

Public Class Sample6(Of T As ISampleInterface)

End Class

Public Interface ISampleInterface
    Sub TestMethod()
End Interface

Public Class ABC4
    Implements ISampleInterface

    Public Sub TestMethod() Implements ISampleInterface.TestMethod

    End Sub
End Class
