' Option Strict On

Imports System

Public Class SwapParameters

    Shared Sub Swap(ByRef object1 As Object, ByRef object2 As Object)
        Dim temp As Object = object1
        object1 = object2
        object2 = temp
    End Sub

    Shared Sub Main()
        ' Option Strict On disallows implicit conversions from 'System.Object' to String
        Dim string1 As String = "Hello World"
        Dim string2 As String = "Hello Visual Developers of Upstate New York"
        Console.WriteLine( "Before Swap")
        Console.WriteLine("string1: {0}  string2: {1}", string1, string2)
        Swap( string1, string2)
         Console.WriteLine ( )
        Console.WriteLine( "After Swap")
        Console.WriteLine ( "string1: {0}  string2: {1}", string1, string2)

        Dim object1 As Object = 32
        Dim object2 As Object = "Hello Again"
        Console.WriteLine ( )
        Console.WriteLine( "Before Swap")
        Console.WriteLine("object1: {0}  object2: {1}", object1, object2)
        Swap(object1, object2)
        Console.WriteLine ( )
        Console.WriteLine( "After Swap")
        Console.WriteLine ( "object1: {0}  object2: {1}", object1, object2)

        Dim value1 As Integer = 123
        Dim value2 As Integer = 456
        Console.WriteLine ( )
        ' Compiler Error: Option Strict On disallows implicit conversions from 'System.Object' to 'Integer'.
        ' If Option Strict Off, then implicit conversions from Object to Integer allows use of 
        ' Swap(ByRef object1 As Object, ByRef object2 As Object)
        Console.WriteLine ( )
        Console.WriteLine ( "Before Swap")
        Console.WriteLine ( "value1: {0}  value2: {1}", value1, value2 )
        Swap ( value1, value2 )
        Console.WriteLine ( )
        Console.WriteLine ( "After Swap")
        Console.WriteLine ( "value1: {0}  object2: {1}", value1, value2)
    End Sub
    ' The following is the correct way to solve the the problem with Option Strict On
    ' It is not best practice to not have Option Strict On
    ' Shared Sub Swap ( ByRef val1 As Integer, ByRef val2 As Integer )
    '    Dim temp As Integer = val1
    '    val1 = val2
    '    val2 = temp
    ' End Sub
    ' Shared Sub Swap ( ByRef val1 As String, ByRef val2 As String )
    '    Dim temp As String = val1
    '    val1 = val2
    '    val2 = temp
    ' End Sub
End Class
