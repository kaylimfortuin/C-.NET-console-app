using System;

namespace Question2{
    class Program{
        static void Main(string[] args){
            string password = string.Empty;
            
            do{
                Console.WriteLine("Enter a password: ");
                password = Console.ReadLine();

                if(password.Length < 8){
                    Console.WriteLine("password must be atleast 8 characters ling. Try again.");
                } 
                else if(password.Length >= 8){
                    break;
                }  
            } 
            while(true);

            Console.WriteLine("password accepted!");                         
        }
    }
}