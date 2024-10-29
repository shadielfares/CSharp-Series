// See https://aka.ms/new-console-template for more information
int var = 0;
int div = 2;
int mod_num = 0;

Console.WriteLine("Please enter an integer greater than zero: ");
var = Convert.ToInt32(Console.ReadLine());

mod_num = var % div;
 
if (mod_num == 1)
    Console.WriteLine("Your number is odd");
else
{
    Console.WriteLine("Your number is even");
}
