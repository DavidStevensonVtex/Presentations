Imports System
Imports Microsoft.VisualBasic

Public Class CopyStandardInputToStandardOutput
	Shared Sub Main ()
		Dim i As Integer
		While True
			i = Console.Read()
			If i = - 1 Then
				Exit While
			End If
			' Chr(i) = Microsoft.VisualBasic.Chr(i)
			Console.Write ( Chr(i) )
		End While
	End Sub
End Class