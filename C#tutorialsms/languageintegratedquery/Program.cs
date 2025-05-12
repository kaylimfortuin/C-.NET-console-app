//LINQ is a powerful feature in C# that allows you to query collections in a more readable and concise way.
// int [] means an array of integers.
//Li<int> is a generic type that can be used to create a list of any type.

// Specify the data source.
// List<int> scores = [97, 92, 81, 60,];

//alternaive
// for (int i = 0; i < scores.Count; i++)
// {
//    if(scores[i] > 80)
//    {
//     Console.WriteLine($"found a score over 80: {scores [i]}");
//    } 
// }
// return;

// Define the query expression.
// IEnumerable<int> scoreQuery =  //IEnumerable is a generic interface that defines a method for iterating over a collection.
//     from score in scores
//     where score > 80
//     orderby score descending
//     select score;

// // Execute the query.
// foreach (var i in scoreQuery)
// {
//     Console.Write($"{i} ");
// }

// Output: 97 92 81


//<string> is a data type that represents a sequence of characters.
// IEnumerable<string> is a generic interface that defines a method for iterating over a collection of strings.
// IEnumerable<string> ScoresQuery =
//     from score in scores
//     where score > 80
//     orderby score descending
//     select $"The score is {score}";

// //we can say Console.WriteLine(ScoresQuery.Count()); or you can put the whole thing in () and say .count() refer to line 49-53

// foreach (string i in ScoresQuery)
// {
//     Console.WriteLine(i);
// }

// var highScoreCount = (
//     from score in scores
//     where score > 80
//     select score
// ).Count();

//alternative

List<int> scores = [97, 92, 81, 60,];

// Define the query expression.
IEnumerable<int> ScoresQuery =
    from score in scores
    where score > 80
    orderby score descending
    select score;


//this is a lambda expression
var ScoresQuery2 = scores.Where(s => s > 80)
                        .OrderByDescending(s => s);

List<int> myScores = ScoresQuery.ToList();  //ToList() is a method that converts the IEnumerable<T> to a List<T>.

foreach (var score in myScores)
{
    Console.WriteLine(score);
}

