Imports System 

Public Class Power
	Shared Function power ( ByVal x As Integer, ByVal n As Integer ) As Integer
		Dim i, p As Integer

		p = 1
		For i = 1 To n
			p = p * x
		Next i
		Return p
	End Function
	Shared Sub Main ()
		Dim i As Integer
		For i = 0 To 9 
			Console.WriteLine ( "{0} {1} {2}", i, power ( 2, i ), power ( -3, i ) )
		Next i
	End Sub
End Class