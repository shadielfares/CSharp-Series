// See https://aka.ms/new-console-template for more information
//This program prints the year of 2021, the first month '01' of January and double the 10th day of the month.

int a = 0, b = 0, c = 0, d = 0, e = 0;

Console.Write("Please enter a variable: ");
a = Convert.ToInt32(Console.Readline());

Console.Write("Please enter a variable: ");
b = Convert.ToInt32(Console.Readline());

Console.Write("Please enter a variable: ");
c = Convert.ToInt32(Console.Readline());

Console.Write("Please enter a variable: ");
d = Convert.ToInt32(Console.Readline());

Console.Write("Please enter a variable: ");
e = Convert.ToInt32(Console.Readline());


average = ((a + b + c + d + e) / 7);
Console.WriteLine("\nYour average is: "+ average.ToString("0.00"));