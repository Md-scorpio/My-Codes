

Module Program
    Sub Main()
        Dim STR1 As String
        Dim STR2 As String
        Dim ARRAY2() As String
        Dim ARRAY1() As String
        Dim index As Integer
        Dim index2 As Integer
        Dim Found As Boolean

        STR1 = ""
        STR2 = ""
        index = 0
        index2 = 0
        Found = True

        Console.Write("Enter String 1: ")
        STR1 = Console.ReadLine
        STR1 = UCase(STR1)
        ReDim ARRAY1(Len(STR1))
        ReDim ARRAY2(Len(STR1))

        Console.Write("Enter String 2: ")
        STR2 = Console.ReadLine
        STR2 = UCase(STR2)


        If Len(STR1) = Len(STR2) Then
            For index = 1 To Len(STR1)
                ARRAY1(index - 1) = Mid(STR1, index, 1)
                ARRAY2(index - 1) = Mid(STR2, index, 1)
            Next
            index = 0
            For index = 0 To Len(STR1) - 1
                Found = False
                For index2 = 0 To Len(STR2) - 1
                    If ARRAY1(index) = ARRAY2(index2) Then
                        ARRAY2(index2) = 0
                        Found = True
                    End If
                    If Found = True Then Exit For
                Next
                If Found = False Then Exit For
                If index = Len(STR1) Then Exit For
            Next
            If Found = True Then
                Console.WriteLine("String have same characters")
            Else
                Console.WriteLine("String do not have same charachters")
            End If
        Else
            Console.WriteLine("String do not have same charachters")
        End If
    End Sub
End Module
