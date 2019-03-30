Imports System.Console

Module Module1

    Sub Main()
        WriteLine("About VB Example")
        WriteLine()
        'Prompt user identifier
        Dim ReplyString As String
        Write("Type A or B:")
        ReplyString = ReadLine()
        Write("You typed:" & ReplyString)
        Readline()
    End Sub

End Module
