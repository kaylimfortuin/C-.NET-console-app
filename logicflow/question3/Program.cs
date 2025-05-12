using System;

namespace Question3{
    class Program{
        static void Main(string[] args){
            int number = 0;
            int sum = 0;
            int count = 0;

            while(true){
                Console.WriteLine("Enter a number (0 to exit): ");
                number = Convert.ToInt32(Console.ReadLine());
                if (number == 0){
                    break;
                }
                if (number > 0){
                    sum += number;
                    count++;
                }
            }
            
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Count: " + count);

        }
    }
}