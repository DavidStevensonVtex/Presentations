Imports System

Public Class Exception2
    Shared Sub Main ( )
        Try
            Dim value1 As Short = 10000
            Dim value2 As Short = 20000
            Dim result As Short 
            result = value1 * value2 
            Console.WriteLine ( "result: {0}", result ) 
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