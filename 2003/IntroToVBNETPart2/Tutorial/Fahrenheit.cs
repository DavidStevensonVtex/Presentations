using System ;
/* print Fahrenheit-Celsius table
for f = 0, 20, ..., 300 */

public class Fahrenheit
{
	public static void Main ()
	{
		int lower, upper, step ;
		float fahr, celsius ;

		lower = 0	 ;	/* lower limit of temperature table */
		upper = 300 ;	/* upper limit */
		step = 20 ;		/* step size */

		fahr = (float) lower ;
		while ( fahr <= (float) upper ) 
		{
			celsius = (float) ( ( 5.0 / 9.0 ) * ( fahr - 32.0 ) ) ;
			Console.WriteLine ( "{0,4:F0} {1,6:F1}", fahr, celsius ) ;
			fahr = fahr + step ;
		}
	}	
}