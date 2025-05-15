using System;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> mixedList = new List<object>(); //creates a new list

            mixedList.Add(15); //adds items to a list
            mixedList.Add(-4);
            mixedList.Add(0);
            mixedList.Add(200);
            mixedList.Add("Invalid");
            mixedList.Add(9.5);

            //the foreach iterates through the list
            foreach (var item in mixedList)
            {
                try
                {
                    Console.WriteLine(item); //displays the items
                    int num = Convert.ToInt32(item); //converts non ints to ints or you can use double

                    if (num > 0 && num % 3 == 0)
                    {
                        System.Console.WriteLine("Positive and Divisible by 3");
                    }

                    else if (num <= 0)
                    {
                        System.Console.WriteLine("Negative or Zero");
                    }

                    else if (num < 100)
                    {
                        System.Console.WriteLine("Not Greater Than 100");
                    }

                    else
                    {
                        System.Console.WriteLine("Large Number");
                    }

                    int square = num * num; //squars the numbers and prints the result
                    System.Console.WriteLine($"square: {square}\n");
                }
                catch (DivideByZeroException)
                {
                    System.Console.WriteLine("a number cannot be divided by zero");
                }
                catch (FormatException)
                {
                    System.Console.WriteLine("please enter a number \n");
                }
                //type conversion failure
                catch (InvalidCastException)
                {
                    System.Console.WriteLine("Dont enter a letter");
                }
                catch (Exception)
                {
                    System.Console.WriteLine("Unexpeted error");
                }
            }
        }
    }
}