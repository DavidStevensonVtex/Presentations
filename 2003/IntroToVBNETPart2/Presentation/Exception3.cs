using System ;

public class Arithmetic
{
    public void PerformOverflow ( )
    {
        short value1 = 10000 ;
        short value2 = 20000 ;
        short result ;
        result = (short) ( value1 * value2 ) ; 
        Console.WriteLine ( "result: {0}", result ) ;
    }
    public void PerformDivideByZero ( )
    {
        int zero = 0 ;
        int result ;
        result = 123 / zero ;
        Console.WriteLine ( "result: {0}", result ) ;
    }    
}

public class Exception3
{
    // One way to do Central Error Processing
    // Catch all errors in Main subroutine
    public static void Main ( )
    {
        try
        {
            Arithmetic myArithmetic = new Arithmetic ( ) ;
            myArithmetic.PerformDivideByZero ( ) ;
            myArithmetic.PerformOverflow ( ) ;
        }
        catch ( OverflowException e )
        {
            Console.WriteLine ( "An OverflowException occurred" ) ;
            Console.WriteLine ( "HelpLink: {0}", e.HelpLink ) ;
            Console.WriteLine ( "InnerException: {0}", e.InnerException ) ;
            Console.WriteLine ( "Message: {0}", e.Message ) ;
            Console.WriteLine ( "Source: {0}", e.Source ) ;
            Console.WriteLine ( "StackTrace: {0}", e.StackTrace ) ;
            Console.WriteLine ( "TargetSite: {0}", e.TargetSite ) ;
        }
        catch ( Exception e )
        {
            Console.WriteLine ( "Exception occurred: {0}", e.ToString () ) ;
        }
        finally
        {
            Console.WriteLine ( "A Finally clause is always executed, exception or no exception" ) ;
        }
    }
}