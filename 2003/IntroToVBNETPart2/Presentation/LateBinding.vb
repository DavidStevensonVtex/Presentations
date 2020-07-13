' Option Strict On
Imports System

Public Class Point
    Public x As Integer
    Public y As Integer
    Public Sub New(ByVal x As Integer, ByVal y As Integer)
        Me.x = x : Me.y = y
    End Sub
End Class

Public Class LateBinding
    Shared Sub Main()
        Dim o As Object = New Point(10, 20)
        ' If Option Strict On is enabled
        ' Compiler Error: Option Strict On disallows late binding
        ' Late Binding isn't recommended for 
        ' performance and type-safety reasons.
        ' Its primary use is to allow easier migration of VB6 programs.
        ' Note: C# does not allow late binding???
        
        ' The following line demonstrates late binding.
        Console.WriteLine("point: ({0}, {1})", o.x, o.y)

        ' The following demonstrates there is only one object
        Dim p As Point = DirectCast ( o, Point )
        ' Both o and p point to the same object
        o.x = 15
        p.y = 30
        Console.WriteLine("point: ({0}, {1})", p.x, p.y)
    End Sub
End Class