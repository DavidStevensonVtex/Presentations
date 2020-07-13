using System ;

public class LeapYear
{
	static bool isLeapYear ( int year )
	{
		bool leapYear = false ;
		if ( year % 4 == 0 && year % 100 != 0 || year % 400 == 0 )
			leapYear = true ;
		return leapYear ;
	}

	public static void Main ()
	{
		for ( int year = 1990 ; year <= 2010 ; year++ )
			Console.WriteLine ( "{0}   {1}", year, isLeapYear ( year ) ) ;
	}
}