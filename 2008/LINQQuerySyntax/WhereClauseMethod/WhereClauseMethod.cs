using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class WhereClauseMethod
{
    static bool IsOddLength(string word)
    {
        return word.Length % 2 != 0;
    }
    static void Main(string[] args)
    {
        string phrase = "The rain in Spain falls mainly in the plain.";

        // 1. Data Source
        string[] words = phrase.Split(' ', '.');

        // 2. Query Definition
        var query = from w in words
                    where IsOddLength ( w ) 
                    select w;

        // 3. Query Execution
        foreach (var s in query)
            Console.WriteLine("{0}", s);

        Console.ReadKey();
    }
}