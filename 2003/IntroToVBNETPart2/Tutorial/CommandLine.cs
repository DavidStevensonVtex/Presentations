using System;

public class CommandLine
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Number of command line parameters = {0}", args.Length);
		for ( int i = 0; i < args.Length; i++ )
			Console.WriteLine("Arg[{0}] = [{1}]", i, args[i]);
	}
}