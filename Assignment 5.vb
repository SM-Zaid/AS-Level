Module Module1

    Sub Main()
        'Declarations
        Dim Str1 As String
        Dim Char1 As Char
        Dim i, vowelCounter As Integer

        'Initialise
        Str1 = ""
        Char1 = ""
        i = 0
        vowelCounter = 0

        'Input data
        Console.Write("Enter initial string: ")
        Str1 = Console.ReadLine

        'Process
        For i = 1 To Len(Str1)
            Char1 = Mid(Str1, i, 1)
            Char1 = UCase(Char1)
            If Char1 = "A" Or Char1 = "E" Or _
                Char1 = "I" Or Char1 = "O" Or _
                Char1 = "U" Then

                vowelCounter = vowelCounter + 1
            End If
        Next

        'OUTPUT Result
        Console.WriteLine("Vowels in string are: " & vowelCounter)


        Console.ReadKey()
    End Sub

End Module
