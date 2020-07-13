using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Supplier
{
    public string City { get; set; }
    public string SupplierName { get; set; }
    public Supplier(string SupplierName, string City)
    {
        this.SupplierName = SupplierName;
        this.City = City;
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
public class GroupJoin
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
        var innerGroupJoinJoinQuery = 
            from s in suppliers
            join c in customers
            on s.City equals c.City into customer
            orderby s.City
            select new { s.City, s.SupplierName, Customer = customer };

        Console.WriteLine("{0,-10} {1,-30} {2,-25} {3}",
            "City", "Supplier", "Customer", "Customer City");
        // 3. Query Execution.
        foreach (var sc in innerGroupJoinJoinQuery)
        {
            Console.WriteLine("{0,-10} {1}", sc.City, sc.SupplierName);
            foreach (var v in sc.Customer)
            {
                Console.WriteLine("{0,-41} {1,-25} {2}", 
                    "", v.CustomerName, v.City);
            }
        }
        Console.ReadKey();
    }
}

