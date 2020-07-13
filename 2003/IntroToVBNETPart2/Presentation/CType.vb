Option Strict On
Imports System

Interface IAdd
    Function Add ( ByVal x As Integer, ByVal y As Integer ) As Integer
End Interface

Class Math
    Implements IAdd
    Public Function Add ( ByVal x As Integer, ByVal y As Integer ) As Integer _
            Implements IAdd.Add
        Return x + y
    End Function
End Class
Public Class TestCType
    Shared Sub Main ()
        Dim o As Object = New Math ()
        Dim iAdd As IAdd
        ' Option Strict On disallows implicit conversions from 'System.Object' to 'IAdd'
        ' iAdd = o 
        iAdd = CType ( o, IAdd )
        Dim z As Integer
        z = iAdd.Add ( 5, 6 )
        Console.WriteLine ( "Sum of 5 + 6: {0}", z )
        Dim m As Math
        ' Option Strict On disallows implicit conversions from 'System.Object' to 'Math'
        ' m = o
        m = CType ( o, Math )
        Console.WriteLine ( "Sum of 5 + 6: {0}", m.Add ( 5, 6 ) )

        If TypeOf ( o ) Is ICloneable Then
            Console.WriteLine ( "o is of type ICloneable" ) 
        Else 
            Console.WriteLine ( "o is NOT of type ICloneable" ) 
        End If
        If TypeOf ( o ) Is IAdd Then
            Console.WriteLine ( "o is of type IAdd" ) 
        Else
            Console.WriteLine ( "o is NOT of type IAdd" ) 
        End If
        If TypeOf ( o ) Is Math Then
            Console.WriteLine ( "o is of type Math" ) 
        Else
            Console.WriteLine ( "o is NOT of type Math" )
        End If
    End Sub 
End Class