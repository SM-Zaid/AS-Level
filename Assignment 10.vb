Module Module1

    Sub Main()
        'DECLARATIONS

        Dim S, S1 As String

        'INITIALISATION

        S = ""
        S1 = ""

        'INPUT

        Console.Write("Enter string: ")
        S = Console.ReadLine

        'PROCESS

        If Len(S) < 3 Then
            Console.WriteLine(S)
        End If

        If Right(S, 3) = "ing" Then
            S1 = S + "ly"
        Else
            S1 = S + "ing"
        End If

        'OUTPUT

        Console.WriteLine("The new Word is: " & S1)
        Console.ReadKey()
    End Sub

End Module
