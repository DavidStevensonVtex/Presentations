using System ;
using System.Collections ;

public class Arrays1
{
	public static void Main ()
	{
		int [] myInts = new int[5 + 1] ;
		int [] yourInts = new int [] {123, 456, 789, 12, 34, 56} ;
		int [,] myMatrix = new int [ 10 + 1, 20 + 1 ] ;
		int [,] daysInMonth = new int [,] {
			{31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}, 
			{31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31} 
		} ;
		int [,,] myCube = new int [5 + 1, 10 + 1, 15 + 1 ] ;
		myInts[0] = 123 ;
		myInts[5] = 567 ;
		DisplayInts ( yourInts ) ;

		// Demonstrate converting ArrayList to an Array
		Console.WriteLine ( ) ;
		Console.WriteLine( "Converting ArrayList to an Array") ;
		ArrayList myStringList = new ArrayList ( 5 ) ;
		myStringList.Add("Dave") ;
		myStringList.Add("Bob") ;
		myStringList.Add("Sally") ;
		string [] myStrings ;
		// This is the trick. A one-line conversion from ArrayList to an Array
		myStrings = (string[]) myStringList.ToArray ( Type.GetType ( "System.String" ) ) ;
		myStrings = (string[]) myStringList.ToArray ( "".GetType ( ) ) ;
		foreach ( string myString in myStrings )
			Console.WriteLine ( "{0}", myString ) ;
	}

	static void DisplayInts ( Int32 [] a )
	{
		Int32 i ;
		Console.WriteLine ( ) ;
		Console.WriteLine( "From a.GetLowerBound(0) to a.GetUpperBound(0)") ;
		for ( i = a.GetLowerBound(0) ; i <= a.GetUpperBound (0) ; i++ )
			Console.WriteLine("a[{0}] = {1}", i, a[i] ) ;
		Console.WriteLine () ;
		for ( i = 0 ; i <= a.Length - 1 ; i++ )
			Console.WriteLine("a[{0}] = {1}", i, a[i] ) ;
		Console.WriteLine () ;
		foreach ( Int32 item in a )
			Console.WriteLine("a[] = {0}", item )  ;
		Console.WriteLine("Recommendation: Use For i To a.Length - 1 instead of For Each: It's faster") ;
	}
}