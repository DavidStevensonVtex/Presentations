using System ;

// Private The method is callable only by other methods in the same class type.

// Protected The method is callable by derived types, regardless of whether they are 
// within the same assembly.

// Friend The method is callable by any code in the same assembly. (C# internal)

// Protected Friend The method is callable by derived types in any assembly. 
// (C# refers to this as internal protected).

// Public The method is callable by any code in any assembly.

// Source: Richter and Balena, Applied Microsoft .NET Framework Programming In 
// Microsoft Visual Basic .NET, p. 27


public class Accessibility
{
    internal int w = 1 ;
    private int x = 2 ;
    protected int y = 3 ;
    public int z = 4 ;

    internal int getW () { return this.w ; }
    private int getX () { return this.x ; }
    protected int getY () { return this.y ; }
    public int getZ () { return this.z ; }
    public void DisplayAccessibility()
    {
        Console.WriteLine("Accessibility: w: {0} x: {1} y: {2} z: {3}", w, x, y, z) ;
        Console.WriteLine("Accessibility: getW(): {0} getX(): {1} getY(): {2} getZ(): {3}", 
                getW(), getX(), getY(), getZ()) ;
    }
}

public class DerivedClass :  Accessibility
{
    internal int a = 5 ;
    private int b = 6 ;
    protected int c = 7 ;
    public int d = 8 ;
    public void DisplayDerivedClass()
    {
        Console.WriteLine("DerivedClass: a: {0} b: {1} c: {2} d: {3}", a, b, c, d) ;
        // Compiler Error: AccessibilityExample.x is not accessible in this context because it is 'Private'
        Console.WriteLine("DerivedClass: w: {0}, (x is private, can't see) y: {1}, z: {2}", w, y, z) ;
        // Compiler Error: AccessibilityExample.getX()  is not accessible in this context because it is 'Private'
        Console.WriteLine("DerivedClass: getW(): {0}, (getX is private, can't see) getY(): {1}, getZ(): {2}", 
               getW(), getY(), getZ()) ;
    }
}

public class Test
{
    public static void Main()
    {
        Accessibility ae = new Accessibility () ;
        DerivedClass dc = new DerivedClass () ;

        ae.DisplayAccessibility() ;
        dc.DisplayAccessibility() ;
        dc.DisplayDerivedClass() ;

        // internal member examples
        Console.WriteLine("internal Example: dc.a: {0} dc.w {1} dc.getW(): {2}", 
            dc.a, dc.w, dc.getW()) ;

        // Private member examples
        // Compile error: [ b, x, getX()] is not accessible in this context because it is 'Private'
        //Console.WriteLine("Private example: dc.b: {0} dc.getB(): {1} dc.x: {2} dc.getX(): {3}", _
        //    dc.b, dc.x, dc.getX()) ;

        // Protected members examples
        // Compile error: [y, getY(), c] is not accessible in this context because it is 'Protected'
        // Console.WriteLine("Protected example: dc.y: {0} dc.getY(): {1} dc.c: {2}", dc.y, dc.getY(), dc.c) ;

        Console.WriteLine("Public example: dc.d: {0} dc.z: {1} dc.getZ(): {2}", dc.d, dc.z, dc.getZ()) ;

    }
}