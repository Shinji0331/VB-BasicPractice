﻿Public Class MyException
    Inherits System.Exception

    Public Sub New(ByVal Message As String)
        MyBase.New(Message)
    End Sub

End Class
