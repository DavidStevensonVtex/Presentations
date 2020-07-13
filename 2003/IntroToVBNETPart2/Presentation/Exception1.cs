using System ;

public class Exception1
{
    public static void Main ()
    {
        short value1 = 10000 ;
        short value2 = 20000 ;
        short result ;
        result = ( short ) ( value1 * value2 ) ;
        Console.WriteLine ( "result: {0}", result ) ;
    }
}