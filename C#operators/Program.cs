string yearofservice = string.Empty;
string performance = string.Empty;
string department = string.Empty;

//title
Console.WriteLine("Welcome to the Employee Bonus Calculator!");
bool[,] pattern = new bool[,]
        {
            { true, true, false, true, true, false, true, true },
            { true, false, true, false, false, true, false, true },
            { true, true, true, false, true, true, true, false },
            { false, false, true, true, false, false, true, true },
            { true, true, false, true, false, true, false, false },
            { false, true, true, false, true, false, true, true }
        };

        // Characters for filled and empty blocks
        string filled = "██";
        string empty = "  ";

        // Get console width to center pattern
        int consoleWidth = Console.WindowWidth;

        // Each "cell" is 2 characters wide
        int patternWidth = pattern.GetLength(1) * filled.Length;

        // Calculate starting position for centering
        int margin = (consoleWidth - patternWidth) / 2;
        string leftPadding = new string(' ', Math.Max(0, margin));

        // Render the pattern
        for (int row = 0; row < pattern.GetLength(0); row++)
        {
            Console.Write(leftPadding);
            for (int col = 0; col < pattern.GetLength(1); col++)
            {
                Console.Write(pattern[row, col] ? filled : empty);
            }
            Console.WriteLine();
        }

// Prompt the user for input
Console.WriteLine("Enter your years of service: ");
yearofservice = Console.ReadLine();
if (!int.TryParse(yearofservice, out int years) || years < 1 || years > 40)
{
    Console.WriteLine("Invalid input. Please enter a number between 1 and 40.");
    return;
}
Console.WriteLine("Enter your performance rating (1-5): ");
performance = Console.ReadLine();
if (!int.TryParse(performance, out int rating) || rating < 1 || rating > 5)
{
    Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
    return;
}
Console.WriteLine("Enter your department (HR, IT, Sales): ");
department = Console.ReadLine();
if (department != "HR" && department != "IT" && department != "Sales")
{
    Console.WriteLine("Invalid input. Please enter one of the following departments: HR, IT, Sales.");
    return;
}

// Process the information
Console.WriteLine("Calculating your bonus...");
System.Threading.Thread.Sleep(2000); 
if (Convert.ToInt32(yearofservice) >= 5 && Convert.ToInt32(performance) >= 4)
{
    Console.WriteLine("High bonus of $5000.");
}
else if (Convert.ToInt32(yearofservice) >= 3 && Convert.ToInt32(performance) >= 3 && (department == "IT" || department == "Sales"))
{
    Console.WriteLine("Standard bonus of $3000.");
}
else if (Convert.ToInt32(performance) >= 3 || (Convert.ToInt32(yearofservice) >= 2 && department == "HR"))
{
    Console.WriteLine("Moderate bonus of $1500.");
}
else if (Convert.ToInt32(yearofservice) >= 1 && Convert.ToInt32(performance) >= 2)
{
    Console.WriteLine("Entry level bonus of $500.");
}
else
{
    Console.WriteLine("You are not eligible for a bonus.");
}