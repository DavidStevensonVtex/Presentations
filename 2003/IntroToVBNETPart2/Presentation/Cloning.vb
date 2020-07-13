Option Strict On
Imports System

Public Class MyRefType
    Public r As Single
    Public i As Double
    Public Sub New(ByVal r As Single, ByVal i As Double)
        Me.r = r : Me.i = i
    End Sub
End Class

Public Class MyObject
    Implements ICloneable
    Public X As Int32
    Public Y As MyRefType
    Public Sub New(ByVal X As Int32, ByVal Y As MyRefType)
        Me.X = X : Me.Y = Y
    End Sub
    Public Overrides Function ToString() As String
        Return String.Format("X: {0} Y.r: {1} Y.i {2}", X, Y.r, Y.i)
    End Function
    Public Overridable Overloads Function Clone() As Object _
            Implements ICloneable.Clone
        Return New MyObject(X, New MyRefType(Y.r, Y.i))
    End Function
End Class

Public Class Test
    Shared Sub Main()
        Dim myObject1 As New MyObject(123, New MyRefType(4.56, 7.89))
        Dim myObject2 As MyObject
        ' To obtain a copy that can be modified without affecting the original,
        ' this is the wrong way to do it. The reference is copied.
        Console.WriteLine("set myObject2 = myObject1 (copy object references, points to same data)")
        myObject2 = myObject1
        Console.WriteLine("myObject1: {0}", myObject1.ToString())
        Console.WriteLine("myObject2: {0}", myObject2.ToString())
        Console.WriteLine()
        Console.WriteLine("Set myObject2.Y.i to 9.87")
        myObject2.Y.i = 9.87
        Console.WriteLine("myObject1: {0}", myObject1.ToString())
        Console.WriteLine("myObject2: {0}", myObject2.ToString())
        Console.WriteLine("Ooops! set myObject1.Y.i to 9.87 as well. Not good if we didn't mean to do that.")

        ' Create a new myObject2 that is distinct from myObject1
        myObject2 = New MyObject(12345, New MyRefType(56789.0, 98765.0))
        Console.WriteLine()
        Console.WriteLine("This demonstrates how a good copy is made")
        ' Perform the cloning operation
        Console.WriteLine("myObject1 = DirectCast(myObject2.Clone(), MyObject)")
        myObject1 = DirectCast(myObject2.Clone(), MyObject)
        ' Change something in myObject2 which shouldn't be changed in myObject1 if cloning worked.
        Console.WriteLine("Set myObject2.Y.r = 1.23")
        myObject2.Y.r = 1.23
        Console.WriteLine("myObject1: {0}", myObject1.ToString())
        Console.WriteLine("myObject2: {0}", myObject2.ToString())
    End Sub
End Class