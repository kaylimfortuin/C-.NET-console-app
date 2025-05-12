using System;

class HttpStatusCodeProcessor
{
    public static void Process()
    {
        int[] statusCodes = { 200, 404, 500, 201, 204 };
        int successCount = 0;

        for (int i = 0; i < statusCodes.Length; i++)
        {
            if (statusCodes[i] >= 200 && statusCodes[i] <= 299)
            {
                Console.WriteLine(statusCodes[i]);
                successCount++;
            }
        }

        Console.WriteLine("Total success codes: " + successCount);
    }
}