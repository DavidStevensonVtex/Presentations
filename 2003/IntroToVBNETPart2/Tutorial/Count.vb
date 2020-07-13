Imports System
Imports Microsoft.VisualBasic 

Public Class Count

	Const EOF As Integer = -1

	Shared Sub Main ()
		Dim i, nwhite, nother As Integer
		Dim c As Char
		Dim ndigit(10) As Integer

		nwhite = 0 : nother = 0
		For i = 0 To 10
			ndigit(i) = 0
		Next i

		While True
			i = Console.Read ()
			If i = EOF Then Exit While
			c = Chr ( i )
			If c >= "0"C And c <= "9"C Then
				ndigit( Asc(c) - Asc("0"C) ) += 1
			Else if c = " "C Or c = vbLf Or c = vbTab Then
				nwhite += 1
			Else
				nother += 1
			End If

		End While
		Console.Write ( "digits =" ) 
		For i = 0 To 9
			Console.Write ( " {0}", ndigit(i) ) 
		Next i
		Console.WriteLine ( vbCrLf & "white space = {0}, other = {1}", _
			nwhite, nother ) 
	End Sub
End Class