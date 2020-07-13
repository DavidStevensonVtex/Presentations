using System ;

public class Dependent
{
    private string _FirstName ;
    private DateTime _BirthDate ;
    public Dependent ( string firstName, DateTime birthDate )
    {
        _FirstName = firstName ;
        _BirthDate = birthDate ;
    }
    public string FirstName
    {
        get { return _FirstName ; }
        set { _FirstName = value ; }
    }
    public DateTime BirthDate
    {
        get { return _BirthDate ; }
        set { _BirthDate = value ; }
    }
    public override string ToString () 
    {
        return String.Format ( "First name: {0} birth date: {1}", _FirstName, _BirthDate ) ;
    }
}