Imports System
Imports Microsoft.VisualBasic

Public Class WordCount
	Const EOF As Integer = -1
	Shared Sub Main ()
		Dim i, nl, nw, nc As Integer
		Dim c As Char
		Dim inword As Boolean

		inword = False
		nl = 0 : nw = 0 : nc = 0 
		While True
			i = Console.Read ()
			if i = EOF Then Exit While
			c = Chr ( i )
			nc += 1
			If c = vbLf Then nl += 1
			if c = " "C Or c = vbLf Or c = vbTab Then
				inword = False
			Else If inword = False
				inword = True
				nw += 1
			End If
		End While
		Console.WriteLine ( "{0} {1} {2}", nl, nw, nc )
	End Sub
End Class