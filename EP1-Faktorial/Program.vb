Imports System
Imports System.Numerics
Imports System.Security.Cryptography

Module Program
    Sub Main(args As String())
        Dim cislo As Object
        Dim vysledek As Integer = 1

        Console.WriteLine("Zadej èíslo")
        cislo = Console.ReadLine
        

        If Not IsNumeric(cislo) Then
            Console.WriteLine(" Vstup musí být èíslo ")
            Console.ReadKey()
            End
        End If

        If cislo > 10 Then
            Console.WriteLine(" èíslo musí být menší ")
            Console.ReadKey()
            End
        End If

        If cislo < 0 Then
            Console.WriteLine(" minimální zadané èíslo musí být 1")
            Console.ReadKey()
            End
        End If


        For i As Integer = 1 To cislo
            vysledek *= i
        Next



        Console.WriteLine($"faktoriál zadaného èísla {cislo} je {vysledek}")




    End Sub
End Module




