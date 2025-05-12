using System;

namespace LogicProgram{
    class Program{
        static void Main (string[] args){
            int number = 0;
            Console.WriteLine("Enter a positive number between 1 and 100:");
            number = Convert.ToInt32(Console.ReadLine());

            while (number <1 || number >100){
                Console.WriteLine("Invalid input, please enter a number between 1 and 100:");
                number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a positive number between 1 and 100:");
            }

            if (number % 3 == 0 || number % 5 == 0)
            {
                Console.WriteLine("number is dividible by 3 or 5");
            }
            else
            {
                Console.WriteLine("number is not dividible by 3 or 5");
            }
        }  
    }
}

