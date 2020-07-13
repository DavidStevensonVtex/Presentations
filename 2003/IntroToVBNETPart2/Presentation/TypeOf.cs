using System ;

public class TypeOfTest
{
	public class Car { }

	public static void Main ( )
	{
		Object o = new Object ( ) ;
		Car c = new Car ( ) ;
		bool b1 = (  o is System.Object ) ;
		bool b2 = ( o is Car ) ;

        Console.WriteLine("b1: {0}  b2: {1}  o.GetType ().Name: {2}", b1, b2, o.GetType().Name ) ;
        // The TypeOf…Is operator returns True if an object is of a specific type, 
        // or is derived from a specific type.
        o = c ;
		b1 = (  o is System.Object ) ;
		b2 = ( o is Car ) ;
		Console.WriteLine("b1: {0}  b2: {1}  o.GetType ().Name: {2}", b1, b2, o.GetType().Name  ) ;

        // Performance issue: CLR is checking the object's type twice.
        // C# offers a better performance alternative.
        // e = o as Employee
        // if ( e != null ) {
        //           // Do some work.
        // }
        if ( o is Car ) 
            c = (Car) o ;
	}
}