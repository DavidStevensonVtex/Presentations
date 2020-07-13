Imports System

Public Class LeapYear
	Shared Function isLeapYear ( ByVal year As Integer) As Boolean
		Dim leapYear As Boolean = False
		if year Mod 4 = 0  And year Mod 100 <> 0 Or year Mod 400 = 0 Then
			leapYear = True
		End If
		Return leapYear
	End Function

	Shared Sub Main ()
		Dim year As Integer
		For year = 1990 To 2010 
			Console.WriteLine ( "{0}   {1}", year, isLeapYear ( year ) )
		Next year
	End Sub
End Class