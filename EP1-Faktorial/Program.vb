Imports System

Module Program
  Sub Main(args As String())
        Dim cislo As Object
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
        End If

        If cislo = 1 > 0 Then
            Console.WriteLine(" minim�ln� zadan� ��slo m��e b�t ")
        End If

    End Sub
End Module
