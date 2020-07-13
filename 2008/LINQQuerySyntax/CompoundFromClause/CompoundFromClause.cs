using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Category
{
    public static int NewCategoryID = 1;
    public int ID { get; private set; }
    public string Name { get; set; }
    public List<string> ProductList { get; set; }
    public Category(string Name, List<string> ProductList)
    {
        this.ID = NewCategoryID++;
        this.Name = Name;
        this.ProductList = ProductList;
    }
}
public class CompoundFromClause
{
        // 1. Data Source
    public static Category[] Categories =
    {
        new Category ( "Beverages", 
            new List<string> () { "Cappucino", "Pepsi" } ),
        new Category ( "Condiments",
            new List<string> () { "Ketchup", "Mustard" } ),
        new Category ( "Confections", 
            new List<string> () { "Cake", "Pudding" } ) 
    };

    public static void Main(string[] args)
    {
            // 2. Query Definition
        var query = from c in Categories
                    from p in c.ProductList
                    select new { CategoryName = c.Name, ProductName = p };

            // 3. Query execution.
        foreach (var cp in query)
            Console.WriteLine("{0,-15} {1}",
                cp.CategoryName, cp.ProductName);

        Console.ReadKey();
    }
}

