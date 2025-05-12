// int a = 5;
// int b = 6;
// int c = a + b;

// bool myTest= c>10; //wll be true or false

// if (myTest){//is true
//     Console.WriteLine("The answer is greater than 10.");
// }
// else{
//     Console.WriteLine("The anser is less than 10'");
// }

//the && operator is used to combine two boolean expressions and shows both is true
// int a = 5;
// int b = 3;
// int c = 4;
// if ((a + b + c > 10) && (a == b))//&& mean and, == means equal not the same as =
// {
//     Console.WriteLine("The answer is greater than 10");
//     Console.WriteLine("And the first number is equal to the second");
// }
// else
// {
//     Console.WriteLine("The answer is not greater than 10");
//     Console.WriteLine("Or the first number is not equal to the second");
// } 

//|| operator is used to combine two boolean expressions and shows either one is true
// int a = 5;
// int b = 3;
// int c = 4;
// if ((a + b + c > 10) || (a == b))
// {
//     Console.WriteLine("The answer is greater than 10");
//     Console.WriteLine("And the first number is equal to the second");
// }
// else
// {
//     Console.WriteLine("The answer is not greater than 10");
//     Console.WriteLine("Or the first number is not equal to the second");
// }

//while loop
// int counter = 0;
// while (counter < 5)
// {
//     Console.WriteLine("Counter is: " + counter);
//     counter++;
// }
// {
//     Console.WriteLine(counter);
//     counter++;
// }

//do while loop
// int counter = 10;
// do
// {
//     Console.WriteLine(counter);
//     counter++;
// } while (counter < 5);

//for loop
/*
for (
    int i = 0; //setup/initialization (start)
    i < 5; // condition (end)
    i++) // increment (step)  for (int i = 0; i < 5; i++)
{
    //do the thing
    Console.WriteLine(i);
}
*/

// for (int i = 0; i < 5; i++)
// {
//     if (i == 3)
//     {
//         Console.WriteLine(i);
//     }
// }

//nested loops
//generate rowa
// for (int row = 1; row < 11; row++)
// {
//     Console.WriteLine($"The row is {row}");
// }

// //generate columns
// for (char column = 'a'; column < 'k'; column++)
// {
//     Console.WriteLine($"The column is {column}");
// }

//nested for loop
for (int row = 1; row < 11; row++)
{
    for (char column = 'a'; column < 'k'; column++)
    {
        Console.WriteLine($"The cell is ({row}, {column})");
    }
}