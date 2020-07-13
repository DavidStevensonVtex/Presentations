Imports System
Imports System.Text

Class VariableNumberOfParameters
    Shared Function Concatenate(ByVal ParamArray strings() As String) As String
        Dim result As StringBuilder = New StringBuilder()
        Dim oneString As String
        For Each oneString In strings
            result.Append(oneString)
            result.Append(" "c)
        Next
        Return result.ToString()
    End Function
    Shared Sub Main()
        Console.WriteLine("{0}", _
            Concatenate("Hello", "Visual", "Developers", "Of", "Upstate", "New York"))
    End Sub
End Class