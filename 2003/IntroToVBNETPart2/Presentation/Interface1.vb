Imports System
Imports System.Collections
Imports Microsoft.VisualBasic

Public Class GroupMember
	Public FirstName As String
	Public LastName As String
	Public ZipCode As Integer
	Public Sub New ( FirstName As String, LastName As String, ZipCode As Integer )
		Me.FirstName = FirstName : Me.LastName = LastName : Me.ZipCode = ZipCode
	End Sub
	Public Class SortByLastName
		Implements IComparer
		Public Overridable Overloads Function Compare ( x As Object, y As Object ) As Integer _
				Implements IComparer.Compare
			Dim first As GroupMember = DirectCast ( x, GroupMember )
			Dim second As GroupMember = DirectCast ( y, GroupMember )
			Return String.Compare ( first.LastName, second.LastName )
		End Function
	End Class
	Public Class SortByFirstName
		Implements IComparer
		Public Overridable Overloads Function Compare ( x As Object, y As Object ) As Integer _
				Implements IComparer.Compare
			Dim first As GroupMember = DirectCast ( x, GroupMember )
			Dim second As GroupMember = DirectCast ( y, GroupMember )
			Return String.Compare ( first.FirstName, second.FirstName )
		End Function
	End Class
	Public Class SortByZipCode
		Implements IComparer
		Public Overridable Overloads Function Compare ( x As Object, y As Object ) As Integer _
				Implements IComparer.Compare
			Dim first As GroupMember = DirectCast ( x, GroupMember )
			Dim second As GroupMember = DirectCast ( y, GroupMember )
			Return first.ZipCode - second.ZipCode
		End Function
	End Class
End Class

Public Class InterfaceTest
	Shared Public Sub DisplayGroupMembers ( ByVal members() As GroupMember )
		Dim i As Integer
		For i = LBound ( members ) To UBound ( members )
			Console.WriteLine ( "{0} {1} {2}", members(i).FirstName, _
				members(i).LastName, members(i).ZipCode )
		Next i
	End Sub
	Shared Public Sub Main ( )
		Dim members () As GroupMember = New GroupMember () { _
			New GroupMember ( "David", "Stevenson", 14467 ), _
			New GroupMember ( "Bob", "Nims", 14472 ), _
			New GroupMember ( "Pat", "Bink", 14526 ), _
			New GroupMember ( "Tom", "Stone", 14534 ) _
		}

		Console.WriteLine ( "************ Sort By Last Name ************" ) 
		Array.Sort ( members, new GroupMember.SortByLastName () )
		DisplayGroupMembers ( members )
		Console.WriteLine ( "************ Sort By Last Name ************" ) 
		Console.WriteLine ( )

		Console.WriteLine ( "************ Sort By First Name ************" ) 
		Array.Sort ( members, new GroupMember.SortByFirstName () )
		DisplayGroupMembers ( members )
		Console.WriteLine ( "************ Sort By First Name ************" ) 
		Console.WriteLine ( )

		Console.WriteLine ( "************ Sort By Zip Code ************" ) 
		Array.Sort ( members, new GroupMember.SortByZipCode () )
		DisplayGroupMembers ( members )
		Console.WriteLine ( "************ Sort By Zip Code ************" ) 
		Console.WriteLine ( )
	End Sub
End Class