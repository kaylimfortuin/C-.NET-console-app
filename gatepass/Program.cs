        string yearofservice = string.Empty;
        string performance = string.Empty;
        string department = string.Empty;

        // Prompt the user for input
        Console.WriteLine("Enter your years of service: ");
        yearofservice = Console.ReadLine();

        Console.WriteLine("Enter your performance rating (1-5): ");
        performance = Console.ReadLine();

        Console.WriteLine("Enter your department (HR, IT, Sales): ");
        department = Console.ReadLine();

        // Check if inputs are digits only
        if (!IsDigitsOnly(yearofservice) || !IsDigitsOnly(performance))
        {
            Console.WriteLine("Invalid input. Years of service and performance must be positive numbers only.");
            return;
        }

        int years = Convert.ToInt32(yearofservice);
        int rating = Convert.ToInt32(performance);

        // Validate that numbers are positive and within valid range
        if (years < 1 || years > 40)
        {
            Console.WriteLine("Years of service must be between 1 and 40.");
            return;
        }

        if (rating < 1 || rating > 5)
        {
            Console.WriteLine("Performance rating must be between 1 and 5.");
            return;
        }

        // Validate department (case-sensitive)
        if (!(department == "HR" || department == "IT" || department == "Sales"))
        {
            Console.WriteLine("Department must be HR, IT, or Sales.");
            return;
        }

        // Process the bonus logic
        if (years >= 5 && rating >= 4)
        {
            Console.WriteLine("High bonus of $5000.");
        }
        else if (years >= 3 && rating >= 3 && (department == "IT" || department == "Sales"))
        {
            Console.WriteLine("Standard bonus of $3000.");
        }
        else if (rating >= 3 || (years >= 2 && department == "HR"))
        {
            Console.WriteLine("Moderate bonus of $1500.");
        }
        else if (years >= 1 && rating >= 2)
        {
            Console.WriteLine("Entry level bonus of $500.");
        }
        else
        {
            Console.WriteLine("You are not eligible for a bonus.");
        }

    // Helper method to check if a string contains only digits
    static bool IsDigitsOnly(string str)
    {
        foreach (char c in str)
        {
            if (c < '0' || c > '9')
                return false;
        }
        return true;
    }   