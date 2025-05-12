using System;

namespace Question1{
    class Program{
        static void Main(string[] args){
            int number =0;
            int sum = 0;
            int count = 0;
            do{
                Console.WriteLine("Enter positive number (negative num to exit): ");
                number = Convert.ToInt32(Console.ReadLine());
                if(number < 0){
                    break;
                }
                sum += number;
                count++;
            } while(true);

            Console.WriteLine("Sum of non negative number: " + sum);

        }
    }
}