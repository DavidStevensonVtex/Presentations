Imports System
Imports Microsoft.VisualBasic

Module MyStdMod

    ' x appears as a global variable
    Friend x As Integer = 123
    Friend Function getX() As Integer
        Return x
    End Function

    ' Methods in a Module cannot be declared as Shared
    Sub New()
        x = 789
    End Sub

    ' Main appears as a global method
    Sub Main()
        Console.WriteLine("Main: x = {0} getX(): {1}", x, getX())
        Class2.DisplayData()
        AnotherClass.DisplayData()
    End Sub

    Public Class AnotherClass
        Public Shared Sub DisplayData()
            Console.WriteLine(vbCrLf & "AnotherClass.DisplayData: x = {0}", x)
            Console.WriteLine(vbCrLf & "AnotherClass.DisplayData: y = {0}", y)
        End Sub
    End Class

End Module

Module Module2
    Public y As Integer = 456

    Public Class Class2
        Public Shared Sub DisplayData()
            ' Dim abc As MyStdMod = New MyStdMod()     ' Error: Module 'MyStdMod' cannot be used as a type.
            Console.WriteLine(vbCrLf & "Module2.DisplayData: x = {0}", x)
            Console.WriteLine("Module2.DisplayData: y = {0}", y)
        End Sub

    End Class

End Module
