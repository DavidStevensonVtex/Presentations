using System ;

public class CopyStandardInputToStandardOutput
{
	const int EOF = -1 ;

	public static void Main ()
	{
		int i ;
		// I took the liberty of shortening this from the Visual Basic.NET version
		while ( ( i = Console.Read () ) != EOF )
			Console.Write ( (char) i ) ;
	}
}
