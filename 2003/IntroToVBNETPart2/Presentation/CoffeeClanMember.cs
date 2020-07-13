using System ;

public class CoffeeClanMember
{
	static int memberCount  = 1 ;
	int memberNumber = memberCount ;
	public CoffeeClanMember () 
	{
		memberCount = memberCount + 1 ;
	}
	public void MyCoffeeIsReady()
	{
		Console.WriteLine("Coffee Clan Member #" + memberNumber + ": My Coffee Is Ready") ;
	}
}
