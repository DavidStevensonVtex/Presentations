Option Strict On

Imports System 

Public Class Dependent
    Private _FirstName As String
    Private _BirthDate As Date
    Public Sub New ( ByVal firstName As String, ByVal birthDate As Date )
        _firstName = firstName
        _BirthDate = birthDate
    End Sub
    Public Property FirstName() As String
        Get
            Return _FirstName
        End Get
        Set(ByVal Value As String)
            _FirstName = Value
        End Set
    End Property
    Public Property BirthDate() As Date
        Get
            Return _BirthDate
        End Get
        Set(ByVal Value As Date)
            If Value < #1/1/1850# Then
                Throw New ArgumentOutOfRangeException("Please verify the birth date for accuracy.")
            End If
            _BirthDate = Value
        End Set
    End Property
    Public Overrides Function ToString () As String
        Return String.Format ( "First name: {0} birth date: {1}", _FirstName, _BirthDate )
    End Function
End Class
