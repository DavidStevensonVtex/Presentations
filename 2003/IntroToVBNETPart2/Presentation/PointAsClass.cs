using System ;

public class Point
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
        Console.WriteLine("({0}, {1})", p1.x, p1.x) ;
        Console.WriteLine("({0}, {1})", p2.x, p2.x) ;
        Console.WriteLine("p1 points to p2: {0}", Object.ReferenceEquals(p1, p2)) ;
        p2.x = 50 ;
        Console.WriteLine () ;
        Console.WriteLine ( "p2.x = 50" ) ;
        Console.WriteLine("({0}, {1})", p1.x, p1.y) ;
        Console.WriteLine("({0}, {1})", p2.x, p2.y) ;
    }
}
