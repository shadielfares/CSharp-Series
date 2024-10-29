// See https://aka.ms/new-console-template for more information\

int a = 0;
int b = 1;
int c = 0;
Console.Write("Enter your number to check if that number is prime or not: ");
a = Convert.ToInt32(Console.ReadLine());

for (;b <= a; b++) 
{
   if (a % b == 0) 
      c++;
   
}

if (c == 2)
    Console.WriteLine(a + " is a Prime number.");
else
    Console.WriteLine(a + " is not a Prime Number.");