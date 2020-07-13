using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Supplier
{
    public string City { get; set; }
    public string SupplierName { get; set; }
    public Supplier ( string SupplierName, string City )
    {
        this.SupplierName = SupplierName ;
        this.City = City ; 
    }
}

public class Customer 
{
    public string CustomerName { get; set; }
    public string City { get; set; }
    public Customer(string CustomerName, string City)
    {
        this.CustomerName = CustomerName;
        this.City = City;
    }
}

public class JoinClause
{
    public static void Main(string[] args)
    {
        // 1. Data Source #1.
        Supplier[] suppliers = 
        {
            new Supplier ( "Exotic Liquids",                "London" ),
            new Supplier ( "Heli Süßwaren GmbH & Co. KG",   "Berlin" ),
            new Supplier ( "Aux joyeux ecclésiastiques",    "Paris" )
        };
        // 1. Data Source #2.
        Customer[] customers =
        {
            new Customer ( "Alfreds Futterkiste",   "Berlin" ),
            new Customer ( "Around the Horn",       "London" ),
            new Customer ( "B's Beverages",         "London" ),
            new Customer ( "Consolidated Holdings", "London" ),
            new Customer ( "Eastern Connection",    "London" ),
            new Customer ( "North/South",           "London" ),
            new Customer ( "Paris spécialités",     "Paris"  ),
            new Customer ( "Seven Seas Imports",    "London" ),
            new Customer ( "Spécialités du monde",  "Paris"  ),
        };
        // 2. Query Definition.
        var innerJoinQuery = from s in suppliers
                             join c in customers
                             on s.City equals c.City
                             orderby s.City
                             select new { c.City, s.SupplierName, c.CustomerName };

        Console.WriteLine("{0,-10} {1,-30} {2}",
            "City", "Supplier", "Customer");
        // 3. Query Execution.
        foreach (var sc in innerJoinQuery)
            Console.WriteLine("{0,-10} {1,-30} {2}",
                sc.City, sc.SupplierName, sc.CustomerName);

        Console.ReadKey();
    }
}