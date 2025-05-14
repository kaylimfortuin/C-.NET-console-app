using System;

namespace ErrorHandling
{
    public class Program
    {
        static void Main(string[] args)
        {
            //exception = errors that occur during execution
            int x;
            int y;
            double z;

            try //try some code that is considered dangerous
            {
                System.Console.Write("Enter and number x: ");
                x = Convert.ToInt32(Console.ReadLine());

                System.Console.Write("Enter a number y: ");
                y = Convert.ToInt32(Console.ReadLine());

                z = x / y;
                System.Console.WriteLine($"answer: {z}");
            }
            catch (FormatException) //catch and handle exceptions when they occur
            {
                System.Console.WriteLine("Enter ONLY a number");
            }
            catch (DivideByZeroException) //the divide by 0 error only occurs when dividing int not doubles
            {
                System.Console.WriteLine("A number cannot be divides by zero, please enter another number");
            }
            //you can add a catch block to catch everything but its difficult too let the user know what went wrong spo its not best practice
            // catch (Exception)
            // {
            //     System.Console.WriteLine("something went wrong");
            // }

            // Finally is optional and it runs regardless of whether the catch block is triggered or not
            finally //always execute
            {
                System.Console.WriteLine("Goodbye!");
            }
        }

    }
}