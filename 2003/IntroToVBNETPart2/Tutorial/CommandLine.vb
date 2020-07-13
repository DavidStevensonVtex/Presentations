Imports System

Public Class CommandLine
	Shared Sub Main ( ByVal Args() As String )
		Console.WriteLine("Number of command line parameters = {0}", args.Length)
		Dim i As Integer
		For i = 0 To args.Length - 1
			Console.WriteLine ( "Args({0}) = {1}", i, Args(i) )
		Next i
	End Sub
End Class