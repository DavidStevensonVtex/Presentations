using System;
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

public class ProductCategory
{
    public int CategoryID { get; set; }
    public string CategoryName { get; set; }
    public ProductCategory(int CategoryID, string CategoryName)
    {
        this.CategoryID = CategoryID;
        this.CategoryName = CategoryName;
    }
}

public class SelectNamedType
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
        // Select specifies Named Type.
        IEnumerable<ProductCategory> query = from cat in Categories
                    select new ProductCategory ( cat.ID, cat.Name ) ;

        // Queries defined as var cannot be passed to external methods
        // except as Object.
        // Queries declared as strongly typed can be passed to
        // external methods.
        CategoryPrint.Print(query);

        Console.ReadKey();
    }
}

public class CategoryPrint
{
    public static void Print(IEnumerable<ProductCategory> query)
    {
        // 3. Query Execution
        foreach (var c in query)
            Console.WriteLine("{0,2} {1}",
                c.CategoryID, c.CategoryName);
    }
} 
