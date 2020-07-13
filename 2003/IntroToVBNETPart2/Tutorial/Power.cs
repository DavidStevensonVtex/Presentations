using System ;

public class Power
{
	static int power ( int x, int n )
	{
		int i, p ;

		p = 1 ;
		for ( i = 1 ; i <= n ; i++ )
			p = p * x ;
		return p ;
	}

	public static void Main ()
	{
		for ( int i = 0 ; i < 10 ; i++ )
			Console.WriteLine ( "{0} {1} {2}", i, power ( 2, i ), power ( -3, i ) ) ;
	}
}