using System;

namespace Question2{
    class Program{
        static void Main (string[] args){
            int i = 1;
            
            for (i = 1; i <= 50; i++)
            {
                if(i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}