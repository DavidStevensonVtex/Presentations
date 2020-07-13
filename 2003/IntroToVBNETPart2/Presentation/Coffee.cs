public class Coffee 
{
	public delegate void CoffeeEventHandler () ;
    public event CoffeeEventHandler CoffeeReady ;
	public void  NotifyCoffeeReady() 
	{
		if ( CoffeeReady != null )
			CoffeeReady ( ) ;
	}
}
