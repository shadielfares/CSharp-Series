// See https://aka.ms/new-console-template for more information
double mark = 0, total = 0;
int x = 1;
while(x < 6)
{
Console.Write("Enter course mark " + x + ": ");
mark = Convert.ToDouble(Console.ReadLine());
total = total + mark;
x++;
}
double avg = total / 5.0;
Console.WriteLine("Your average is: " + avg);