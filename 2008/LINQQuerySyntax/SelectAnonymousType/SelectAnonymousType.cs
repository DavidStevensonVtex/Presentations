﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Category
{
    private static int NewCategoryID = 1;
    public int ID { get; private set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Category(string Name, string Description)
    {
        ID = NewCategoryID++;
        this.Name = Name;
        this.Description = Description;
    }
}

public class SelectAnonymousType
{
    // 1. Data Source.
    public static Category[] Categories = 
    {
         new Category ( "Beverages",        "Soft drinks, coffees, teas, beers, and ales" ),
         new Category ( "Condiments",       "Sweet and savory sauces, relishes, spreads, and seasonings" ),
         new Category ( "Confections",      "Desserts, candies, and sweet breads" ),
         new Category ( "Dairy Products",   "Cheeses" ),
         new Category ( "Grains/Cereals",   "Breads, crackers, pasta, and cereal" ),
         new Category ( "Meat/Poultry",     "Prepared meats" ),
         new Category ( "Produce",          "Dried fruit and bean curd" ),
         new Category ( "Seafood",          "Seaweed and fish" )
    };
    public static void Main(string[] args)
    {
        // 2. Query Definition.
        // Select specifies Anonymous Type.
        // Note: Field Names in Anonymous Type are optional.
        // Field Names  in Anonymous Type
        // can be used to re-name columns.
        var query = from cat in Categories
                    select new { CategoryID = cat.ID, 
                                 CategoryName = cat.Name };

        // 3. Query Execution
        foreach (var c in query)
            Console.WriteLine("{0,2} {1}", 
                c.CategoryID, c.CategoryName);

        Console.ReadKey();
    }
}
