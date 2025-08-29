using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace ExponentialGrowth
{
    class Program
    {
        static void Main()
        {
            // Input
            double principal = ReadPositiveDouble("Enter principal (P): ");
            double rate = ReadDouble("Enter annual interest rate (r) (e.g., 0.05 for 5%): ");
            double tStart = ReadPositiveDouble("Enter start time (years): ");
            double tEnd = ReadPositiveDouble("Enter end time (years): ");
            double tStep = ReadPositiveDouble("Enter step size (years): ");
            if (tStart >= tEnd) { Console.WriteLine("Start time must be less than end time."); return; }
            if (tStep > (tEnd - tStart)) { Console.WriteLine("Step size too large."); return; }

            // Calculation
            var results = CalculateGrowth(principal, rate, tStart, tEnd, tStep);

            // Output table
            Console.WriteLine("\nTime (t)   Value (A)");
            foreach (var (t, A) in results)
                Console.WriteLine($"{t,8:F2} {A,10:F2}");

            // Analysis
            double pctChange = 100 * (results[^1].A - results[0].A) / results[0].A;
            string trend = rate > 0 ? "growing" : rate < 0 ? "depreciating" : "unchanged";
            Console.WriteLine($"\nInvestment is {trend}. Change: {pctChange:F2}%");

            // Save option
            Console.Write("Save results to InvestmentGrowth.txt? (y/n): ");
            var saveInput = Console.ReadLine();
            if (saveInput != null && saveInput.Trim().ToLower() == "y")
                SaveToFile(results);
        }

        // Prompt for a positive double
        static double ReadPositiveDouble(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.InvariantCulture, out double v) && v > 0)
                    return v;
                Console.WriteLine("Enter a positive number.");
            }
        }

        // Prompt for any double
        static double ReadDouble(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.InvariantCulture, out double v))
                    return v;
                Console.WriteLine("Enter a valid number.");
            }
        }

        // Calculate investment values for each t
        static List<(double t, double A)> CalculateGrowth(double principal, double rate, double tStart, double tEnd, double tStep)
        {
            var results = new List<(double t, double A)>();
            for (double t = tStart; t <= tEnd + 1e-8; t += tStep)
                results.Add((t, principal * Math.Exp(rate * t)));
            return results;
        }

        // Save results to file
        static void SaveToFile(List<(double t, double A)> results)
        {
            try
            {
                using var sw = new StreamWriter("InvestmentGrowth.txt");
                sw.WriteLine("Time (t)   Value (A)");
                foreach (var (t, A) in results)
                    sw.WriteLine($"{t,8:F2} {A,10:F2}");
                Console.WriteLine("Results saved to InvestmentGrowth.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"File error: {ex.Message}");
            }
        }
    }
}
