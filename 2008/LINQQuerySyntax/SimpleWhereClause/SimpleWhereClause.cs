using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class SimpleWhereClause
{
    static void Main(string[] args)
    {
        string phrase = "The rain in Spain falls mainly in the plain.";

        // 1. Data Source
        string[] words = phrase.Split(' ', '.');

        // 2. Query Definition
        var query = from w in words
                    where w.EndsWith("ain")
                    select w;

        // 3. Query Execution
        foreach (var s in query)
            Console.WriteLine("{0}", s);

        Console.WriteLine("---------------------");
        // Within a single where clause, you can specify as many
        // predicates as necessary by using the && and || operators. 
        var query2 = from w in words
                    where w.EndsWith("ain") && ( w.Length >= 5 )
                    select w;

        // 3. Query Execution
        foreach (var s in query2)
            Console.WriteLine("{0}", s);

        Console.ReadKey();
    }
}
