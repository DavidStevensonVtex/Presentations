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
			Select Case c
			Case "0"C To "9"C
				ndigit ( Asc(c) - Asc("0"C) ) += 1 
			Case " "C, ControlChars.Lf, ControlChars.Tab
				nwhite += 1 
			Case Else
				nother += 1 
			End Select
		End While
		Console.Write ( "digits =" ) 
		For i = 0 To 9
			Console.Write ( " {0}", ndigit(i) ) 
		Next i
		Console.WriteLine ( vbCrLf & "white space = {0}, other = {1}", _
			nwhite, nother ) 
	End Sub
End Class