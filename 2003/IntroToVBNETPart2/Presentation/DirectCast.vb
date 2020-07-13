' This type is implicitly derived from the System.Object
Class Employee

End Class

Class App
    Public Shared Sub Main()
        ' No cast is needed because New returns an Employee object
        ' and Object is a base type of Employee.
        Dim o As Object = New Employee()

        ' A cast is required because Employee is derived from Object
        ' This cast isn't required if Option Strict is Off
        Dim e As Employee = DirectCast(o, Employee)
        'Dim e As Employee = o        ' Error: Option Strict On disallows implicit conversions from 'System.Object' to 'DirectCast.Employee'
    End Sub
End Class