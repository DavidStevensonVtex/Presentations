Imports System
Public Class Customer
    Public Name As String
End Class
Public Class Vendor
    Public Name As String
End Class
Public Class LateBinding2
    Shared Sub Main ()
        Dim o As Object = New Customer ()
        o.Name = "David"
        Dim o2 As Object = New Vendor ()
        o2.Name = "Acme, Inc." 
        Console.WriteLine ( "vendor name: {0} customer name: {0}", _
            o.Name, o2.Name )
    End Sub
End Class