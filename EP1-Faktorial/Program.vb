Imports System

Module Program
    Sub Main(args As String())
        Dim cislo As Object
        Dim vysledek As Integer = 1




        Do
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
                Console.WriteLine(" minimální zadané èíslo mùže být ")
                Console.ReadKey()
                End
            End If
        Loop

        For i = 1 To cislo
            vysledek = cislo * (cislo - i)
        Next

        Console.WriteLine($"fraktál od 10 do 1 cislo={cislo} je {vysledek}")

    End Sub
End Module

