try
{
    System.Console.WriteLine("Enter your age: ");
    int age = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine($"You are {age} years old");
}

// catch (Exception) //the handles all errors that might occur
// {
//     System.Console.WriteLine("enter a WHOLE number");
//     throw;
// }

catch (FormatException)
{
    System.Console.WriteLine("Enter a whole number");
    //throw;
}

//when you add throw it shows you what the type of exception is and where it is comming from so you can handle the error better


