using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Product
{
    public string ProductName { get; set; }
    public string CompanyName { get; set; } // Supplier
    public string City { get; set; }        // Supplier City
    public Product(string ProductName, string CompanyName, string City)
    {
        this.ProductName = ProductName;
        this.CompanyName = CompanyName;
        this.City = City;
    }
}

public class GroupQuery
{

    public static void Main(string[] args)
    {
        // Disclaimer: Northwind data has been changed to suit the example.

        List<Product> ProductList = new List<Product>
        {
            new Product ( "Chai",                   "Exotic Liquids",   "London" ),
            new Product ( "Chang",                  "Exotic Liquids",   "London" ),
            new Product ( "Aniseed Syrup",          "Exotic Liquids",   "London" ),
            new Product ( "Konbu",                  "Mayumi's",	        "Tokyo" ),
            new Product ( "Tofu",                   "Mayumi's",         "Tokyo" ),
            new Product ( "Genen Shouyu",           "Mayumi's",         "Tokyo" ),
            new Product ( "Pavlova",                "Pavlova, Ltd.",	"London" ),
            new Product ( "Alice Mutton",           "Pavlova, Ltd.",	"London" ),
            new Product ( "Carnarvon Tigers",       "Pavlova, Ltd.",	"London" ),
            new Product ( "Mishi Kobe Niku",        "Tokyo Traders",	"Tokyo" ),
            new Product ( "Ikura",                  "Tokyo Traders",	"Tokyo" ),
            new Product ( "Longlife Tofu",          "Tokyo Traders",	"Tokyo" )
        };
        // Example: Grouping by string
        IEnumerable<IGrouping<string,Product>> query = 
            from p in ProductList
            group p by p.City into g
            orderby g.Key
            select g;
        // When declared as var, the following helps determine query type.
        //Console.WriteLine("{0}", query.GetType().ToString());

        foreach (IGrouping<string, Product> pg in query)
        {
            Console.WriteLine("\nKey: {0}", pg.Key);
            foreach ( Product p in pg )
                Console.WriteLine("{0,-10}{1,-20}{2}", 
                    p.City, p.CompanyName, p.ProductName);
        }
        Console.ReadKey();
    }
}
