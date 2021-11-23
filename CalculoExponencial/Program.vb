Imports System

Module Program

    Sub Main(args As String())

        Console.WriteLine("informe a base: ")
        Dim base As Integer = Console.ReadLine()
        Console.WriteLine("informe o exponente: ")
        Dim exp As Integer = Console.ReadLine()

        Dim i = 1
        Dim temp = base

        If (exp = 0) Then
            base = 1
        Else
            While (i < exp)
                base *= temp
                i += 1
            End While
        End If

        Console.WriteLine($"Resultado: {base}")

    End Sub

End Module
