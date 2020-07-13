using System ;

public class Count
{
	const int EOF = -1 ;

	public static void Main ()
	{
		int i, nwhite, nother ;
		char c ;
		int [] ndigit = new int [10] ;

		nwhite = nother = 0 ;
		for ( i = 0 ; i < 10 ; ++i )
			ndigit[i] = 0 ;

		while ( ( i = Console.Read () ) != EOF )
		{
			c = (char) i ;
			if ( c >= '0' && ( c <= '9' ) )
				++ndigit [c - '0' ] ;
			else if ( c == ' ' || c == '\n' || c == '\t' )
				++nwhite ;
			else
				++nother ;
		}
		Console.Write ( "digits =" ) ;
		for ( i = 0 ; i < 10 ; ++i )
			Console.Write ( " {0}", ndigit[i] ) ;
		Console.WriteLine ( "\nwhite space = {0}, other = {1}", 
			nwhite, nother ) ;
	}
}