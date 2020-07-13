Option Strict On
Imports System
Imports Microsoft.VisualBasic

Public Class TypeOfTest
    Class Car

    End Class

    Shared Sub Main()
        Dim o As Object = New Object()
        Dim c As Car = New Car()
        Dim b1 As Boolean = (TypeOf o Is Object)
        Dim b2 As Boolean = (TypeOf o Is Car)

        Console.WriteLine("b1: {0}  b2: {1}  TypeName(o): {2}", b1, b2, TypeName(o))

        ' The TypeOf…Is operator returns True if an object is of a specific type, 
        ' or is derived from a specific type.
        o = c
        b1 = (TypeOf o Is System.Object)
        b2 = (TypeOf o Is Car)
        Console.WriteLine("b1: {0}  b2: {1}  TypeName(o): {2}", b1, b2, TypeName(o))

        ' Performance issue: CLR is checking the object's type twice.
        ' C# offers a better performance alternative.
        ' e = o as Employee
        ' if ( e != null ) {
        '           // Do some work.
        '}
        If TypeOf o Is Car Then
            c = DirectCast(o, Car)
        End If

    End Sub

End Class
