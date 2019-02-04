'================================================================
'プログラム名：Hello

'作成者：HIRO
'作成日：2009-04-25
'================================================================
Module Module1
    ''' <summary>
    ''' 'を三回うつとドキュメントコメントが挿入される
    ''' </summary>


    Sub Main()
        Dim name As String

        '名前を尋ねるためのメッセージを表示
        Console.WriteLine("あなたのお名前を教えてください")

        name = Console.ReadLine()　'名前を取得する

        '下記の3行で「こんにちわ　XX　さん」と表示する
        Console.Write("こんにちわ　")
        Console.Write(name)
        Console.Write(" さん")

        Console.ReadLine()
    End Sub

End Module
