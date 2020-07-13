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
public class LeftOuterJoin
{
    public static void Main(string[] args)
    {
        // 1. Data Source #1.
        Supplier[] suppliers = 
        {
            new Supplier ( "Exotic Liquids",                "London" ),
            new Supplier ( "Heli Süßwaren GmbH & Co. KG",   "Berlin" ),
            new Supplier ( "Aux joyeux ecclésiastiques",    "Paris" ),
            new Supplier ( "New England Seafood Cannery",   "Boston" )  // No matching customers!
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
        var leftOuterJoinQuery =
            from s in suppliers
            join c in customers
            on s.City equals c.City into customer
            select new
            {
                s.City,
                s.SupplierName,
                Customer = customer.DefaultIfEmpty(
                new Customer("No Customer", "No City"))
            };
 
        Console.WriteLine("{0,-10} {1,-30} {2,-25} {3}",
            "City", "Supplier", "Customer", "Customer City");
        // 3. Query Execution.
        foreach (var sc in leftOuterJoinQuery)
        {
            Console.WriteLine("{0,-10} {1,-30}",
                sc.City, sc.SupplierName);
            foreach (var c in sc.Customer)
                Console.WriteLine("{0,-10} {1,-30} {2,-25} {3}",
                    "", "",
                    c.CustomerName, c.City);
        }
        Console.WriteLine("\n\n");

        // 2. Query Definition.
        var leftOuterJoinQuery2 =
            from s in suppliers
            join c in customers
            on s.City equals c.City into customer
            from item in customer.DefaultIfEmpty(
                new Customer("No Customer", "No City"))
            select new { s.City, s.SupplierName, Customer = item };

        Console.WriteLine("{0,-10} {1,-30} {2,-25} {3}",
            "City", "Supplier", "Customer", "Customer City");
        foreach (var sc in leftOuterJoinQuery2)
            Console.WriteLine("{0,-10} {1,-30} {2,-25} {3}",
                sc.City, sc.SupplierName,
                sc.Customer.CustomerName, sc.Customer.City ) ;

        Console.ReadKey();
    }
}