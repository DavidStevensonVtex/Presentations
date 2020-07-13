using System ;

interface IAdd {
	int Add ( int x, int y ) ;
}

class Math : IAdd {
	int IAdd.Add ( int x, int y ) { return x + y ; }
}

public class TestCType {
	static void Main () {
		Object o = new Math () ;
		IAdd iAdd ;
		iAdd = (IAdd) o ;
		int z ;
		z = iAdd.Add ( 5, 6 ) ;
		Console.WriteLine ( "Sum of 5 + 6: {0}", z ) ;
		Math m ;
		// Compiler Error: Cannot implicitly convert type 'object' to 'Math'
		// m = o ;
		m = (Math) o ;
		Console.WriteLine ( "Sum of 5 + 6: {0}", ((IAdd)m).Add ( 5, 6 ) ) ;

		if  ( o  is ICloneable )
			Console.WriteLine ( "o is of type ICloneable" )  ;
		else
			Console.WriteLine ( "o is NOT of type ICloneable" ) ;
		if  ( o is IAdd  )
			Console.WriteLine ( "o is of type IAdd" ) ;
		else
			Console.WriteLine ( "o is NOT of type IAdd" )  ;
		if  ( o is Math ) 
			Console.WriteLine ( "o is of type Math" )  ;
		else
			Console.WriteLine ( "o is NOT of type Math" ) ;

		Math a ;
		IAdd b ;
		a = o as Math ;
		if ( a != null )
		{
			Console.WriteLine ( "Using as: Sum of 5 + 6: {0}", 
				( (IAdd) a).Add ( 5, 6 ) ) ;
		}
		// In this case, the as clause combines a test for an interface and conversion
		// into one statement, which is more efficient and provides better performance.
		b = o as IAdd ;
		if ( b != null )
		{
			Console.WriteLine ( "Sum of 5 + 6: {0}", b.Add ( 5, 6 ) ) ;
		}
	}
}