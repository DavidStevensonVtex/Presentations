using System ;

public struct Point
{
    public int x ;
    public int y ;
    public Point ( int x, int y )
    {
        this.x = x ; this.y = y ;
    }
}

class Test
{
    public static void Main ()
    {
        Point p1 = new Point ( 10, 20 ) ;
        Point p2 = new Point ( 30, 40 ) ;
        p1 = p2 ;
        Console.WriteLine("p1: ({0}, {1})", p1.x, p1.y) ;
        Console.WriteLine("p2: ({0}, {1})", p2.x, p2.y) ;
        p2.x = 50 ;
        Console.WriteLine () ;
        Console.WriteLine ( "p2.x = 50" ) ;
        Console.WriteLine("p1: ({0}, {1})", p1.x, p1.y) ;
        Console.WriteLine("p2: ({0}, {1})", p2.x, p2.y) ;
    }
}