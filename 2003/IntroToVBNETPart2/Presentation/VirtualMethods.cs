using System ;
public  abstract class Employee
{
	public string Name ;
	public string EmpId ;
	public Employee ( string Name, string EmpId )
	{
		this.Name = Name ; this.EmpId = EmpId ;
	}
	public virtual string EmployeeType 
	{
		get { return "Employee" ; }
	}
	public abstract Decimal Pay () ;
}

public class HourlyEmployee : Employee
{
	public Double Hours ;
	public Decimal HourlyRate ;
	// public HourlyEmployee () { base () ; }
	public HourlyEmployee ( string Name, string EmpId, Double Hours, Decimal HourlyRate )
		: base ( Name, EmpId )
	{
		this.Hours = Hours ; this.HourlyRate = HourlyRate ;
	}
	public override string EmployeeType 
	{
		get { return "Hourly Employee" ; }
	}
	public override Decimal Pay ( )
	{ return (Decimal)Hours * HourlyRate ; }
}

public class Manager :  Employee
{
	public Decimal Salary ;
	public Manager ( string Name, string EmpId, Decimal Salary ) 
		: base ( Name, EmpId )
	{ this.Salary = Salary ; }
	public override string EmployeeType 
	{
		get { return "Manager" ; }
	}
	public override Decimal Pay ( )
	{ return Salary ; }
}

public class Test
{
	static void Main( )
	{
		Employee m  = new Manager("David Stevenson", "12345", 1200M) ;
		Employee e1  = new HourlyEmployee("Jake", "23456", 35.0, 5.50M) ;
		Console.WriteLine("{0} {1} {2:C}", m.EmployeeType, m.Name, m.Pay ( ) ) ;
		Console.WriteLine("{0} {1} {2:C}", e1.EmployeeType, e1.Name, e1.Pay ( ) ) ;
	}
}
