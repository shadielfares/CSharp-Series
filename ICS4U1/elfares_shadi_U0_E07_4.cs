// See https://aka.ms/new-console-template for more information

int count = 0;
Console.Write("How many numbers would you like to add: ");
count = Convert.ToInt32(Console.ReadLine());

int integer = 0, total = 0;
int maxInt = Int32.MinValue;
int minInt = Int32.MaxValue;
bool validinput = true;

for (int i = 0; i < count; i++)
{
try{
    Console.Write("What integer would you like to add: ");
    integer = Convert.ToInt32(Console.ReadLine());
}
catch{
validinput = false;
Console.WriteLine("Enter a valid response.");
break;

}
    total = total + integer;

    if (integer < minInt)
        minInt = integer;
    
    if (integer > maxInt)
        maxInt = integer;

}

double avg = total / count;
Console.Write("Your total is: " + total + '\n');
Console.Write("Your average is: " + avg.ToString("0.00"));
Console.Write("\nYour largest possible integer is: " + maxInt);
Console.Write("\nYour smallest possible integer is: " + minInt + '\n');