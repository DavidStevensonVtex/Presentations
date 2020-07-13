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

public class GroupByCompositeKeys
{
    public static void Main(string[] args)
    {
        // Disclaimer: Northwind data has been changed to suit the example.
        // 1. Data Source
        List<Product> ProductList = new List<Product>
        {
            new Product ( "Chai",                   "Exotic Liquids",   "London" ),
            new Product ( "Konbu",                  "Mayumi's",	        "Tokyo"  ),
            new Product ( "Alice Mutton",           "Pavlova, Ltd.",	"London" ),
            new Product ( "Mishi Kobe Niku",        "Tokyo Traders",	"Tokyo"  ),
            new Product ( "Chang",                  "Exotic Liquids",   "London" ),
            new Product ( "Tofu",                   "Mayumi's",         "Tokyo"  ),
            new Product ( "Pavlova",                "Pavlova, Ltd.",	"London" ),
            new Product ( "Longlife Tofu",          "Tokyo Traders",	"Tokyo"  ),
            new Product ( "Aniseed Syrup",          "Exotic Liquids",   "London" ),
            new Product ( "Genen Shouyu",           "Mayumi's",         "Tokyo"  ),
            new Product ( "Carnarvon Tigers",       "Pavlova, Ltd.",	"London" ),
            new Product ( "Ikura",                  "Tokyo Traders",	"Tokyo"  ),
        };

        // 2. Query Definition

        var query = from p in ProductList
                    //orderby p.City ascending, p.CompanyName ascending
                    group p by new { p.City, p.CompanyName } ;
                    

        // 3. Query Execution.
        Console.WriteLine("{0,-10} {1,-20} {2}", 
            "City", "Company", "Product");
        foreach ( var g in query )
        {
            Console.WriteLine("{0,-10} {1,-20}", 
                g.Key.City, g.Key.CompanyName);

            foreach (var v in g)
                Console.WriteLine("{0,-31} {1}", 
                    "", v.ProductName);

            Console.WriteLine();
        }

        Console.ReadKey ();

                    
    }
}