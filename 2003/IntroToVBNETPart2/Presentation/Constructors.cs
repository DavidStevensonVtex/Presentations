using System ;

class OverloadedConstructors
{
    public int intValue = 123 ;
    public string stringValue = "Ralph" ;
    public Double pi = 3.14159 ;
    public DateTime created ;
    public OverloadedConstructors ( DateTime created,  int intValue, string stringValue )
    {
        this.created = created ; this.intValue = intValue ; this.stringValue = stringValue ;
    }
    public OverloadedConstructors () : base ()
    {
        created =  DateTime.Now ;
    }
    public OverloadedConstructors ( int intValue )
    {
        created =  DateTime.Now ;        // C# doesn't have MyClass
        this.intValue = intValue ;
    }
    public OverloadedConstructors ( int intValue, string stringValue )
    {
        // C# doesn't have MyClass
        created =  DateTime.Now ; this.intValue = intValue ; this.stringValue = stringValue ;
    }
    public override string ToString ( )
    {
        return String.Format ( "intValue: {0} stringValue: {1} pi: {2} created: {3}", 
            intValue, stringValue, pi, created ) ;
    }
}

public class TestOverloadedConstructors
{
    static void Main ()
    {
         OverloadedConstructors oc1  = new OverloadedConstructors ( 456 ) ;
         OverloadedConstructors oc2  = new OverloadedConstructors ( 456, "Sally" ) ;
         OverloadedConstructors oc3  = new OverloadedConstructors ( ) ;
         Console.WriteLine ( oc1 ) ;
         Console.WriteLine ( oc2 ) ;
         Console.WriteLine ( oc3 ) ;
    }
}