// See https://aka.ms/new-console-template for more information
int mark1 = 0;
int mark2 = 0;
int mark3 = 0;
int mark4 = 0;
double average = 0;

Console.WriteLine("Enter your value for mark 1: ");
mark1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your value for mark 2: ");
mark2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your value for mark 3: ");
mark3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your value for mark 4: ");
mark4 = Convert.ToInt32(Console.ReadLine());

average = ((mark1 + mark2 + mark3 + mark4) / 4);

if (average >= 90)
    Console.WriteLine("Your grade is A+");
else if (average >= 85)
    Console.WriteLine("Your grade is A");
else if (average >= 80)
    Console.WriteLine("Your grade is B+");
else if (average >= 75)
    Console.WriteLine("Your grade is B");
else if (average >= 70)
    Console.WriteLine("Your grade is C+");
else if (average >= 50)
    Console.WriteLine("Your grade is C");
else
    Console.WriteLine("Your grade is D");