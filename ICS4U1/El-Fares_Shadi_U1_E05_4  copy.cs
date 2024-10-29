// See https://aka.ms/new-console-template for more information
int ax = 0;
int bx = 0;
int ay = 0;
int by = 0;

Console.Write("What is your first x co-ordinate?: ");
ax = Convert.ToInt32(Console.ReadLine());

Console.Write("What is your second x co-ordinate?: ");
bx = Convert.ToInt32(Console.ReadLine());

Console.Write("What is your first y co-ordinate?: ");
ay = Convert.ToInt32(Console.ReadLine());

Console.Write("What is your second y co-ordinate?: ");
by = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow((by - ay), 2));

Console.Write("Your distance is: " + d.ToString("0.00"));
