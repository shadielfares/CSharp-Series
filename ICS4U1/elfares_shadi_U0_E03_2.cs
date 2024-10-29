// See https://aka.ms/new-console-template for more information
int a = 0;
int b = 0;
int c = 0;
int d = 0;
int e = 0;
int average = 0;

Console.Write("Please enter a variable: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter a variable: ");
b = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter a variable: ");
c = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter a variable: ");
d = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter a variable: ");
e = Convert.ToInt32(Console.ReadLine());

average = ((a + b + c + d + e) / 5);
Console.WriteLine("\nYour average is: "+ average.ToString("0.00"));