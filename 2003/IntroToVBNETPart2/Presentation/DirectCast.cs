using System ;

public class Employee { }

class App {
	public static void Main () 
	{
       // No cast is needed because New returns an Employee object
        // and Object is a base type of Employee.
		Object o = new Employee () ;

        // A cast is required because Employee is derived from Object
		Employee e  = (Employee) o ; 
		// Compiler Error: Cannot implicitly convert type 'object' to 'Employee'
		// Employee e2 = o ;
	}
}