Imports System

Module Program
    Sub Main(args As String())
        Dim cislo As Integer
        Dim vysledek As Integer




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
            Console.WriteLine(" minim�ln� zadan� ��slo mus� b�t 1")
            Console.ReadKey()
                End
            End If



        Console.WriteLine($"faktori�l zadan�ho ��sla {cislo} je {vysledek}")

        For i = 1 To cislo
            vysledek = cislo * (cislo - i)
        Next

    End Sub
End Module

