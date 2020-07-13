Option Strict On
Imports System
Imports Microsoft.VisualBasic 

Public Structure Point
    Public x As Integer
    Public y As Integer
    Public Sub New(ByVal x As Integer, ByVal y As Integer)
        Me.x = x : Me.y = y
    End Sub
End Structure

Class Test
    Shared Sub Main()
        Dim p1 As New Point(10, 20)
        Dim p2 As New Point(30, 40)
        p1 = p2
        Console.WriteLine("p1: ({0}, {1})", p1.x, p1.y)
        Console.WriteLine("p2: ({0}, {1})", p2.x, p2.y)
        p2.x = 50
        Console.WriteLine () 
        Console.WriteLine ( "p2.x = 50" )
        Console.WriteLine("p1: ({0}, {1})", p1.x, p1.y)
        Console.WriteLine("p2: ({0}, {1})", p2.x, p2.y)
    End Sub
End Class