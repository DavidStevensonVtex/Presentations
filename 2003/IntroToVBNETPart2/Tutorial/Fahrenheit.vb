Imports System 
' print Fahrenheit-Celsius table
' for f = 0, 20, ..., 300

Public Class Fahrenheit
	Shared Sub Main ()
		Dim lower, upper, loopstep As Integer
		Dim fahr, celsius As Single

		lower = 0		' lower limit of temperature table
		upper = 300 	' upper limit
		loopstep = 20 	' step size
		fahr = lower 
		while ( fahr <= upper ) 
			celsius = CSng ( ( 5.0 / 9.0 ) * ( fahr - 32.0 ) )
			Console.WriteLine ( "{0,4:F0} {1,6:F1}", fahr, celsius )
			fahr = fahr + loopstep
		end while
	End Sub
	
End Class