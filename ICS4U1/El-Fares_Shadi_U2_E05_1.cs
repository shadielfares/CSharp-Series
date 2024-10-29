// See https://aka.ms/new-console-template for more information
double var1 = 0;
double var2 = 0;
double var3 = 0;
bool validinteger = true;


 try
{
Console.WriteLine("Please enter in your first unique variable: ");
var1 = Convert.ToInt32(Console.ReadLine());

}
catch
{
    validinteger = false;

if (!validinteger)
    Console.Write("Enter a valid entry.");
else
    Console.Write("Your integers are unique.");

}
try
{
Console.WriteLine("Please enter in your second unique variable: ");
var2 = Convert.ToInt32(Console.ReadLine());
if (var1 == var2)
    validinteger = false;
if (!validinteger)
    Console.Write("Enter a valid entry.");
else
    Console.Write("Your integers are unique.");
}
catch
{

    validinteger = false;

if (!validinteger)
    Console.Write("Enter a valid entry.");
else
    Console.Write("Your integers are unique.");
}
try
{
if (var1 != var2)
    Console.WriteLine("Please enter in your third unique variable: ");
    var3 = Convert.ToInt32(Console.ReadLine());
if (var1 == var2 ||var2 == var3 || var1 == var3)
    validinteger = false;
if (!validinteger)
    Console.Write("Enter a valid entry.");
else
    Console.Write("Your integers are unique.");
}
catch
{
if (!validinteger)
    Console.Write("Enter a valid entry.");
else
    Console.Write("Your integers are unique.");
}