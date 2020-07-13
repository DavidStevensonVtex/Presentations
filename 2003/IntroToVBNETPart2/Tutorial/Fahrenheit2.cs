using System ;

public class Fahrenheit2
{
	public static void Main ()
	{
		int fahr ;
		float celsius ;
		for ( fahr = 0 ; fahr < 300 ; fahr = fahr + 20 )
		{
			celsius = (float) ( 5.0 / 9.0 ) * ( fahr - 32 )  ;
			Console.WriteLine ( "{0,4:F0} {1,6:F1}", fahr, celsius ) ;
		}
	}
}