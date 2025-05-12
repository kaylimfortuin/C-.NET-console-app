// See https://aka.ms/new-console-template for more information
/* variable typs in C#
 
 * int
 * float
 * boolean
 * string
 * decimal
 */

//declaring the variables
string name = string.Empty;
string lastname = string.Empty;
int age = 0;
int retirementage = 65;
decimal salary = 0;
char gender = char.MinValue;
bool working = false;

//prompt the user for input
Console.WriteLine("Enter your name: ");
name = Console.ReadLine();
Console.WriteLine("Enter your last name: ");
lastname = Console.ReadLine();
Console.WriteLine("Enter your age: ");
age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your salary: ");
salary = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("What is your gender (M or F): ");
gender = Convert.ToChar(Console.ReadLine());
Console.WriteLine("Are you working? (true or false): ");
working = Convert.ToBoolean(Console.ReadLine());

//process the information
int workingyearsremaining = retirementage - age;
Console.WriteLine($"Your name is {name}");
Console.WriteLine($"Your last name is {lastname}");
Console.WriteLine($"Your current age is {age}");
Console.WriteLine($"Your remaining years on the job is {workingyearsremaining}");
Console.WriteLine($"Your Gender is {gender}");
Console.WriteLine($"Your salary is {salary}");