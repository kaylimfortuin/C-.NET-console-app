using System;

namespace equationsolver
{
    class EquationSolver
    {
        static void Main()
        {
            Console.Clear();
            Console.WriteLine("=======================================");
            Console.WriteLine("            Equation Solver            ");
            Console.WriteLine("=======================================\n");

            while (true)
            {
                try
                {
                    Console.WriteLine("Select equation type:");
                    Console.WriteLine("  1. Linear     (ax + b = 0)");
                    Console.WriteLine("  2. Quadratic  (ax^2 + bx + c = 0)");
                    Console.WriteLine("  0. Exit\n");

                    Console.Write("Enter choice (0, 1 or 2): ");
                    string choice = Console.ReadLine();
                    Console.WriteLine();

                    if (choice == "1")
                    {
                        SolveLinear();
                    }
                    else if (choice == "2")
                    {
                        SolveQuadratic();
                    }
                    else if (choice == "0")
                    {
                        Console.WriteLine("Exiting Equation Solver. Goodbye!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice.\n");
                    }
                }
                catch (FormatException ex)
                {
                    System.Console.WriteLine($"Error: {ex.Message}\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}\n");
                }
            }
        }

        static void SolveLinear()
        {
            double a, b;
            Console.WriteLine("=== Solving Linear Equation: ax + b = 0 ===\n");

            a = ReadDouble("Enter coefficient a: ");
            b = ReadDouble("Enter coefficient b: ");
            Console.WriteLine();

            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Infinite solutions.");
                }
                else
                {
                    Console.WriteLine("No solution exists.");
                }
            }
            else
            {
                double x = -b / a;
                Console.WriteLine($"Solution: x = {x}");
            }
            Console.WriteLine();
        }

        static void SolveQuadratic()
        {
            double a, b, c;
            Console.WriteLine("=== Solving Quadratic Equation: ax^2 + bx + c = 0 ===\n");

            a = ReadDouble("Enter coefficient a: ");
            b = ReadDouble("Enter coefficient b: ");
            c = ReadDouble("Enter coefficient c: ");
            Console.WriteLine();

            if (a == 0)
            {
                Console.WriteLine("Not a quadratic equation (a = 0). Treating as linear.\n");

                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Infinite solutions.");
                    }
                    else
                    {
                        Console.WriteLine("No solution exists.");
                    }
                }
                else
                {
                    double x = -c / b;
                    Console.WriteLine($"Linear solution: x = {x}");
                }
                Console.WriteLine();
                return;
            }

            double discriminant = b * b - 4 * a * c;
            Console.WriteLine($"Discriminant: {discriminant}\n");
            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"Two real roots:");
                Console.WriteLine($"  x1 = {x1}");
                Console.WriteLine($"  x2 = {x2}");
            }
            else if (discriminant == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"One real root: x = {x}");
            }
            else
            {
                double real = -b / (2 * a);
                double imag = Math.Sqrt(-discriminant) / (2 * a);
                Console.WriteLine("Complex roots:");
                Console.WriteLine($"  x1 = {real} + {imag}i");
                Console.WriteLine($"  x2 = {real} - {imag}i");
            }
            Console.WriteLine();
        }

        static double ReadDouble(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                double value;
                if (double.TryParse(input, out value))
                    return value;
                Console.WriteLine("Invalid input. Please enter a numeric value.\n");
            }
        }
    }
}