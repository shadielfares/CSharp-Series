// See https://aka.ms/new-console-template for more information
int var1 = 0;
int var2 = 0;
int var3 = 0;
bool validinteger = true;

try
{
Console.WriteLine("Please enter in your first unique variable: ");
var1 = Convert.ToInt32(Console.ReadLine());   
}
catch
{
validinteger = false;
}

try
{
Console.WriteLine("Please enter in your second unique variable: ");
var2 = Convert.ToInt32(Console.ReadLine());  
}
catch
{
validinteger = false;
}

try
{
Console.WriteLine("Please enter in your third unique variable: ");
var3 = Convert.ToInt32(Console.ReadLine());
}
catch
{
validinteger = false;
}


if (var1)
    Console.Write("Your integers are not unique.");
else
    Console.Write("Your integers are unique.");