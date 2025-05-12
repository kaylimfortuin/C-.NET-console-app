namespace ConsoleApp.LogicalOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter student mark: ");
            int mark = Convert.ToInt32(Console.ReadLine());

            if (mark >= 90 && mark <= 100)
            {
                Console.WriteLine("The student passed with Grade A");
            }
            else if (mark >= 80 && mark < 90)
            {
                Console.WriteLine("The student passed with Grade B");
            }
            else if (mark >= 70 && mark < 80)
            {
                Console.WriteLine("The student passed with Grade C");
            }
            else if (mark >= 0 && mark < 70)
            {
                Console.WriteLine("The student failed");
            }
            else if (mark > 100 || mark < 0)
            {
                Console.WriteLine("Wrong input. The mark range is from 0 to 100");
            }
        }
    }
}