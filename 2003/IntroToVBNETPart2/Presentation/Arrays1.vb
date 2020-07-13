Imports System
Imports System.Collections
Imports Microsoft.VisualBasic

Public Class Arrays1
    Shared Sub Main()
        Dim myInts(5) As Integer
        Dim yourInts() As Integer = New Integer() {123, 456, 789, 12, 34, 56}
        Dim myMatrix(10, 20) As Int32
        Dim daysInMonth(,) As Integer = New Integer(,) { _
            {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}, _
            {31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31} _
            }
        Dim myCube(5, 10, 15) As Int32
        myInts(0) = 123
        myInts(5) = 567
        DisplayInts(yourInts)

        ' Demonstrate converting ArrayList to an Array
        Console.WriteLine ( ) 
        Console.WriteLine( "Converting ArrayList to an Array")
        Dim myStringList As New ArrayList(5)
        myStringList.Add("Dave")
        myStringList.Add("Bob")
        myStringList.Add("Sally")
        Dim myStrings() As String
        ' This is the trick. A one-line conversion from ArrayList to an Array
        myStrings = DirectCast ( myStringList.ToArray( GetType (String) ), String () )
        Dim myString As String
        For Each myString In myStrings
            Console.WriteLine("{0}", myString)
        Next

    End Sub

    Shared Sub DisplayInts(ByRef a() As Int32)
        Dim i As Int32
        Console.WriteLine ( )
        Console.WriteLine("From a.GetLowerBound(0) to a.GetUpperBound(0)")
        For i = a.GetLowerBound(0) To a.GetUpperBound(0)
            Console.WriteLine("a({0}) = {1}", i, a(i))
        Next
        Console.WriteLine ( ) 
        Console.WriteLine( "From 0 to a.Length - 1 ")
        For i = 0 To a.Length - 1
            Console.WriteLine("a({0}) = {1}", i, a(i))
        Next
        Console.WriteLine ( ) 
        Console.WriteLine( "Using For Each i in a")
        For Each i In a
            Console.WriteLine("a() = {0}", i)
        Next
        Console.WriteLine("Recommendation: Use For i To a.Length - 1 instead of For Each: It's faster")
    End Sub
End Class