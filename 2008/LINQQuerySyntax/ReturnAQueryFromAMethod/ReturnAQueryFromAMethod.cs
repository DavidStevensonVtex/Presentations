using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ReturnAQueryFromAMethod
{
    private static IEnumerable<int> OddNumbers(ref int[] numbers)
    {
        var oddNumbers = from i in numbers
                         where i % 2 == 1
                         select i;
        return oddNumbers;
    }

    private static IEnumerable<int> EvenNumbers(ref int[] numbers)
    {
        var evenNumbers = from i in numbers
                         where i % 2 == 0
                         select i;
        return evenNumbers;
    }

    public static void Main(string[] args)
    {
        int[] nums = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        var oddQuery = OddNumbers(ref nums);

        foreach (int i in oddQuery)
            Console.Write("{0} ", i);
        Console.WriteLine("\n\n");

        var evenQuery = EvenNumbers(ref nums);
        foreach (int i in evenQuery)
            Console.Write("{0} ", i);
        Console.WriteLine();

        Console.ReadKey();
    }
}