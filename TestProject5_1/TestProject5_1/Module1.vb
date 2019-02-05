Module Module1

    Sub Main()
        Dim strAge As String
        Dim Age As Integer

        Console.WriteLine("*****VB博物館へようこそ*****")
        Console.WriteLine("")
        Console.WriteLine("お客様の年齢を入力してください")
        strAge = Console.ReadLine()

        If IsNumeric(strAge) Then
            Age = CInt(strAge)
        Else
            Console.WriteLine("年齢は数値にて入力してください")
            Console.ReadLine()
            Exit Sub
        End If

        If Age < 7 Then
            Console.WriteLine("入館料は無料です。")
        ElseIf Age <= 12 Then
            Console.WriteLine("入館料は500円です。")
        ElseIf Age <= 18 Then
            Console.WriteLine("入館料は800円です。")
        ElseIf Age < 60 Then
            Console.WriteLine("入館料は1000円です。")
        Else
            Console.WriteLine("入館料は500円です。")
        End If

        Console.ReadLine()


    End Sub

End Module
