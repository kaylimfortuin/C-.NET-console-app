//var is a keyword that allows you to declare a variable without specifying its type
// new is a keyword that allows you to create a new instance of an object
// List is a class that represents a collection of objects
//foreach is a keyword that allows you to iterate over a collection
// var names = new List<string> {"Kaylim", "Ana", "Felipe"}; // we us {}
// names.Add("David");
// names.Add("Tkeiah");
// names.Add("Jasmine");

// foreach (var name in names[2..4])  //.. is a range operator that allows you to specify a range of elements in a collection and it is inclusive and exclusive meaning up to and including 4
// {
//     Console.WriteLine($"Hello {name.ToUpper()}!");
// }

// Console.WriteLine(names[0]);
// Console.WriteLine(names[2]);
// Console.WriteLine(names[^1]); 
// //count is a property that returns the number of elements in the list and -1 is used to get the last element Console.WriteLine(names[names.Count-1]);
// // Console.WriteLine(names[^1]); means the last element in the list even thou we start counting at 0 

// //arrays are fixed in size and cannot be changed after they are created and are fixed in length
// var names = new string [] {"Kaylim", "Ana", "Felipe"}; //we use [] to create an array
// // names.Add("David"); // this will not work because arrays are fixed in size
// names = [..names, "tkeiah"]; //this will work because we are creating a new array with the same elements as the old array and adding a new element to it
// foreach (var name in names)
// {
//     Console.WriteLine($"Hello {name.ToUpper()}!");
// }

//void means theres no return value

//sorting the list
// var names = new List<string> {"kaylim", "Ana", "Felipe"};
// names.Sort(); // this will sort the list in ascending order

// foreach (var name in names)
// {
//     Console.WriteLine($"{name}");
// }

//list of int
var numbers = new List<int> {45,543,677,433,45,43,56};

Console.WriteLine($"i found 45 at Index of {numbers.IndexOf(433)}");
numbers.Sort();
Console.WriteLine($"i found 45 at Index of {numbers.IndexOf(433)}"); // this will return the index of the first occurrence of 45 in the list

// foreach ( var number in numbers)
// {
//     Console.WriteLine(number);
// }

