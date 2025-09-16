using System;

namespace Probability
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();
            Console.WriteLine("==============================");
            Console.WriteLine(" Probability Union Calculator ");
            Console.WriteLine("==============================");
            Console.WriteLine("This program calculates the probability of the union of two events.");
            Console.WriteLine("You can choose between mutually exclusive or inclusive (non-mutually exclusive) events.\n");

            bool continueProgram = true;
            while (continueProgram)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1.Mutually Exclusive Events");
                Console.WriteLine("2.Inclusive (Non-Mutually Exclusive) Events");
                Console.WriteLine("3.Exit");
                Console.Write("Enter your choice (1-3): ");

                string choice = Console.ReadLine() ?? string.Empty;
                Console.WriteLine();
                if (choice == "1")
                {
                    CalculateMutuallyExclusive();
                }
                else if (choice == "2")
                {
                    CalculateInclusive();
                }
                else if (choice == "3")
                {
                    continueProgram = false;
                    Console.WriteLine("Thank you for using the Probability Union Calculator. Goodbye!");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.\n");
                }
                if (continueProgram)
                {
                    Console.WriteLine("\nWould you like to perform another calculation? (y/n): ");
                    string again = Console.ReadLine() ?? string.Empty;
                    if (!again.Trim().ToLower().StartsWith("y"))
                    {
                        continueProgram = false;
                        Console.WriteLine("Thank you for using the Probability Union Calculator. Goodbye!");
                    }
                    Console.WriteLine();
                }
            }
        }

        // Calculates for mutually exclusive events
        static void CalculateMutuallyExclusive()
        {
            Console.WriteLine("--- Mutually Exclusive Events ---");
            double pA = GetProbabilityInput("Enter the probability of event A (P(A)): ");
            double pB = GetProbabilityInput("Enter the probability of event B (P(B)): ");

            double union = pA + pB;
            if (union > 1)
            {
                Console.WriteLine("Warning: The sum of P(A) and P(B) exceeds 1. Please check if the events are truly mutually exclusive.\n");
            }
            Console.WriteLine($"P(A u B) = P(A) + P(B) = {pA} + {pB} = {union}");
        }

        // Calculates for inclusive (non-mutually exclusive) events
        static void CalculateInclusive()
        {
            Console.WriteLine("--- Inclusive (Non-Mutually Exclusive) Events ---");
            double pA = GetProbabilityInput("Enter the probability of event A (P(A)): ");
            double pB = GetProbabilityInput("Enter the probability of event B (P(B)): ");
            double pAandB = GetProbabilityInput("Enter the probability of both events occurring (P(A and B)): ");

            // Validation: P(A and B) cannot be greater than P(A) or P(B)
            if (pAandB > pA)
            {
                Console.WriteLine("Error: P(A and B) cannot be greater than P(A). Please try again.\n");
                return;
            }
            else if (pAandB > pB)
            {
                Console.WriteLine("Error: P(A and B) cannot be greater than P(B). Please try again.\n");
                return;
            }

            double union = pA + pB - pAandB;
            if (union < 0)
            {
                Console.WriteLine("Warning: The calculated union probability is less than 0. Please check your inputs.\n");
            }
            else if (union > 1)
            {
                Console.WriteLine("Warning: The calculated union probability is greater than 1. Please check your inputs.\n");
            }
            Console.WriteLine($"P(A u B) = P(A) + P(B) - P(A ∩ B) = {pA} + {pB} - {pAandB} = {union}");
        }

        // Gets a probability input from the user, validates range and handles errors
        static double GetProbabilityInput(string prompt)
        {
            double value;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine() ?? string.Empty;
                try
                {
                    value = Convert.ToDouble(input);
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException("Probability must be between 0 and 1 (inclusive).");
                    }
                    else if (value > 1)
                    {
                        throw new ArgumentOutOfRangeException("Probability must be between 0 and 1 (inclusive).");
                    }
                    // Only break if input is valid
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Please enter a valid numeric value between 0 and 1.");
                }
                catch (InvalidCastException)
                {
                    Console.WriteLine("Error: Please enter a valid numeric value between 0 and 1.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Error: The number entered is too large or too small.");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                // Loop continues if input is invalid
            }
            return value;
        }
    }
}