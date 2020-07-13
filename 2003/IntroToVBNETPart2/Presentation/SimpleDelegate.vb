Imports System
Public Class SimpleDelegateTest
    Delegate Sub SimpleDelegate(ByVal i As Integer, ByRef refInt As Integer)
    Sub SquareArea(ByVal i As Integer, ByRef square As Integer)
        square = i * i
    End Sub
    Shared Sub CubicVolume(ByVal i As Integer, ByRef cube As Integer)
        cube = i * i * i
    End Sub
    Shared Sub PrintResults ( ByVal d As SimpleDelegate )
        Dim i, value As Integer
        For i = 0 To 5
            d(i, value)
            Console.WriteLine("{0} {1}", i, value )
        Next
    End Sub
    Shared Sub Main()
        Dim sdt As New SimpleDelegateTest ()
		' A delegate for an instance method
        Dim squared As New SimpleDelegate(AddressOf sdt.SquareArea)
		' A delegate for a static method
        Dim cubed As New SimpleDelegate(AddressOf CubicVolume)
        PrintResults ( squared )
        PrintResults ( cubed ) 
    End Sub
End Class

