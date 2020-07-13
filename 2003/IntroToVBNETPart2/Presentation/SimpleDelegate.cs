using System ;

public class SimpleDelegateTest
{
    public delegate void SimpleDelegate ( int i, ref int refInt ) ;

    public void SquareArea ( int i, ref int square ) 
    {
        square = i * i ;
    }
    public static void CubicVolume ( int i, ref int cube ) 
    {
        cube = i * i * i ;
    }
    public static void PrintResults ( SimpleDelegate d )
    {
        int i, value = 0 ;
        for ( i = 0 ; i <= 5 ; i++ )
        {
            d ( i, ref value ) ;
            Console.WriteLine("{0} {1}", i, value) ;
        }
    }
    static void Main ()
    {
        SimpleDelegateTest sdt = new SimpleDelegateTest ( ) ;
        // A delegate for an instance method
        SimpleDelegate squared = new SimpleDelegate ( sdt.SquareArea ) ;
        // A delegate for a static method
        SimpleDelegate cubed = new SimpleDelegate ( SimpleDelegateTest.CubicVolume ) ;
        PrintResults ( squared ) ;
        PrintResults ( cubed ) ;
    }
}

