Module Module1

    Sub Main()
        'DECLARATIONS

        Dim STR1, STR2, STR3, A, B, C, D As String

        'INITIALISATION

        STR1 = ""
        STR2 = ""
        STR3 = ""
        A = ""
        B = ""
        C = ""
        D = ""
        'INPUT
        Console.Write("INPUT FIRST STRING: ")
        STR1 = Console.ReadLine
        Console.Write("INPUT SECOND STRING: ")
        STR2 = Console.ReadLine


        'PROCESS

        If Len(STR1) < 2 Or Len(STR2) < 2 Then
            Console.WriteLine("Wrong entry, Please enter again ")
        End If

        A = Mid(STR1, 3, Len(STR1) - 2)
        B = Mid(STR2, 3, Len(STR2) - 2)
        C = Left(STR1, 2)
        D = Left(STR2, 2)

        STR3 = D & A & C & B

        'OUTPUT

        Console.WriteLine("New string is: " & STR3)
        Console.ReadKey()
    End Sub

End Module
