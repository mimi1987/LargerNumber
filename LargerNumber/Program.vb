Imports System

Module Program
    Sub Main(args As String())
        'Declarations
        Dim Number1, Number2 As Integer

        'Ask the user for input
        Console.Write("Number 1: ")
        Number1 = Console.ReadLine()
        Console.Write("Number 2: ")
        Number2 = Console.ReadLine()

        'Output the larger number
        If Number2 > Number1 Then
            Console.WriteLine("SECOND")
        Else
            Console.WriteLine("FIRST")
        End If

        'Keep console window open
        Console.ReadKey()
    End Sub
End Module
