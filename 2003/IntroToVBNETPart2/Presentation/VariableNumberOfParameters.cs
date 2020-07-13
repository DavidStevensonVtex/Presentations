using System ;
using System.Text ;

class VariableNumberOfParameters
{
    static string Concatenate( params string [ ]  strings  ) 
    {
        StringBuilder result  = new StringBuilder() ;
        foreach ( string oneString in strings )
        {
            result.Append(oneString) ;
            result.Append ( ' ' ) ;
        }
        return result.ToString() ;
    }
    static void Main()
    {
        Console.WriteLine("{0}", 
            Concatenate("Hello", "Visual", "Developers", "Of", "Upstate", "New York")) ;
    }
}