Imports System

Module Program
  Sub Main(args As String())
        Dim cislo As Object
        Dim vysledek As Integer

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

        If cislo = 1 > 0 Then
            Console.WriteLine(" minimální zadané èíslo mùže být ")
            Console.ReadKey()
            End
        End If

    End Sub
End Module
