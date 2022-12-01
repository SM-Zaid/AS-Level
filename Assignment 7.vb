Module Module1

    Sub Main()
        'DECLARATIONS
        Dim S, S2 As String

        'INITIALISATION
        S = ""
        S2 = ""

        'INPUT
        Console.Write("Enter string: ")
        S = Console.ReadLine()

        'PROCESS
        S2 = Left(S, 2) & Right(S, 2)

        'OUTPUT
        Console.WriteLine(S2)
        Console.ReadKey()
    End Sub

End Module
