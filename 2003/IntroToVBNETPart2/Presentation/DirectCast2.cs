using System ;
class Employee { }
class Manager : Employee { }

class App 
{
	public static void Main () 
	{
		// Construct a Manager object and pass it to PromoteEmployee
		// A Manager IS-A Object: PromoteEmployee runs OK.
		Manager m = new Manager() ;
		PromoteEmployee( (Object) m) ;

		// Construct a DateTime object and pass it to PromoteEmployee
		// A DateTime is NOT derived from Employee:  PromoteEmployee
		// throws a System.InvalidCastException exception
		DateTime newYears  = new DateTime(2001, 1, 1) ;
		PromoteEmployee( (Object) newYears) ;
	}
	public static void PromoteEmployee( Object o )
	{
		// At this point, the compiler doesn't know exactly what 
		// type of object o refers to. So the compiler allows the
		// code to compile. However, at run time, the CLR does know 
		// what type o refers to (each time the cast is performed) and
		// it checks whether the object's type is Employee or any type
		// that is derived from Employee
		Employee e = (Employee) o ;
	}
}