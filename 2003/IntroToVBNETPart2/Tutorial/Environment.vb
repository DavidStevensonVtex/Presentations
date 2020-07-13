Imports System
Imports System.Collections
Imports Microsoft.VisualBasic

Public Class DisplayEnvironment

	Shared Sub Main ()
		Dim env As IDictionary = Environment.GetEnvironmentVariables() 
		Dim e As IDictionaryEnumerator = env.GetEnumerator () 
		While e.MoveNext ()
			Dim entry As DictionaryEntry = DirectCast ( e.Current, DictionaryEntry )
			Console.WriteLine ( "{0}{1}{2}", entry.Key, vbTab, entry.Value )
		End While
	End Sub
End Class