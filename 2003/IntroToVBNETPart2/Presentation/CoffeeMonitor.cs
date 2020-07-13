using System ;

public class CoffeeMonitor
{
	// C# does not support WithEvents keyword
	// Shared WithEvents monitor As Coffee = New Coffee()
	static void MyCoffeeIsReady()
	{
		Console.WriteLine("My Coffee Is Ready") ;
	}
	static void YourCoffeeIsReady() // Handles monitor.CoffeeReady
	{
		Console.WriteLine("Your coffee is ready") ;
	}
	static void Main() 
	{
		Coffee coffee = new Coffee () ;
		// monitor.NotifyCoffeeReady()
		// A reference to a static method
		coffee.CoffeeReady += new Coffee.CoffeeEventHandler ( MyCoffeeIsReady ) ;
		// AddHandler coffee.CoffeeReady, AddressOf MyCoffeeIsReady
		CoffeeClanMember [ ] coffeeClanMember = new CoffeeClanMember[10 + 1 ] ;
		// Dim coffeeClanMember(10) As CoffeeClanMember
		int i ;
		for ( i = 0 ; i <= 10 ; i++ )
		{
			coffeeClanMember[i] = new CoffeeClanMember () ;
			// A reference to an instance method.
			coffee.CoffeeReady += new Coffee.CoffeeEventHandler ( coffeeClanMember[i].MyCoffeeIsReady ) ;
		}

		// A single RaiseEvent will notify me and the entire coffee clan.
		coffee.NotifyCoffeeReady() ;
	}
}
