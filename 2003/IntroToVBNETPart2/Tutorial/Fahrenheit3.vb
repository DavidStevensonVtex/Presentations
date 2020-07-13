Imports System

Public Class Fahrenheit3
	Const LOWER As Integer = 0
	Const UPPER As Integer = 300
	Const LOOPSTEP As Integer = 20

	Shared Sub Main ()
		Dim fahr As Integer
		Dim celsius As Single

		For fahr = LOWER To UPPER Step LOOPSTEP
			celsius = CSng ( ( 5.0 / 9.0 ) * ( fahr - 32 ) )
			Console.WriteLine ( "{0,4:F0} {1,6:F1}", fahr, celsius )
		Next fahr
	End Sub
End Class