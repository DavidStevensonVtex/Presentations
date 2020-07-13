using System ;
class Test
{
     static  string lastItem  = "" ;

     static void RememberLastItem ( string item )
     {
          Console.WriteLine("item: '{0}' last item: '{1}'", item, lastItem) ;
          lastItem = item ;
     }
     public static void Main()
     {
          RememberLastItem("Apple") ;
          RememberLastItem("Orange") ;
          RememberLastItem("Banana") ;
     }
}
