Imports System
Imports System.Diagnostics.Metrics
Imports System.Threading
Imports System.Transactions

Module Program
    Sub Main()
        Dim STR1 As String
        Dim STR2 As String
        Dim Count1 As Integer
        Dim Count2 As Integer
        Dim Bln_Found As Boolean
        Dim Word1 As String
        Dim Word2 As String

        Bln_Found = False
        Count1 = 0
        Count2 = 0
        STR1 = ""
        STR2 = ""
        Word1 = ""
        Word2 = ""

        Console.Write("Enter String 1: ")
        STR1 = Console.ReadLine
        Console.Write("Enter String 2: ")
        STR2 = Console.ReadLine

        For i = 1 To Len(STR1)
            If Mid(STR1, i, 1) <> " " Then
                Count1 += 1
            Else
                Exit For
            End If
            Word1 = Mid(STR1, 1, Count1)
        Next
        For i = Len(STR2) - 1 To 1 Step -1
            If Mid(STR2, i, 1) <> " " Then
                Count2 += 1
            Else
                Exit For
            End If
            Word2 = Mid(STR2, Len(STR2) - Count2, Count2 + 1)
        Next
        Console.Write("First Word from String 1 is ")
        Console.WriteLine(Word1)

        Console.Write("Last Word from String 2 is ")
        Console.WriteLine(Word2)
    End Sub
End Module
