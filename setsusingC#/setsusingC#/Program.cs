using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter Student ID into Univeral set: ");
            string uInput = Console.ReadLine();
            HashSet<int> U = new HashSet<int>();
            foreach (string value in uInput.Split(','))
            {
                U.Add(Convert.ToInt32(value.Trim()));
            }

            System.Console.Write("Enter Student ID into Course A: ");
            string aInput = Console.ReadLine();
            HashSet<int> A = new HashSet<int>();
            foreach (string value in aInput.Split(','))
            {
                A.Add(Convert.ToInt32(value.Trim()));
            }

            System.Console.Write("Enter Student ID into Course B: ");
            string bInput = Console.ReadLine();
            HashSet<int> B = new HashSet<int>();
            foreach (string value in bInput.Split(','))
            {
                B.Add(Convert.ToInt32(value.Trim()));
            }

            try
            {
                System.Console.WriteLine($"\nUniversal Set: {string.Join(", ", U)}");
                System.Console.WriteLine($"Students in Course A: {string.Join(", ", A)}");
                System.Console.WriteLine($"Students in Course B: {string.Join(", ", B)}\n");

                System.Console.WriteLine("==Union of A and B==");
                var union = UnionOfAAndB(A, B);
                System.Console.WriteLine($"Union of A and B: {string.Join(", ", union)}\n");

                System.Console.WriteLine("==Intersection of A and B==");
                var intersection = IntersectionOfAAndB(A, B);
                System.Console.WriteLine($"Intersection of A and B: {string.Join(", ", intersection)}\n");

                System.Console.WriteLine("==Complement of A==");
                var complement = ComplementOfA(U, A);
                System.Console.WriteLine($"Intersection of A and B: {string.Join(", ", complement)}\n");

                System.Console.WriteLine("==Complement of B==");
                var complementb = ComplementOfB(U, B);
                System.Console.WriteLine($"Intersection of A and B: {string.Join(", ", complementb)}\n");

            }
            catch (FormatException)
            {
                System.Console.WriteLine("Error: invalid input format. please enter only integers separated by commas");
            }
            catch (OverflowException)
            {
                System.Console.WriteLine("Error: number to large.");
            }
            catch (ArgumentException)
            {
                System.Console.WriteLine("Error: invalid argument");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"Error: {ex}");
            }
        }
        static HashSet<int> UnionOfAAndB(HashSet<int> A, HashSet<int> B)
        {
            var result = new HashSet<int>(A);
            result.UnionWith(B);
            return result;
        }

        static HashSet<int> IntersectionOfAAndB(HashSet<int> A, HashSet<int> B)
        {
            var result = new HashSet<int>(B);
            result.IntersectWith(A);
            return result;
        }

        static HashSet<int> ComplementOfA(HashSet<int> U, HashSet<int> A)
        {
            var result = new HashSet<int>(U);
            result.ExceptWith(A);
            return result;
        }

        static HashSet<int> ComplementOfB(HashSet<int> U, HashSet<int> B)
        {
            var result = new HashSet<int>(U);
            result.ExceptWith(B);
            return result;
        }
    }
}