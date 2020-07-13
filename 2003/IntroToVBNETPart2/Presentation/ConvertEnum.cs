using System ;

public class ConvertEnum
{
 public static void Main ( )
 {
  string [] days = new string [] { "Sunday", "Monday", "Tuesday", 
   "Wednesday", "Thursday", "Friday", "Saturday" } ;
  int i ;
  DayOfWeek day = DayOfWeek.Monday ; // Initialize, otherwise compiler complains about uninitialized variable
  for ( i = 0 ; i <= days.Length - 1 ; i++ )
  {
   day = (DayOfWeek)  System.Enum.Parse ( day.GetType(), days [ i ] ) ;
   Console.WriteLine ( "{0} {1}", day, (int) day ) ;
  }
 }
}