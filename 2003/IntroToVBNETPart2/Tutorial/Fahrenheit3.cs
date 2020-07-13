using System ;

public class Fahrenheit3
{
	const int LOWER = 0 ;
	const int UPPER = 300 ;
	const int STEP = 20 ;

	public static void Main ()
	{
		int fahr ;
		float celsius ;
		for ( fahr = LOWER ; fahr < UPPER ; fahr = fahr + STEP )
		{
			celsius = (float) ( 5.0 / 9.0 ) * ( fahr - 32 )  ;
			Console.WriteLine ( "{0,4:F0} {1,6:F1}", fahr, celsius ) ;
		}
	}
}