using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ProductValue
{
    public string ProductType { get; set; }
    public string ProductName { get; set; }
    public decimal AnnualSales { get; set; }
    public ProductValue(string ProductType,
        string ProductName, decimal AnnualSales)
    {
        this.ProductType = ProductType;
        this.ProductName = ProductName;
        this.AnnualSales = AnnualSales;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        List<ProductValue> ProductValueList = new List<ProductValue> () 
        {
            new ProductValue ( "Gold",     "Alice Mutton",                   16580.85m   ),
            new ProductValue ( "Bronze",   "Aniseed Syrup",                  1724.00m    ),
            new ProductValue ( "Silver",   "Boston Crab Meat",               9796.33m    ),
            new ProductValue ( "Gold",     "Camembert Pierrot",              20652.28m   ),
            new ProductValue ( "Gold",     "Carnarvon Tigers",               15950.00m   ),
            new ProductValue ( "Bronze",   "Chai",                           4887.00m    ),
            new ProductValue ( "Silver",   "Chang",                          7038.55m    ),
            new ProductValue ( "Bronze",   "Chartreuse verte",               4475.70m    ),
            new ProductValue ( "Silver",   "Chef Anton's Cajun Seasoning",   5214.88m    ),
            new ProductValue ( "Lame",     "Chef Anton's Gumbo Mix",         373.63m    ),
            new ProductValue ( "Bronze",   "Chocolade",                      1282.01m    ),
            new ProductValue ( "Gold",     "Côte de Blaye",                  46563.09m   )
        } ;

        var query = from p in ProductValueList
                    orderby p.AnnualSales descending
                    group p by p.AnnualSales >= 10000.00m;

        foreach (var group in query)
        {
            if (group.Key == true)
                Console.WriteLine("Gold products");
            else
                Console.WriteLine("Less stellar products");
            foreach (var p in group)
            {
                Console.WriteLine("{0,-10} {1,-30} {2,8:n2}",
                    p.ProductType, p.ProductName, p.AnnualSales);
            }
        }
        Console.ReadKey();
    }
}
