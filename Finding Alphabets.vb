Imports System
Imports System.Transactions

Module Program
    Sub Main()

        Dim Str As String
        Dim Str_Sample As String
        Dim Found As Boolean

        Str_Sample = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Str = ""
        Found = False

        Console.Write("Enter String to Check: ")
        Str = UCase(Console.ReadLine())
        If Len(Str) >= 26 Then
            For i = 1 To 26
                For count = 1 To Len(Str)
                    If Mid(Str, count, 1) = Mid(Str_Sample, i, 1) Then
                        Found = True
                        Exit For
                    End If
                Next
                If Found = False Then Exit For
            Next
        Else
            Console.WriteLine("All alphabets not found.")
        End If
        If Found = True Then
            Console.WriteLine("All Alphabets found.")
        End If

    End Sub
End Module
