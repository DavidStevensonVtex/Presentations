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
			switch ( c )
			{
			case '0':
			case '1':
			case '2':
			case '3':
			case '4':
			case '5':
			case '6':
			case '7':
			case '8':
			case '9':
				ndigit [ c - '0' ]++ ;
				break ;
			case ' ':
			case '\n':
			case '\t':
				nwhite++ ;
				break ;
			default:
				nother++ ;
				break ;
			}
		}
		Console.Write ( "digits =" ) ;
		for ( i = 0 ; i < 10 ; ++i )
			Console.Write ( " {0}", ndigit[i] ) ;
		Console.WriteLine ( "\nwhite space = {0}, other = {1}", 
			nwhite, nother ) ;
	}
}