Imports System

Module Program
    Sub Main(args As String())
        Dim cislo As Object
        Dim vysledek As Integer = 1




        Do
            Console.WriteLine("Zadej ��slo")
            cislo = Console.ReadLine

            If Not IsNumeric(cislo) Then
                Console.WriteLine(" Vstup mus� b�t ��slo ")
                Console.ReadKey()
                End
            End If

            If cislo > 10 Then
                Console.WriteLine(" ��slo mus� b�t men�� ")
                Console.ReadKey()
                End
            End If

            If cislo < 0 Then
                Console.WriteLine(" minim�ln� zadan� ��slo m��e b�t ")
                Console.ReadKey()
                End
            End If
        Loop

        For i = 1 To cislo
            vysledek = cislo * (cislo - i)
        Next

        Console.WriteLine($"frakt�l od 10 do 1 cislo={cislo} je {vysledek}")

    End Sub
End Module

