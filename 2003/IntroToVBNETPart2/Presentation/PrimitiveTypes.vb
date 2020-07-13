Imports System
Imports System.DateTime
Imports Microsoft.VisualBasic

Class PrimitiveTypes
    Shared Sub Main()
        ' Boolean, Byte, Short, Integer, Long, Single, Double
        ' Decimal, Date (DateTime), Char, String

        ' Boolean Structure: System.Boolean
        Dim b As Boolean = True
        Console.WriteLine()
        Console.WriteLine("Boolean Structure (Value Type) (System.Boolean)")
        Console.WriteLine("True: {0} False: {1} Boolean.FalseString: {2} Boolean.TrueString: {3} Boolean.Parse (""true""): {4}", _
            True, False, Boolean.FalseString, Boolean.TrueString, Boolean.Parse("true"))
        If b Then
            Console.WriteLine("b: {0}", b)
        End If

        ' Byte Structure = System.Byte
        Dim myByte As Byte = 123
        myByte = myByte + CByte(2)
        Console.WriteLine()
        Console.WriteLine("Byte  Structure (Value Type) (System.Byte)")
        Console.WriteLine("Byte.MinValue: {0} Byte.MaxValue: {1}", Byte.MinValue, Byte.MaxValue)

        ' Short Structure = System.Short
        Dim myShort As Short = 123S
        myShort = myShort + 2S
        Console.WriteLine()
        Console.WriteLine("Short Structure (Value Type) (System.Int16)")
        Console.WriteLine("Short.MinValue: {0} Short.MaxValue: {1}", Short.MinValue, Short.MaxValue)

        ' Integer Structure = System.Int32
        Dim myInt As Short = 123I
        myInt = myInt + 2S
        Console.WriteLine()
        Console.WriteLine("Integer Structure (Value Type) (System.Int32)")
        Console.WriteLine("Integer.MinValue: {0} Integer.MaxValue: {1}", Integer.MinValue, Integer.MaxValue)

        ' Long Structure = System.Int64
        Dim myLong As Long = 123L
        myLong = myLong + 2
        Console.WriteLine()
        Console.WriteLine("Long Structure (Value Type) (System.Int64)")
        Console.WriteLine("Long.MinValue: {0} Long.MaxValue: {1}", Long.MinValue, Long.MaxValue)

        ' Single Structure = System.Single
        Dim mySingle As Single = 1.23F
        mySingle = mySingle + 2.34F
        Console.WriteLine()
        Console.WriteLine("Single Structure (Value Type) (System.Single)")
        Console.WriteLine("Single: MinValue: {0:G} MaxValue: {1:G} Epsilon: {2:G}", _
            Single.MinValue, Single.MaxValue, Single.Epsilon)
        Console.WriteLine("Single: NegativeInfinity: {0:G} PositiveInfinity: {1:G}: NaN: {2:G}", _
            Single.NegativeInfinity, Single.PositiveInfinity, Single.NaN)

        ' Double Structure = System.Single
        Dim myDouble As Double = 1.23R
        myDouble = myDouble + 2.34R
        Console.WriteLine()
        Console.WriteLine("Double Structure (Value Type) (System.Double)")
        Console.WriteLine("Double: MinValue: {0:G} MaxValue: {1:G} Epsilon: {2:G} ", _
            Double.MinValue, Double.MaxValue, Double.Epsilon)
        Console.WriteLine("NegativeInfinity: {0:G} PositiveInfinity: {1:G}: NaN: {2:G}", _
            Double.NegativeInfinity, Double.PositiveInfinity, Double.NaN)

        Dim myDecimal As Decimal = 1234.56D
        myDecimal = myDecimal + 6543.21D
        Console.WriteLine()
        Console.WriteLine("Decimal Structure (Value Type) (System.Decimal)")
        Console.WriteLine("Decimal: MinValue {0:C} MaxValue: {1:C}", _
            Decimal.MinValue, Decimal.MaxValue)
        Console.WriteLine("Decimal: One: {0:C} Zero: {1:C} MinusOne: {2:C}", _
            Decimal.One, Decimal.Zero, Decimal.MinusOne)
        Console.WriteLine("myDecimal: {0:#,###.00} {0:C}", myDecimal)

        ' Date Structure = System.DateTime
        Dim dteNow As Date = Now()
        Dim dteToday As Date = Today()
        Dim dteGMT As System.DateTime = System.DateTime.UtcNow()
        Console.WriteLine()
        Console.WriteLine("Date Structure (Value Type) (System.DateTime)")
        Console.WriteLine("Today: {0:00}/{1:00}/{2:00}", dteToday.Month, dteToday.Day, dteToday.Year Mod 100)
        Console.WriteLine("dteNow: {0}", dteNow)
        Console.WriteLine("dteToday: {0}", dteToday)
        Console.WriteLine("dteGMT: {0}", dteGMT)

        ' Char Structure Value Type (System.Char)
        Console.WriteLine()
        Console.WriteLine("Char Structure (Value Type) (System.Char)")
        Dim chrLetterA As Char = "a"c
        Dim chrAscA As Char = ChrW(97)
        Console.WriteLine("{0}, {1}", chrLetterA, chrAscA)
        If Char.IsDigit(chrLetterA) Then
            Console.WriteLine("{0} is a digit", chrLetterA)
        ElseIf Char.IsLetter(chrLetterA) Then
            Console.WriteLine("{0} is a letter", chrLetterA)
        ElseIf Char.IsLetterOrDigit(chrLetterA) Then
            Console.WriteLine("{0} is a letter or digit", chrLetterA)
        ElseIf Char.IsLower(chrLetterA) Then
            Console.WriteLine("{0} is a lower case letter", chrLetterA)
        End If

        ' String Reference Type (System.String)
        Console.WriteLine()
        Console.WriteLine("String Class (Reference Type) (System.String)")
        Dim s1 As String = "hello"
        Dim s2 As String = "hello"
        Dim s3 As String = "he"
        s3 = s3 & "llo"
        ' The common language runtime automatically maintains a table, 
        ' called the "intern pool", which contains a single instance of each unique 
        ' literal string constant declared in a program, 
        ' as well as any unique instance of String you add programmatically.

        Console.WriteLine("s1: {0} s2: {1} s1 = s2: {2} Object.ReferenceEquals (s1,s2): {3} String.Equals (s1,s2): {4}", _
                s1, s2, s1 = s2, Object.ReferenceEquals(s1, s2), String.Equals(s1, s2))
        Console.WriteLine("s1: {0} s3: {1} s1 = s3: {2} Object.ReferenceEquals (s1,s3): {3} String.Equals (s1,s3): {4} ", _
                s1, s2, s1 = s3, Object.ReferenceEquals(s1, s3), String.Equals(s1, s3))

        Console.WriteLine("s1.Length: {0}", s1.Length)
        Console.WriteLine("s1.substring ( 0, 2 ): {0}", s1.Substring(0, 2))
        Console.WriteLine("s1.IndexOf ( ""l""c ): {0} s1.lastIndexOf ( ""l""c ): {1}", _
                s1.IndexOf("l"c), s1.LastIndexOf("l"c))
        Console.WriteLine("s1.IndexOf ( ""ll"" ): {0} s1.lastIndexOf ( ""ll"" ): {1}", _
                s1.IndexOf("ll"), s1.LastIndexOf("ll"))

        ' Visual Basic.NET does not support unsigned integer types very well.
        ' UInt16 Structure = System.UInt16
        ' No literal support
        ' Value of type 'Short' [or 'Integer'] cannot be converted to 'System.UInt16'
        ' Dim myUShort As UInt16 = 123S
        Dim myUShort As UInt16 = System.Convert.ToUInt16(123S)
        ' Operator '+' is not defined for types 'System.UInt16' and 'Integer'
        ' myUShort = myUShort + 2
        Console.WriteLine()
        Console.WriteLine("UInt16 Structure (Value Type) (System.UInt16) not supported by Visual Basic.NET")
        ' UInt16.MinValue: Constants must be an instrinsic or enumerated type, not a class, structure, or array type
        ' Console.WriteLine("UInt16.MinValue: {0} UInt16.MaxValue: {1}", UInt16.MinValue, UInt16.MaxValue)

        ' Integer Structure = System.UInt32
        ' Value of type 'Integer' cannot be converted to 'System.UInt32'.
        ' Dim myUInt As System.UInt32 = 123I
        Dim myUInt As UInt32 = System.Convert.ToUInt32(123I)
        ' Operator '+' is not defined for types 'System.UInt32' and 'Integer'
        ' myUInt = myUInt + 2
        Console.WriteLine("UInt32 Structure (Value Type) (System.UInt32) not supported well by Visual Basic.NET")
        ' Constants must be an intrinsic or enumerated type, not a class, structure, or array type.
        ' Console.WriteLine("Integer.MinValue: {0} Integer.MaxValue: {1}", UInt32.MinValue, UInt32.MaxValue)

        ' ULong Structure = System.UInt64
        ' You get the idea for Unsigned data types...
        Console.WriteLine("UInt64 Structure (Value Type) (System.UInt64) not supported well by Visual Basic.NET")

    End Sub
End Class