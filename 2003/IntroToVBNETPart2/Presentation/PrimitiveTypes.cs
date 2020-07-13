using System ;

class PrimitiveTypes
{
    public static void Main ()
    {
        // Boolean, Byte, Short, Integer, Long, Single, Double
        // Decimal, Date (DateTime), Char, String

        // Boolean Structure: System.Boolean
        bool b = true ;
        Console.WriteLine() ;
        Console.WriteLine("Boolean Structure (Value Type) (System.Boolean)") ;
        Console.WriteLine("True: {0} False: {1} Boolean.FalseString: {2} Boolean.TrueString: {3} Boolean.Parse (\"true\"): {4}", 
            true, false, Boolean.FalseString, Boolean.TrueString, Boolean.Parse("true")) ;
        if ( b )
            Console.WriteLine("b: {0}", b) ;

        // Byte Structure = System.Byte
        byte myByte = (byte) 123 ;
        myByte = (byte) ( myByte + 2 ) ;
        Console.WriteLine() ;
        Console.WriteLine("Byte  Structure (Value Type) (System.Byte)") ;
        Console.WriteLine("Byte.MinValue: {0} Byte.MaxValue: {1}", Byte.MinValue, Byte.MaxValue) ;

        // Short Structure = System.Short
        short myShort = (short) 123 ;
        myShort = (short) ( myShort + 2 ) ;
        Console.WriteLine() ;
        Console.WriteLine("Short Structure (Value Type) (System.Int16)") ;
        Console.WriteLine("Short.MinValue: {0} Short.MaxValue: {1}", Int16.MinValue, Int16.MaxValue) ;

        // Integer Structure = System.Int32 
        int myInt = 123 ;
        myInt = myInt + 2  ;
        Console.WriteLine() ;
        Console.WriteLine("Integer Structure (Value Type) (System.Int32)") ;
        Console.WriteLine("Int32.MinValue: {0} Int32.MaxValue: {1}", Int32.MinValue, Int32.MaxValue) ;

        // Long Structure = System.Int64
        long myLong = 123L ;
        myLong = myLong + 2 ;
        Console.WriteLine() ;
        Console.WriteLine("long Structure (Value Type) (System.Int64)") ;
        Console.WriteLine("Int64.MinValue: {0} Int64.MaxValue: {1}", Int64.MinValue, Int64.MaxValue) ;

        // Single Structure = System.Single
        float mySingle = 1.23F ;
        mySingle = mySingle + 2.34F ;
        Console.WriteLine() ;
        Console.WriteLine("Single Structure (Value Type) (System.Single)") ;
        Console.WriteLine("Single: MinValue: {0:G} MaxValue: {1:G} Epsilon: {2:G}", 
            Single.MinValue, Single.MaxValue, Single.Epsilon) ;
        Console.WriteLine("Single: NegativeInfinity: {0:G} PositiveInfinity: {1:G}: NaN: {2:G}", 
            Single.NegativeInfinity, Single.PositiveInfinity, Single.NaN) ;

        // Double Structure = System.Single
        double myDouble = 1.23d ;
        myDouble = myDouble + 2.34d ;
        Console.WriteLine() ;
        Console.WriteLine("Double Structure (Value Type) (System.Double)") ;
        Console.WriteLine("Double: MinValue: {0:G} MaxValue: {1:G} Epsilon: {2:G} ", 
            Double.MinValue, Double.MaxValue, Double.Epsilon) ;
        Console.WriteLine("NegativeInfinity: {0:G} PositiveInfinity: {1:G}: NaN: {2:G}", 
            Double.NegativeInfinity, Double.PositiveInfinity, Double.NaN) ;

        Decimal myDecimal = 1234.56M ;
        myDecimal = myDecimal + 6543.21M ;
        Console.WriteLine() ;
        Console.WriteLine("Decimal Structure (Value Type) (System.Decimal)") ;
        Console.WriteLine("Decimal: MinValue {0:C} MaxValue: {1:C}", 
            Decimal.MinValue, Decimal.MaxValue) ;
        Console.WriteLine("Decimal: One: {0:C} Zero: {1:C} MinusOne: {2:C}", 
            Decimal.One, Decimal.Zero, Decimal.MinusOne) ;
        Console.WriteLine("myDecimal: {0:#,###.00} {0:C}", myDecimal) ;

        // Date Structure = System.DateTime
        DateTime dteNow = DateTime.Now ;
        DateTime dteToday = DateTime.Today ;
        DateTime dteGMT = DateTime.UtcNow ;
        Console.WriteLine() ;
        Console.WriteLine("Date Structure (Value Type) (System.DateTime)") ;
        Console.WriteLine("Today: {0:00}/{1:00}/{2:00}", dteToday.Month, dteToday.Day, dteToday.Year % 100) ;
        Console.WriteLine("dteNow: {0}", dteNow) ;
        Console.WriteLine("dteToday: {0}", dteToday) ;
        Console.WriteLine("dteGMT: {0}", dteGMT) ;

        // Char Structure Value Type (System.Char)
        Console.WriteLine() ;
        Console.WriteLine("Char Structure (Value Type) (System.Char)") ;
        char chrLetterA = 'a' ;
        char chrAscA = (char) 97 ;
        Console.WriteLine("{0}, {1}", chrLetterA, chrAscA) ;
        if ( Char.IsDigit(chrLetterA) )
            Console.WriteLine("{0} is a digit", chrLetterA) ;
        else if ( Char.IsLetter(chrLetterA) )
            Console.WriteLine("{0} is a letter", chrLetterA) ;
        else if ( Char.IsLetterOrDigit(chrLetterA) ) 
            Console.WriteLine("{0} is a letter or digit", chrLetterA) ;
        else if ( Char.IsLower(chrLetterA) )
            Console.WriteLine("{0} is a lower case letter", chrLetterA) ;
        

        // String Reference Type (System.String)
        Console.WriteLine() ;
        Console.WriteLine("String Class (Reference Type) (System.String)") ;
        string s1 = "hello" ;
        string s2 = "hello" ;
        string s3 = "he" ;
        s3 = s3 + "llo" ;
        // The common language runtime automatically maintains a table, 
        // called the "intern pool", which contains a single instance of each unique 
        // literal string constant declared in a program, 
        // as well as any unique instance of String you add programmatically.

        Console.WriteLine("s1: {0} s2: {1} s1 = s2: {2} Object.ReferenceEquals (s1,s2): {3} String.Equals (s1,s2): {4}", 
                s1, s2, s1 == s2, Object.ReferenceEquals(s1, s2), String.Equals(s1, s2)) ;
        Console.WriteLine("s1: {0} s3: {1} s1 = s3: {2} Object.ReferenceEquals (s1,s3): {3} String.Equals (s1,s3): {4} ", 
                s1, s2, s1 == s3, Object.ReferenceEquals(s1, s3), String.Equals(s1, s3)) ;

        Console.WriteLine("s1.Length: {0}", s1.Length) ;
        Console.WriteLine("s1.substring ( 0, 2 ): {0}", s1.Substring(0, 2)) ;
        Console.WriteLine("s1.IndexOf ( \"l\"c ): {0} s1.lastIndexOf ( \"l\"c ): {1}", 
                s1.IndexOf( 'l' ), s1.LastIndexOf( 'l' ) ) ;
        Console.WriteLine("s1.IndexOf ( \"ll\" ): {0} s1.lastIndexOf ( \"ll\" ): {1}", 
                s1.IndexOf("ll"), s1.LastIndexOf("ll")) ;

        // C# supports unsigned integer types very well.
        // ushort - Structure Type = System.UInt16
        ushort myUShort =  123 ;
        myUShort = (ushort) ( myUShort + 2 ) ;
        Console.WriteLine() ;
        Console.WriteLine("UInt16 Structure (Value Type) (System.UInt16) supported by C#") ;
        Console.WriteLine("UInt16.MinValue: {0} UInt16.MaxValue: {1}", UInt16.MinValue, UInt16.MaxValue) ;

        // Integer Structure = System.UInt32
        // ushort - Structure Type = System.UInt32
        uint myUInt = 123 ;
        myUInt = myUInt + 2 ;
        Console.WriteLine("UInt32 Structure (Value Type) (System.UInt32) supported well by C#") ;
        Console.WriteLine("UInt32.MinValue: {0} Integer.MaxValue: {1}", UInt32.MinValue, UInt32.MaxValue) ;

        // Integer Structure = System.UInt64
        ulong myULong = 123 ;
        myULong = myULong + 2 ;
        Console.WriteLine("UInt64 Structure (Value Type) (System.UInt64) not supported well by Visual Basic.NET") ;
        Console.WriteLine("UInt64.MinValue: {0} UInt64.MaxValue: {1}", UInt64.MinValue, UInt64.MaxValue) ;
    }
}