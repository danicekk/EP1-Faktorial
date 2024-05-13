Imports System

Module Program
    Sub Main(args As String())
        Dim cislo As Integer
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

            If cislo < 0 Then
            Console.WriteLine(" minimální zadané èíslo musí být 1")
            Console.ReadKey()
                End
            End If



        Console.WriteLine($"faktoriál zadaného èísla {cislo} je {vysledek}")

        For i = 1 To cislo
            vysledek = cislo * (cislo - i)
        Next

    End Sub
End Module

