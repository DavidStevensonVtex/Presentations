Imports System
Imports Microsoft.VisualBasic

Public Class BaseClassAssembly1
	' Data Members
	Private privateInt As Integer = 12
	Protected protectedInt As Integer = 34
	Public publicInt As Integer = 56

	Friend friendInt As Integer = 78
	Protected Friend protectedFriendInt As Integer = 90

	' Properties
	Private Readonly Property PrivateProperty As String
		Get
			Return "private properties are only accessible within the class"
		End Get
	End Property
	Protected Readonly Property ProtectedProperty As String
		Get
			Return "protected properties are only accessible by derived classes"
		End Get
	End Property
	Public Readonly Property PublicProperty As String
		Get
			Return "public properties are accessible by anyone" & vbCrLf & vbTab & _
				"(Show PrivateProperty can be accessed by method inside class= " _
				& Me.PrivateProperty & ")" & vbCrLf & vbTab & _
				"(Show ProtectedProperty can be accessed by method inside class= " _
				& Me.ProtectedProperty & ")" 
		End Get
	End Property
	Friend Readonly Property FriendProperty As String
		Get
			Return "friend properties are accessible by any class within the same assembly"
		End Get
	End Property
	Protected Friend Readonly Property ProtectedFriendProperty As String
		' Protected Friend: Access is limited to the current project or types derived from the containing class.
		Get
			Return "Entities declared with the Protected Friend modifiers have the union of Protected and Friend access"
		End Get
	End Property

	' Functions and/or Subroutines
	Private Function PrivateMethod () As String
		Return "Private Methods are accessible only within this class"
	End Function
	Protected Function ProtectedMethod () As String
		Return "Protected Methods are accessible only by derived classes"
	End Function
	Public Function PublicMethod () As String
		Return "Public Methods are accessible by anyone"
	End Function
	Friend Function FriendMethod () As String
		Return "Friend Methods are accessible by any class in the same assembly"
	End Function

	Protected Friend Function ProtectedFriendMethod () As String
		Return "Entities declared with the Protected Friend modifiers have the union of Protected and Friend access"
	End Function

End Class

Public Class Assembly1Test
	Shared Sub Main ()
		Dim assembly1 As New BaseClassAssembly1 ( )

		Console.WriteLine ( )
		Console.WriteLine ( "Try accessing private types within the BaseClassAssembly1 class" )
		' Compiler error: BaseClassAssembly1.privateInt' is not accessible in this context because it is 'Private'.
		' Console.WriteLine ( "assembly1.PrivateInt: {0}", assembly1.PrivateInt )
		' Compiler error: BaseClassAssembly1.Private ReadOnly Property PrivateProperty() As String' 
		' is not accessible in this context because it is 'Private'.
		' Console.WriteLine ( "assembly1.PrivateProperty: {0}", assembly1.PrivateProperty )

		Console.WriteLine ( )
		Console.WriteLine ( "Try accessing protected types within the BaseClassAssembly1 class" )
		' Compiler error:  'BaseClassAssembly1.protectedInt' is not accessible in this context because it is 'Protected'.
		' Console.WriteLine ( "assembly1.ProtectedInt: {0}", assembly1.ProtectedInt ) 
		' Compiler error: 'BaseClassAssembly1.Protected ReadOnly Property ProtectedProperty() As String' is not accessible in this context because it is 'Protected'.
		' Console.WriteLine ( "assembly1.ProtectedProperty: {0}", assembly1.ProtectedProperty )
		' 'BaseClassAssembly1.Protected Function ProtectedMethod() As String' is not accessible in this context because it is 'Protected'.
		' Console.WriteLine ( "assembly1.ProtectedMethod: {0}", assembly1.ProtectedMethod )

		Console.WriteLine ( )
		Console.WriteLine ( "Try accessing public types within the BaseClassAssembly1" ) 
		Console.WriteLine ( "assembly1.publicInt: {0}", assembly1.publicInt ) 
		Console.WriteLine ( "assembly1.PublicProperty: {0}", assembly1.PublicProperty )
		Console.WriteLine ( "assembly1.PublicMethod: {0}", assembly1.PublicMethod ) 

		Console.WriteLine ( )
		Console.WriteLine ( "Try accessing Friend types within the BaseClassAssembly1" ) 
		Console.WriteLine ( "assembly1.friendInt: {0}", assembly1.friendInt ) 
		Console.WriteLine ( "assembly1.FriendProperty: {0}", assembly1.FriendProperty )
		Console.WriteLine ( "assembly1.FriendMethod: {0}", assembly1.FriendMethod ) 

		Console.WriteLine ( )
		Console.WriteLine ( "Try accessing Protected Friend types within the BaseClassAssembly1" ) 
		Console.WriteLine ( "assembly1.protectedFriendInt: {0}", assembly1.protectedFriendInt ) 
		Console.WriteLine ( "assembly1.ProtectedFriendProperty: {0}", assembly1.ProtectedFriendProperty )
		Console.WriteLine ( "assembly1.ProtectedFriendMethod: {0}", assembly1.ProtectedFriendMethod ) 


	End Sub
End Class