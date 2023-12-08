Imports System
Imports System.Runtime.InteropServices.JavaScript.JSType
Imports System.Xml

Module Program
    Sub Main()

        Dim Text As String
        Dim character As Char
        Dim count As Integer

        Console.Write("Enter String: ")
        Text = Console.ReadLine

        Do
            character = Left(Text, 1)
            For i = 1 To Len(Text)
                If Mid(Text, i, 1) = character Then
                    count += 1
                End If
            Next
            Console.WriteLine("The Character " & character & " has occurred " & count & " times")
            count = 0
            Text = Text.Replace(character, "")
            If Len(Text) = 0 Then Exit Do
        Loop


    End Sub
End Module
