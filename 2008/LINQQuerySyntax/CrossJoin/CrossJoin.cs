using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// CrossJoin
public class CrossJoin
{
    public static void Main()
    {
            // 1. Data Sources
        int [] diceValues1 = { 1, 2, 3, 4, 5, 6 } ;
            // Separate data source for demo purposes only.
            // In this case same data source could be used twice.
        int [] diceValues2 = { 1, 2, 3, 4, 5, 6 } ;

            // 2. Query Definition
        var query = from x in diceValues1
                    from y in diceValues2
                    select new { Die1 = x, Die2 = y, Sum = x + y } ;

            // 3. Query Execution
        foreach (var v in query)
            Console.WriteLine("{0,2} {1,2} {2,2}", 
                v.Die1, v.Die2, v.Sum);

        Console.WriteLine("------------------------------");
        Console.WriteLine("First Die Even, Second Die Odd Values");
        // Filtered joins
        var query2 = from x in diceValues1 
                     where x % 2 == 0
                     from y in diceValues1
                     where y % 2 == 1
                     select new { Die1 = x, Die2 = y, Sum = x + y };

        foreach (var v in query2)
            Console.WriteLine("{0,2} {1,2} {2,2}",
                v.Die1, v.Die2, v.Sum);

        Console.ReadKey();
    }
}
