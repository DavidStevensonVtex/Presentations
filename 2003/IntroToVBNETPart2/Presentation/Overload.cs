using System ;

public class DisplayIt
{
    public void Display ( char theChar )
    {
        Console.WriteLine ( "Display: theChar      : {0}", theChar ) ;
    }
    public void Display ( int theInteger )
    {
        Console.WriteLine ( "Display: theInteger   : {0}", theInteger ) ;
    }
    public void Display ( string theString )
    {
        Console.WriteLine ( "Display: theString    : {0}", theString ) ;
    }
}

public class Test
{
    static void Main ()
    {
        DisplayIt d = new DisplayIt () ;
        d.Display ( (char) 86 ) ;
        d.Display ( 'B' ) ;
        d.Display ( '.' ) ;
        d.Display ( "NET" ) ;
        d.Display ( 12345 ) ;
    }
 }