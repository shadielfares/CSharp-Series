// See https://aka.ms/new-console-template for more information
string myString = "Computer Science is the best course ever!";
Console.WriteLine(myString.Substring(0, 9));
Console.WriteLine(myString.Substring(9, 7));
Console.WriteLine(myString.Substring(17, 3));
Console.WriteLine(myString.Substring(20, 3));
Console.WriteLine(myString.Substring(24, 4));
Console.WriteLine(myString.Substring(29, 6));
Console.WriteLine(myString.Substring(36, 5));

Console.WriteLine(myString.IndexOf("course"));