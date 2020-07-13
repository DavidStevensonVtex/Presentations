Imports System

Public Class CentralErrorProcessing
    Shared Public Sub ProcessException ( ByVal e As Exception )
        Console.WriteLine ( ) 
        Console.WriteLine ( "HelpLink: {0}", e.HelpLink )
        Console.WriteLine ( "InnerException: {0}", e.InnerException )
        Console.WriteLine ( "Message: {0}", e.Message )
        Console.WriteLine ( "Source: {0}", e.Source )
        Console.WriteLine ( "StackTrace: {0}", e.StackTrace )
        Console.WriteLine ( "TargetSite: {0}", e.TargetSite )
    End Sub
End Class

Public Class Arithmetic
    
    Public Sub PerformOverflow ( )
        Try
            Dim value1 As Short = 10000
            Dim value2 As Short = 20000
            Dim result As Short 
            result = value1 * value2 
            Console.WriteLine ( "result: {0}", result ) 
        Catch e As Exception
            CentralErrorProcessing.ProcessException ( e ) 
        End Try
    End Sub
    Public Sub PerformDivideByZero ( )
        Try
            Dim zero As Integer = 0
            Dim result As Integer 
            result = CInt ( 123 / zero )
            Console.WriteLine ( "result: {0}", result )
        Catch e As Exception
            CentralErrorProcessing.ProcessException ( e ) 
        End Try
    End Sub
    
End Class

Public Class Exception4
    ' Another way to do Central Error Processing
    Shared Sub Main ( )
        Dim myArithmetic As New Arithmetic ( )
        myArithmetic.PerformDivideByZero ( )
        myArithmetic.PerformOverflow ( )
    End Sub
End Class