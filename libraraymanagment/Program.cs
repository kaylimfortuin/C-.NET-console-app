namespace LibraryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string membershipType;
            double overdueFines; //declare a variable that can store a floating point value

            // Input from the user
            Console.WriteLine("Enter your membership type (Premium/Standard/Guest): ");
            membershipType = Console.ReadLine()?.Trim(); //trim() removes all leading and trailing white space characters from the current String
            if (membershipType != "Premium" && membershipType != "Standard" && membershipType != "Guest")
            {
                Console.WriteLine("Invalid membership type");
                return; //exit the program if the membership type is invalid
            }

            Console.WriteLine("Enter your overdue fines (0 or more): ");
            if (!double.TryParse(Console.ReadLine(), out overdueFines) || overdueFines < 0) //TryParse ensures input is a valid number and < 0 ensure number is positive and out. overdueFines is the variable that will store the value of the input
            {
                Console.WriteLine("Invalid input, you cannot enter a negative number");
                return;
            }

            // Process the information
            if (membershipType == "Premium")
            {
                if (overdueFines == 0)
                {
                    Console.WriteLine("You can borrow up to 10 books");
                }
                else
                {
                    Console.WriteLine("You can borrow only 2 books");
                }
            }
            else if (membershipType == "Standard")
            {
                if (overdueFines == 0)
                {
                    Console.WriteLine("You can borrow up to 5 books");
                }
                else
                {
                    Console.WriteLine("You can borrow only 1 book");
                }
            }
            else
            {
                Console.WriteLine("You cannot borrow any books");
            }
        }
    }
}