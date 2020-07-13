using System ;

public class CentralErrorProcessing
{
    public static void ProcessException ( Exception e )
    {
        Console.WriteLine ( ) ;
        Console.WriteLine ( "HelpLink: {0}", e.HelpLink ) ;
        Console.WriteLine ( "InnerException: {0}", e.InnerException ) ;
        Console.WriteLine ( "Message: {0}", e.Message ) ;
        Console.WriteLine ( "Source: {0}", e.Source ) ;
        Console.WriteLine ( "StackTrace: {0}", e.StackTrace ) ;
        Console.WriteLine ( "TargetSite: {0}", e.TargetSite ) ;
    }
}

public class Arithmetic
{
    public void PerformOverflow ( )
    {
        try
        {
            short value1 = 10000 ;
            short value2 = 20000 ;
            short result ;
            result = (short) ( value1 * value2 ) ;
            Console.WriteLine ( "result: {0}", result ) ;
        }
        catch ( Exception e ) {
            CentralErrorProcessing.ProcessException ( e )  ;
        }
    }
    public void PerformDivideByZero ( )
    {
        try
        {
            int zero = 0 ;
            int result ;
            result = ( int ) ( 123 / zero ) ;
            Console.WriteLine ( "result: {0}", result ) ;
        }
        catch ( Exception e ) {
            CentralErrorProcessing.ProcessException ( e )  ;
        }
    }
}

public class Exception4
{
    // Another way to do Central Error Processing
    public static void Main ( )
    {
        Arithmetic myArithmetic = new Arithmetic ( ) ;
        myArithmetic.PerformDivideByZero ( ) ;
        myArithmetic.PerformOverflow ( ) ;
    }
}