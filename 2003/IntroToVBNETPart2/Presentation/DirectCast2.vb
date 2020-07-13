Option Strict On
Imports System
Class Employee

End Class

Class Manager
    Inherits Employee
End Class

Class App
    Public Shared Sub Main()
        ' Construct a Manager object and pass it to PromoteEmployee
        ' A Manager IS-A Object: PromoteEmployee runs OK.
        Dim m As New Manager()
        PromoteEmployee(m)

        ' Construct a DateTime object and pass it to PromoteEmployee
        ' A DateTime is NOT derived from Employee:  PromoteEmployee
        ' throws a System.InvalidCastException exception
        Dim newYears As DateTime = New DateTime(2001, 1, 1)
        PromoteEmployee(newYears)
    End Sub

    Public Shared Sub PromoteEmployee(ByVal o As Object)
        ' At this point, the compiler doesn't know exactly what 
        ' type of object o refers to. So the compiler allows the
        ' code to compile. However, at run time, the CLR does know 
        ' what type o refers to (each time the cast is performed) and
        ' it checks whether the object's type is Employee or any type
        ' that is derived from Employee
        Dim e As Employee = DirectCast(o, Employee)

    End Sub
End Class