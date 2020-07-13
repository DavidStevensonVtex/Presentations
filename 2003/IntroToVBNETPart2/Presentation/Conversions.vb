Imports System

Public Class Conversions
    Shared Sub Main()
        Dim A, B As Integer
        Dim Check As Boolean
        A = 5 : B = 5             ' Initialize variables.
        Check = CBool(A = B)       ' Check contains True.
        Console.WriteLine("Check: {0}", Check)
        A = 0                                ' Define variable.
        Check = CBool(A)             ' Check contains False.
        Console.WriteLine("Check: {0}", Check)

        Dim MyDouble As Double
        Dim MyByte As Byte
        MyDouble = 125.5678        ' MyDouble is a Double.
        MyByte = CByte(MyDouble)   ' MyByte contains 126.
        Console.WriteLine("MyByte: {0}", MyByte)

        Dim MyCurr As Decimal
        MyDouble = 543.214588         ' MyDouble is a Double.
        MyCurr = CDec(MyDouble * 2)   ' Convert result of MyDouble * 2 (1086.429176) to a Currency (1086.4292).
        Console.WriteLine("MyCurr: {0:C}", MyCurr)

        Dim MyDate, MyTime As String
        Dim MyShortDate, MyShortTime As Date
        MyDate = "October 19, 1962"   ' Define date.
        MyShortDate = CDate(MyDate)   ' Convert to Date data type.
        Console.WriteLine("MyShortDate: {0}", MyShortDate)
        MyTime = "4:35:47 PM"         ' Define time.
        MyShortTime = CDate(MyTime)   ' Convert to Date data type.
        Console.WriteLine("MyShortTime: {0}", MyShortTime)

        MyCurr = CDec(234.456784)              ' MyCurr is a Currency (234.4567).
        MyDouble = CDbl(MyCurr * 8.2 * 0.01)   ' Convert result to a Double (19.2254576).
        Console.WriteLine("MyDouble: {0:C}", MyDouble)

        Dim MyInt As Integer
        MyDouble = 2345.5678     ' MyDouble is a Double.
        MyInt = CInt(MyDouble)   ' MyInt contains 2346.
        Console.WriteLine("MyInt: {0}", MyInt)

        Dim MyVal1, MyVal2 As Double
        Dim MyLong1, MyLong2 As Long
        MyVal1 = 25427.45 : MyVal2 = 25427.55 ' MyVal1, MyVal2 are Doubles.
        MyLong1 = CLng(MyVal1)   ' MyLong1 contains 25427.
        MyLong2 = CLng(MyVal2)   ' MyLong2 contains 25428.
        Console.WriteLine("MyLong1: {0} MyLong2: {1}", MyLong1, MyLong2)

        Dim MyDouble1, MyDouble2 As Double
        Dim MySingle1, MySingle2 As Single
        MyDouble1 = 75.3421115 : MyDouble2 = 75.3421555
        MySingle1 = CSng(MyDouble1)   ' MySingle1 contains 75.34211.
        MySingle2 = CSng(MyDouble2)   ' MySingle2 contains 75.34216.
        Console.WriteLine("MySingle1: {0} MySingle2: {1}", MySingle1, MySingle2)

        Dim MyString As String
        MyDouble = 437.324         ' MyDouble is a Double.
        MyString = CStr(MyDouble)   ' MyString contains "437.324".
        Console.WriteLine("MyString: {0}", MyString)

        Dim c As Char
        c = CChar("a")
        Console.WriteLine("c: {0}", c)

        Dim s As Short
        s = CShort("12345")
        Console.WriteLine("s: {0}", s)
        s = CShort(12345.67)
        Console.WriteLine("s: {0}", s)

        Dim MyObject As Object
        MyDouble = 2.7182818284
        MyObject = CObj(MyDouble)   ' Double value is pointed to by MyObject.
        Console.WriteLine("MyObject: {0}", MyObject)


    End Sub
End Class