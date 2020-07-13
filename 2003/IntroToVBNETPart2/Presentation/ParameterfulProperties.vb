Option Strict On

Imports System
Imports System.Collections

Public Class DependentCollection
    Private collection As ArrayList
    Private lookup As Hashtable

    Public Sub New()
        collection = New ArrayList()
        lookup = New Hashtable()
    End Sub

    Default Public Overridable Property Item(ByVal index As Int32) As Dependent
        Get
            Return DirectCast(collection.Item(index), Dependent)
        End Get
        Set(ByVal Value As Dependent)
            collection.Item(index) = Value
            lookup.Add(Value.FirstName, Value)
        End Set
    End Property

    Default Public Overridable Property Item(ByVal firstName As String) As Dependent
        Get
            Return DirectCast(lookup.Item(firstName), Dependent)
        End Get
        Set(ByVal Value As Dependent)
            Dim dependent As Dependent = DirectCast(lookup.Item(firstName), Dependent)
            If dependent Is Nothing Then
                Add(Value)
            Else
                Dim i As Integer
                For i = 0 To collection.Count
                    dependent = DirectCast ( collection.Item(i), Dependent )
                    If dependent.FirstName = Value.FirstName Then
                        collection.RemoveAt(i)
                        Add(Value)
                    End If
                Next
            End If
        End Set
    End Property

    Public Sub Add(ByVal Value As Dependent)
        collection.Add(Value)
        lookup.Add(Value.FirstName, Value)
    End Sub

    Public ReadOnly Property Count() As Int32
        Get
            Return collection.Count()
        End Get
    End Property

    Public Sub Delete(ByVal Index As Int32)
        Dim dependent As Dependent
        dependent = DirectCast ( collection.Item(Index), Dependent )
        If Not dependent Is Nothing Then
            lookup.Remove(dependent.FirstName)
            collection.RemoveAt(Index)
        End If
    End Sub

    Public Sub Delete(ByVal firstName As String)
        Dim dependent As Dependent
        Dim i As Integer
        For i = 0 To collection.Count
            dependent = DirectCast ( collection.Item(i), Dependent )
            If dependent.FirstName = firstName Then
                lookup.Remove(firstName)
                collection.RemoveAt(i)
            End If
        Next
    End Sub
End Class

Public Class Test
    Shared Sub Main ()
        Dim dc As New DependentCollection ()
        dc.Add ( new Dependent ( "Nathan", #1/20/1986# ) )
        dc.Add ( new Dependent ( "Daryl", #5/29/1988# ) )
        dc.Add ( new Dependent ( "Joshua", #2/17/1992# ) )
        Dim i As Integer
        For i = 0 To dc.Count () - 1
             Console.WriteLine ( dc.Item ( i ) )
        Next i
        Dim d As Dependent
        d = dc.Item ( "Nathan" )
        Console.WriteLine ( "Nathan: {0}", d )
    End Sub
End Class
