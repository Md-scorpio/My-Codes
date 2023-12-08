Imports System
Imports System.Transactions

Module Program
    Sub Main()

        Dim Text As String
        Dim char1 As Char
        Dim char2 As Char
        Dim i As Integer

        Console.Write("Enter a String: ")
        Text = Console.ReadLine
        Console.Write("Enter character that you want to replace: ")
        char1 = Console.ReadLine
        Console.Write("Enter character that you want to replace with: ")
        char2 = Console.ReadLine
        For i = 1 To Len(Text)
            If Mid(Text, i, 1) = char1 Then
                Mid(Text, i, 1) = char2
            End If
        Next
        Console.Write("The changed string is: ")
        Console.WriteLine(Text)
    End Sub
End Module
