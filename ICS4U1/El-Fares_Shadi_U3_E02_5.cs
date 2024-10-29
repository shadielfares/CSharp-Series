// See https://aka.ms/new-console-template for more information\

int a = 0;
int b = 1;

Console.Write("Enter an integer number greater than 0: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write(a + "! = ");

for (;a >= 1;)
{
if(a == 1)
{
break;
} 
Console.Write(a);
Console.Write(" x ");
b *= a;
a--;

}

Console.WriteLine(a + " = {0}", b);
Console.ReadLine();