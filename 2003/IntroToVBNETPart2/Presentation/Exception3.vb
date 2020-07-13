Imports System

Public Class Arithmetic
    Public Sub PerformOverflow ( )
        Dim value1 As Short = 10000
        Dim value2 As Short = 20000
        Dim result As Short 
        result = value1 * value2 
        Console.WriteLine ( "result: {0}", result ) 
    End Sub
    Public Sub PerformDivideByZero ( )
        Dim zero As Integer = 0
        Dim result As Integer 
        result = CInt ( 123 / zero )
        Console.WriteLine ( "result: {0}", result )
    End Sub
    
End Class

Public Class Exception3
    ' One way to do Central Error Processing
    ' Catch all errors in Main subroutine
    Shared Sub Main ( )
        Try
            Dim myArithmetic As New Arithmetic ( )
            myArithmetic.PerformDivideByZero ( )
            myArithmetic.PerformOverflow ( )
        Catch e As OverflowException
            Console.WriteLine ( "An OverflowException occurred" )
            Console.WriteLine ( "HelpLink: {0}", e.HelpLink )
            Console.WriteLine ( "InnerException: {0}", e.InnerException )
            Console.WriteLine ( "Message: {0}", e.Message )
            Console.WriteLine ( "Source: {0}", e.Source )
            Console.WriteLine ( "StackTrace: {0}", e.StackTrace )
            Console.WriteLine ( "TargetSite: {0}", e.TargetSite )
        Catch e As Exception
            Console.WriteLine ( "Exception occurred: {0}", e.ToString () )
        Finally
            Console.WriteLine ( "A Finally clause is always executed, exception or no exception" )
        End Try
    End Sub
End Class