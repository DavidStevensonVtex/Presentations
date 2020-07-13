using System ;

public class MyRefType
{
    public float r  ;
    public double i  ;
    public  MyRefType ( float r, double i )
    {
        this.r = r ; this.i = i ;
    }
}

public class MyObject : ICloneable
{
    public int X ;
    public MyRefType Y ;
    public  MyObject(int  X , MyRefType Y)
    {
        this.X = X ; this.Y = Y ;
    }
    public override string ToString() {
        return String.Format("X: {0} Y.r: {1} Y.i {2}", X, Y.r, Y.i) ;
    }
    object ICloneable.Clone ( )
    {
        return Clone () ;
    }
    public object Clone()
    {
        return new MyObject(X, new MyRefType(Y.r, Y.i)) ;
    }
}

public class Test
{
    public static void Main()
    {
        MyObject myObject1 = new MyObject(123, new MyRefType(4.56F, 7.89D)) ;
        MyObject myObject2 ;
        // To obtain a copy that can be modified without affecting the original,
        // this is the wrong way to do it. The reference is copied.
        Console.WriteLine("set myObject2 = myObject1 (copy object references, points to same data)") ;
        myObject2 = myObject1 ;
        Console.WriteLine("myObject1: {0}", myObject1.ToString());
        Console.WriteLine("myObject2: {0}", myObject2.ToString());
        Console.WriteLine();
        Console.WriteLine("Set myObject2.Y.i to 9.87");
        myObject2.Y.i = 9.87;
        Console.WriteLine("myObject1: {0}", myObject1.ToString());
        Console.WriteLine("myObject2: {0}", myObject2.ToString());
        Console.WriteLine("Ooops! set myObject1.Y.i to 9.87 as well. Not good if we didn't mean to do that.");

        // Create a new myObject2 that is distinct from myObject1 
        myObject2 = new MyObject(12345, new MyRefType(56789.0F, 98765.0D));
        Console.WriteLine();
        Console.WriteLine("This demonstrates how a good copy is made");
        // Perform the cloning operation
        Console.WriteLine("myObject1 = (MyObject) myObject2.Clone() ;");
        myObject1 = (MyObject) myObject2.Clone() ;
        // Change something in myObject2 which shouldn't be changed in myObject1 if cloning worked.
        Console.WriteLine("Set myObject2.Y.r = 1.23");
        myObject2.Y.r = 1.23F;
        Console.WriteLine("myObject1: {0}", myObject1.ToString());
        Console.WriteLine("myObject2: {0}", myObject2.ToString());
    }
}