Option Strict On
Imports System 
Imports Microsoft.VisualBasic

Class OverloadedConstructors
    Public intValue As Int32 = 123
    Public stringValue As String = "Ralph"
    Public pi As Double = 3.14159
    Public created As DateTime

    Public Sub New( ByVal created As Date, ByVal intValue As Int32, ByVal stringValue As String)
        Me.created = created : Me.intValue = intValue : Me.stringValue = stringValue
    End Sub
    Public Sub New()
        MyBase.New ()
        created = Now()
    End Sub
    Public Sub New(ByVal intValue As Int32)
        Me.New()    ' If a class derives from this class, call derived class's New constructor
        Me.intValue = intValue
    End Sub
    Public Sub New(ByVal intValue As Int32, ByVal stringValue As String)
        MyClass.New()     ' Even if a class derives from this class, call this class's New constructor.
        Me.intValue = intValue : Me.stringValue = stringValue
    End Sub
    Public Overrides Function ToString () As String
        Return String.Format ( "intValue: {0} stringValue: {1} pi: {2} created: {3}", _
	intValue, stringValue, pi, created ) 
    End Function
End Class

Public Class TestOverloadedConstructors
    Shared Sub Main ()
         Dim oc1 As OverloadedConstructors = New OverloadedConstructors ( 456 )
         Dim oc2 As OverloadedConstructors = New OverloadedConstructors ( 456, "Sally" )
         Dim oc3 As OverloadedConstructors = New OverloadedConstructors ( )
         Console.WriteLine ( oc1 )
         Console.WriteLine ( oc2 )
         Console.WriteLine ( oc3 )
    End Sub
End Class