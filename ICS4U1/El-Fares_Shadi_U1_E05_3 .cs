// See https://aka.ms/new-console-template for more information
int a = 0;
int b = 0;


Console.Write("What is your first integer?: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("What is your second integer?: ");
b = Convert.ToInt32(Console.ReadLine());


Console.Write("*Swap* I will print your perceived first integer is: " + b);

Console.Write("\nYour second integer is now your first! Equaling: " + a);


