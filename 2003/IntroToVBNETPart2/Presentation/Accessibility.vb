Imports System

' Private The method is callable only by other methods in the same class type.

' Protected The method is callable by derived types, regardless of whether they are 
' within the same assembly.

' Friend The method is callable by any code in the same assembly. (C# internal)

' Protected Friend Access is limited to the current project or types derived from the containing class. 
' (C# refers to this as internal protected).

' Public The method is callable by any code in any assembly.

' Source: Richter and Balena, Applied Microsoft .NET Framework Programming In 
' Microsoft Visual Basic .NET, p. 27


Public Class Accessibility
    Friend w As Integer = 1
    Private x As Integer = 2
    Protected y As Integer = 3
    Public z As Integer = 4

    Friend Function getW() As Integer
        Return Me.w
    End Function
    Private Function getX() As Integer
        Return Me.x
    End Function
    Protected Function getY() As Integer
        Return Me.y
    End Function
    Public Function getZ() As Integer
        Return Me.z
    End Function
    Public Sub DisplayAccessibility()
        Console.WriteLine("Accessibility: w: {0} x: {1} y: {2} z: {3}", w, x, y, z)
        Console.WriteLine("Accessibility: getW(): {0} getX(): {1} getY(): {2} getZ(): {3}", _
                getW(), getX(), getY(), getZ())
    End Sub
End Class

Public Class DerivedClass
    Inherits Accessibility
    Friend a As Integer = 5
    Private b As Integer = 6
    Protected c As Integer = 7
    Public d As Integer = 8
    Public Sub DisplayDerivedClass()
        Console.WriteLine("DerivedClass: a: {0} b: {1} c: {2} d: {3}", a, b, c, d)
        ' Compiler Error: AccessibilityExample.x is not accessible in this context because it is 'Private'
        Console.WriteLine("DerivedClass: w: {0}, (x is private, can't see) y: {1}, z: {2}", w, y, z)
        ' Compiler Error: AccessibilityExample.getX()  is not accessible in this context because it is 'Private'
        Console.WriteLine("DerivedClass: getW(): {0}, (getX is private, can't see) getY(): {1}, getZ(): {2}", _
               getW(), getY(), getZ())
    End Sub
End Class

Public Class Test
    Shared Sub Main()

        Dim ae As New Accessibility()
        Dim dc As New DerivedClass()

        ae.DisplayAccessibility()
        dc.DisplayAccessibility()
        dc.DisplayDerivedClass()

        ' Friend member examples
        Console.WriteLine("Friend Example: dc.a: {0} dc.w {1} dc.getW(): {2}", _
            dc.a, dc.w, dc.getW())

        ' Private member examples
        ' Compile error: [ b, x, getX()] is not accessible in this context because it is 'Private'
        'Console.WriteLine("Private example: dc.b: {0} dc.getB(): {1} dc.x: {2} dc.getX(): {3}", _
        '    dc.b, dc.x, dc.getX())

        ' Protected members examples
        ' Compile error: [y, getY(), c] is not accessible in this context because it is 'Protected'
        ' Console.WriteLine("Protected example: dc.y: {0} dc.getY(): {1} dc.c: {2}", dc.y, dc.getY(), dc.c)

        Console.WriteLine("Public example: dc.d: {0} dc.z: {1} dc.getZ(): {2}", dc.d, dc.z, dc.getZ())

    End Sub

End Class