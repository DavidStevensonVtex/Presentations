using System ;

public class WordCount
{
	const int EOF = -1 ;

	public static void Main ()
	{
		int i, nl, nw, nc ;
		char c ;
		bool inword ;

		inword = false ;
		nl = nw = nc = 0 ;
		while ( ( i = Console.Read () ) != EOF ) 
		{
			c = (char) i ;
			++nc ;
			if ( c == '\n' )
				nl++ ;
			if ( c == ' ' || c == '\n' || c == '\t' )
				inword = false ;
			else if ( ! inword )
			{
				inword = true ;
				++nw ;
			}
		}
		Console.WriteLine ( "{0} {1} {2}", nl, nw, nc ) ;
	}
}