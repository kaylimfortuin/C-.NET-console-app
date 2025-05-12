// int can store values from -2,147,483,648 to 2,147,483,647 because its 32 bit
//long can store values from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 because its 64 bit
//long can store larger values than int

//checked() is used to check for overflow in arithmetic operations

// int a = 2100000000;
// int b = 2100000000;
// long c = (long)a + (long)b;
// Console.WriteLine(c);

//double is a floating point number and can store decimal values
//float is a single precision floating point number and can store decimal values with less precision than double
// double a = 42.1; //natural type
// float b = 38.1F;
// double c = a + b;
// Console.WriteLine(c);

//decimal is a 128 bit data type and can store decimal values with high precision
decimal a = 42.1M; //explicite type type
decimal b = 38.2M;
decimal c = a + b;
Console.WriteLine($"the answer for this is {c}");