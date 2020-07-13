using System ;

public class SwapParameters
{
    public static void Swap ( ref Object object1, ref Object object2 )
    {
        Object temp = object1 ;
        object1 = object2 ;
        object2 = temp ;
    }
    public static void Main ()
    {
        // C# acts as if Option Strict On was always on.
        String string1  = "Hello World" ;
        String string2  = "Hello Visual Developers of Upstate New York" ;
        Console.WriteLine( "Before Swap") ;
        Console.WriteLine("string1: {0}  string2: {1}", string1, string2) ;
        Swap(ref string1, ref string2) ;
         Console.WriteLine ( ) ;
        Console.WriteLine( "After Swap") ;
        Console.WriteLine ( "string1: {0}  string2: {1}", string1, string2) ;

        Object object1  = 32 ;
        Object object2  = "Hello Again" ;
        Console.WriteLine ( ) ;
        Console.WriteLine( "Before Swap") ;
        Console.WriteLine("object1: {0}  object2: {1}", object1, object2) ;
        Swap( ref object1, ref object2) ;
        Console.WriteLine ( ) ;
        Console.WriteLine( "After Swap") ;
        Console.WriteLine ( "object1: {0}  object2: {1}", object1, object2) ;

        int value1  = 123 ;
        int value2  = 456 ;
        Console.WriteLine ( ) ;
        Console.WriteLine ( "Before Swap") ;
        Console.WriteLine ( "value1: {0}  value2: {1}", value1, value2 ) ;
        Swap ( ref value1, ref value2 ) ;
        Console.WriteLine ( ) ;
        Console.WriteLine ( "After Swap") ;
        Console.WriteLine ( "value1: {0}  object2: {1}", value1, value2) ;
    }
    // C# acts as if Option Strict On was always on.
    // Overloading Swap for each type is a nuisance, but required to solve the problem.
    public static void Swap ( ref int val1, ref int val2 )
    {
        int temp = val1 ;
        val1 = val2 ;
        val2 = temp ;
    }
    public static void Swap ( ref string val1, ref string val2 )
    {
        string temp = val1 ;
        val1 = val2 ;
        val2 = temp ;
    }
}