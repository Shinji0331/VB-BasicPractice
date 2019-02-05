Module Module1

    Sub Main()
        Dim FriendName As String

        Console.WriteLine("友人の名前を３人入力してください")

        For I As Integer = 1 To 3
            Console.WriteLine("{0}人目の友人の名前を入力してください", I)
            FriendName = Console.ReadLine()
            Console.WriteLine("{0}人目の友人は{1}さんですね", I, FriendName)
            Console.WriteLine("")
        Next

        Console.ReadLine()

    End Sub

End Module
