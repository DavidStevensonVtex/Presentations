using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleExamples
{
    class ThreePartsOfLINQQuery
    {
        static void Main(string[] args)
        {
            // 3 parts of a LINQ query

            string phrase = "The rain in Spain falls mainly in the plain.";

            // 1. Data Source
            string[] words = phrase.Split(' ');

            // 2. Query Definition
            var query = from w in words
                        select w ;

            // 3. Query Execution (Enumeration using foreach)
            // Query Execution is usually deferred.

            // Some LINQ method syntaxes cause Immediate execution. 
            // Ex: Aggregates, Sum, Count, Min, Max
            foreach (var s in query)
                Console.WriteLine("{0}", s);

            Console.ReadKey();
        }
    }
}
