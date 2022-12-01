Module Module1

    Sub Main()
        'DECLARATIONS
        Dim Str1 As String
        Dim Char1 As Char
        Dim chstr1, i, digit, alpha, special As Integer

        'INITIALISE
        Str1 = ""
        Char1 = ""
        i = 0
        chstr1 = 0
        alpha = 0
        digit = 0
        special = 0

        'INPUT
        Console.Write("Enter string to process: ")
        Str1 = Console.ReadLine


        'PROCESS
        chstr1 = Len(Str1)



        For i = 1 To chstr1
            Char1 = Mid(Str1, i, 1)
            Char1 = LCase(Char1)



            If Char1 >= "a" And Char1 <= "z" Then
                alpha = alpha + 1
            ElseIf Char1 >= "0" And Char1 <= "9" Then

                digit = digit + 1
            Else : special = special + 1
            End If

        Next i

        'OUTPUT
        Console.WriteLine("Number of characters are: " & chstr1)
        Console.WriteLine("Number of digits are: " & digit)
        Console.WriteLine("Number of alphabets are: " & alpha)
        Console.WriteLine("Number of other characters are: " & special)

        Console.ReadKey()
    End Sub

End Module
