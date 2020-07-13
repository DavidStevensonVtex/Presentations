using System  ;

public class ConstantTest
{
	const bool PERFORM_TRACE = true ;
	const short SHORT_CONSTANT = 123 ;
	const int INTEGER_CONSTANT =  1234 ;
	const long LONG_CONSTANT =  1234567890123456789L ;
	const byte ALL_TRUE = 0xFF ;
	const short OCTAL_VALUE = 0377 ;
	const decimal BUCK = 1.00M ;
	const decimal PENNY = 0.01M ;
	const decimal NICKEL = 0.05M ;
	const char LETTER_A = 'a' ;
	// Can't declare a constant of type DateTime
	// assignments to readonly fields can only occur as 
	// part of the declaration or in a constructor in the same class. 
	public readonly DateTime BIRTHDAY  = new DateTime ( 1958, 6, 28 ) ;
	const string FamousQuotation = "Now is the time for all good men to come to the aid of their country." ;
}