Imports System

Public Class ConvertEnum
	Public Shared Sub Main ( )
		Dim days () As String = New String () { "Sunday", "Monday", "Tuesday", _
			"Wednesday", "Thursday", "Friday", "Saturday" }
		Dim i As Integer
		Dim day As DayOfWeek
		For i = 0 To days.Length - 1
			day = CType( System.Enum.Parse(day.GetType(), days(i) ), DayOfWeek)
			Console.WriteLine ( "{0} {1}", day, CInt(day) )
		Next i
	End Sub
End Class