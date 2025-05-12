using System;

class CountDivisibleByThree
{
    public static void Count()
    {
        int count = 0;
        for (int i = 10; i >= 1; i--)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);
                count++;
            }
        }
        Console.WriteLine("Total count of numbers divisible by 3: " + count);
    }
}