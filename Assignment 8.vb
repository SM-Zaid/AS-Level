Module Module1

    Sub Main()
        'DECLARATIONS

        Dim CHAR1, CHAR2 As Char
        Dim S, S2 As String
        Dim i As Integer

        'INITIALISATION

        CHAR1 = ""
        CHAR2 = ""
        S = ""
        S2 = ""
        i = 0


        'INPUT

        Console.Write("Enter string: ")
        S = Console.ReadLine

        'PROCESS


        CHAR1 = Left(S, 1)

        For i = 1 To Len(S)
            CHAR2 = Mid(S, i + 1, 1)
            If CHAR1 = CHAR2 Then
                S2 = S2 & "*"
            Else
                S2 = S2 + CHAR2
            End If
        Next i

        'OUTPUT

        Console.WriteLine("New string is: " & CHAR1 & S2)
        Console.ReadKey()
    End Sub

End Module
