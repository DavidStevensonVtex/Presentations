using System ;

public class MyEventClass
{
    // Declare a delegate
    public delegate void MyEventEventHandler ( int EventNumber ) ;
    // Declare an event for this class.
    public event MyEventEventHandler MyEvent  ;
    // Define a method that raises an event.
    public void CauseEvent( int EventNumber )
    {
        MyEvent ( EventNumber ) ;        // VB.NET: RaiseEvent MyEvent(EventNumber) ;
    }
}

public class TestEvent
{
    static void EventHandler( int EventNumber )
    {
        Console.WriteLine("Received event number {0}", EventNumber ) ;
    }

    public static void Main ( )
    {
        MyEventClass MyObject = new MyEventClass ( ) ;
        // AddHandler MyObject.MyEvent, AddressOf TestEvent.EventHandler 
        MyObject.MyEvent += new MyEventClass.MyEventEventHandler ( TestEvent.EventHandler ) ;
        // Cause the object to raise an event.
        MyObject.CauseEvent(123) ;
    }
}
