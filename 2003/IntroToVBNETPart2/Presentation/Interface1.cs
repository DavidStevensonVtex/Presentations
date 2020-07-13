using System ;
using System.Collections ;

public class GroupMember
{
	public string FirstName ;
	public string LastName ;
	public int ZipCode ;
	public GroupMember ( string FirstName, string LastName, int ZipCode )
	{
		this.FirstName = FirstName ; this.LastName = LastName ; this.ZipCode = ZipCode ;
	}
	public class SortByLastName : IComparer
	{
		int IComparer.Compare ( Object x, Object y ) 
		{

			GroupMember first = ( GroupMember ) x ;
			GroupMember second = ( GroupMember ) y ;
			return String.Compare ( first.LastName, second.LastName ) ;
		}
	}
	public class SortByFirstName : IComparer
	{
		int IComparer.Compare ( Object x, Object y ) 
		{

			GroupMember first = ( GroupMember ) x ;
			GroupMember second = ( GroupMember ) y ;
			return String.Compare ( first.FirstName, second.FirstName ) ;
		}
	}
	public class SortByZipCode : IComparer
	{
		int IComparer.Compare ( Object x, Object y ) 
		{

			GroupMember first = ( GroupMember ) x ;
			GroupMember second = ( GroupMember ) y ;
			return first.ZipCode - second.ZipCode ;
		}
	}
}

public class InterfaceTest
{
	public static void DisplayGroupMembers ( GroupMember [] members )
	{
		for ( int i = members.GetLowerBound(0) ; i <= members.GetUpperBound (0) ; i++ )
			Console.WriteLine ( "{0} {1} {2}", members[i].FirstName, 
				members[i].LastName, members[i].ZipCode ) ;
		
	}
	public static void Main ( )
	{
		GroupMember [ ] members  = new GroupMember [] { 
			new GroupMember ( "David", "Stevenson", 14467 ), 
			new GroupMember ( "Bob", "Nims", 14472 ), 
			new GroupMember ( "Pat", "Bink", 14526 ), 
			new GroupMember ( "Tom", "Stone", 14534 ) 
		} ;

		Console.WriteLine ( "************ Sort By Last Name ************" )  ;
		Array.Sort ( members, new GroupMember.SortByLastName () ) ;
		DisplayGroupMembers ( members ) ;
		Console.WriteLine ( "************ Sort By Last Name ************" )  ;
		Console.WriteLine ( ) ;

		Console.WriteLine ( "************ Sort By First Name ************" )  ;
		Array.Sort ( members, new GroupMember.SortByFirstName () ) ;
		DisplayGroupMembers ( members ) ;
		Console.WriteLine ( "************ Sort By First Name ************" )  ;
		Console.WriteLine ( ) ;

		Console.WriteLine ( "************ Sort By Zip Code ************" )  ;
		Array.Sort ( members, new GroupMember.SortByZipCode () ) ;
		DisplayGroupMembers ( members ) ;
		Console.WriteLine ( "************ Sort By Zip Code ************" )  ;
		Console.WriteLine ( ) ;
	}
}