Imports System
Public MustInherit Class Employee
    Public Name As String
    Public EmpId As String
    Public Sub New(ByVal Name As String, ByVal EmpId As String)
        Me.Name = Name : Me.EmpId = EmpId
    End Sub
    Public Overridable Readonly Property EmployeeType As String
        Get
            return "Employee" 
        End Get
    End Property
    Public MustOverride Function Pay() As Decimal
End Class

Public Class HourlyEmployee
    Inherits Employee
    Public Hours As Double
    Public HourlyRate As Decimal
    Public Sub New(ByVal Name As String, ByVal EmpId As String, _
            ByVal Hours As Double, ByVal HourlyRate As Decimal)
        MyBase.New(Name, EmpId) : Me.Hours = Hours : Me.HourlyRate = HourlyRate
    End Sub
    Public Overrides Readonly Property EmployeeType As String
        Get
            return "Hourly Employee" 
        End Get
    End Property
    Public Overrides Function Pay() As Decimal
        Return CDec ( Hours ) * HourlyRate
    End Function
End Class

Public Class Manager
    Inherits Employee
    Public Salary As Decimal
    Public Sub New(ByVal Name As String, ByVal EmpId As String, ByVal Salary As Decimal)
        MyBase.New(Name, EmpId) : Me.Salary = Salary
    End Sub
    Public Overrides Readonly Property EmployeeType As String
        Get
            return "Manager" 
        End Get
    End Property
    Public Overrides Function Pay() As Decimal
        Return Salary
    End Function
End Class

Public Class Test
    Shared Sub Main()
        Dim m As Employee = New Manager("David Stevenson", "12345", 1200.00D)
        Dim e1 As Employee = New HourlyEmployee("Jake", "23456", 35.0, 5.50D)
        Console.WriteLine("{0} {1} {2:C}", m.EmployeeType, m.Name, m.Pay( ) ) 
        Console.WriteLine("{0} {1} {2:C}", e1.EmployeeType, e1.Name, e1.Pay( ) )
    End Sub
End Class