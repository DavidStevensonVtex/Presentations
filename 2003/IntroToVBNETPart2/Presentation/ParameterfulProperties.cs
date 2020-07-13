using System ;
using System.Collections ;

public class DependentCollection
{
    private ArrayList collection ;
    private Hashtable lookup ;

    public DependentCollection ()
    {
        collection = new ArrayList() ;
        lookup = new Hashtable() ;
    }

    public virtual Dependent this [ int index ]
    {
        get { return (Dependent) collection [ index ] ; }
        set 
        { 
            collection [ index ] = value ;
            lookup.Add ( value.FirstName, value ) ;
        }
    }
    public virtual Dependent this [ string firstName ]
    {
        get { return (Dependent) lookup [ firstName ] ; }
        set 
        { 
            Dependent dependent = (Dependent) lookup [ firstName ] ;
            if ( dependent == null )
                Add ( value ) ;
            else
            {
                for ( int i = 0 ; i < collection.Count ; i++ )
                {
                    dependent = (Dependent) collection [ i ] ;
                    if ( dependent.FirstName == value.FirstName )
                    {
                        collection.RemoveAt ( i ) ;
                        Add ( value ) ;
                    }
                }
            }
        }
    }

    public void Add ( Dependent value )
    {
        collection.Add ( value ) ;
        lookup.Add ( value.FirstName, value ) ;
    }

    public void Delete ( Int32 Index )
    {
        Dependent dependent ;
        dependent = (Dependent) collection [ Index ] ;
        if ( dependent != null ) 
        {
            lookup.Remove ( dependent.FirstName ) ;
            collection.RemoveAt ( Index ) ;
        }
    }

    public void Delete ( string firstName )
    {
        Dependent dependent ;
        int i ;
        for ( i = 0 ; i < collection.Count ; i++ )
        {
            dependent = (Dependent) collection[i] ;
            if ( dependent.FirstName == firstName )
            {
                lookup.Remove ( firstName ) ;
                collection.RemoveAt ( i ) ;
            }
        }
    }
    public int Count 
    {
        get { return collection.Count ; }
    }
}

public class Test
{
    public static void Main ()
    {
        DependentCollection dc = new DependentCollection () ;
        dc.Add ( new Dependent ( "Nathan", new DateTime ( 1986, 1, 20 )  ) ) ;
        dc.Add ( new Dependent ( "Daryl", new DateTime ( 1988, 5, 29 ) ) ) ; 
        dc.Add ( new Dependent ( "Joshua", new DateTime ( 1992, 2, 17 ) ) ) ; 
        for ( int i = 0 ; i <= dc.Count - 1 ; i++ )
            Console.WriteLine ( dc [ i ] ) ;
        Dependent d ;
        d = dc [ "Nathan" ] ;
        Console.WriteLine ( "Nathan: {0}", d ) ;
        dc.Delete ( "Nathan" ) ;
        Console.WriteLine ( "After deleting dependent Nathan" ) ;
        for ( int i = 0 ; i <= dc.Count - 1 ; i++ )
            Console.WriteLine ( dc [ i ] ) ;
    }
}

