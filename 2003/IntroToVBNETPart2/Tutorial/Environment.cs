using System ;
using System.Collections ;

public class DisplayEnvironment
{
	public static void Main ()
	{
		IDictionary env = Environment.GetEnvironmentVariables() ;
		for ( IDictionaryEnumerator e = env.GetEnumerator () ; e.MoveNext () ; )
		{
			DictionaryEntry entry = (DictionaryEntry) e.Current ;
			Console.WriteLine ( "{0}\t{1}", entry.Key, entry.Value ) ;
		}
	}
}