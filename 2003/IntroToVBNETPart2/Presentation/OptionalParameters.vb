Imports System
Class Test
    Shared Sub MethodWithOptionalParameter(ByVal a As Int32, _
            Optional ByVal b As Double = 1.23R)
        Console.WriteLine("a: {0} b: {1}", a, b)
    End Sub
    Shared Sub Main()
        MethodWithOptionalParameter(12, 5.67)
        MethodWithOptionalParameter(12)
    End Sub
End Class