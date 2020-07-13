Imports System

Public Class Fahrenheit2
	Shared Sub Main ()
		Dim fahr As Integer
		Dim celsius As Single

		For fahr = 0 To 300 Step 20
			celsius = CSng ( ( 5.0 / 9.0 ) * ( fahr - 32 ) )
			Console.WriteLine ( "{0,4:F0} {1,6:F1}", fahr, celsius )
		Next fahr
	End Sub
End Class