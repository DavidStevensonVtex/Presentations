using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class OrderbyClauseBasics
{
    public static void Main(string[] args)
    {
        string phrase = "the quick brown fox jumps over the lazy dog";
        string[] words = phrase.Split(' ', '.');

        var query1 = from w in words
                     orderby w.Length   // ascending is the default
                     select w;
        foreach (var w in query1)
            Console.WriteLine(w);
        Console.WriteLine();

        var query2 = from w in words
                     orderby w.Length descending
                     select w;
        foreach (var w in query2)
            Console.WriteLine(w);
        Console.WriteLine();

        var query3 = from w in words
                     orderby w.Length descending, w ascending
                     select w;
        foreach (var w in query3)
            Console.WriteLine(w);
        Console.WriteLine();


        Console.ReadKey();
    }
}