using System;

namespace Question3{
    class Program{
        static void Main(string[] args){
            string print1 = "Hello";
            string print2 = "World";
            string exit = "Exit";

            do{
                Console.WriteLine("Menu \n (1) Print Hello \n (2) Print World \n (3) Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                if(choice == "1"){
                    Console.WriteLine(print1);
                }
                else if(choice == "2"){
                    Console.WriteLine(print2);
                }
                else if (choice == "3"){
                    Console.WriteLine(exit);
                    break;
                }
                else{
                    Console.WriteLine("Choose a number between 1 and 3. ");
                }
                } while (true);

                Console.WriteLine("Goodbye!");


        }
    }
}
