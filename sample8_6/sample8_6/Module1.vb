Module Module1

    Sub Main()
        Dim Fruits As New Hashtable

        Fruits.Add("Banana", "バナナ")
        Fruits.Add("Apple", "りんご")
        Fruits.Add("Orange", "オレンジ")

        Console.WriteLine(Fruits("Banana"))
        Console.WriteLine(Fruits("Apple"))
        Console.WriteLine(Fruits("Orange"))
        Console.ReadLine()

    End Sub

End Module
