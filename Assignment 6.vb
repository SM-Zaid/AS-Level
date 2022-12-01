Module Module1

    Sub Main()
        Dim D As Integer

        D = 0

        Console.Write("Enter Number of donuts: ")
        D = Console.ReadLine
        If D > 0 And D < 10 Then

            Console.WriteLine("Number of donuts: " & D)
        Else
            If D >= 10 Then
                Console.WriteLine("Number of donuts: many")
            End If
        End If
        Console.ReadKey()
    End Sub

End Module
