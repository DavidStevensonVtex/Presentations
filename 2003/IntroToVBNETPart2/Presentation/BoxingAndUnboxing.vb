' Option Strict On	' Note that more problems can occur with this missing...
Imports System

Module BoxingAndUnboxing

    Sub Main()
        Dim value1 As Int32 = 123    ' value1 is a Value Type
        Dim o As Object          ' o is a Reference Type
        o = value1                     ' Box the value1 value type

        Console.WriteLine("After o = value1 (boxing) o: {0} value1: {1}", o, value1 )

        Console.WriteLine ( "value1 = DirectCast(o, Int32)      ' Unbox the reference type" ) 
        value1 = DirectCast(o, Int32)      ' Unbox the reference type

        Console.WriteLine("o: {0} value1: {1}", o, value1)
        Console.WriteLine ( "Set o to 456" )
        o = 456
       Console.WriteLine("o: {0} value1: {1}", o, value1)
        Console.WriteLine ( "Set value1 to 789" )
        value1 = 789
        Console.WriteLine("o: {0} value1: {1}", o, value1)
        Console.WriteLine ( "Did you notice that o and value1 are separate values?" )

    End Sub

End Module
