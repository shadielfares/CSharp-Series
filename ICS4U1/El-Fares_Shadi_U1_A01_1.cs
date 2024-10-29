// See https://aka.ms/new-console-template for more information

double b = 0;
double h = 0;
double a = 0;

Console.WriteLine("Please enter a value for ‘b’: ");
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter a value for ‘h’: ");
h = Convert.ToInt32(Console.ReadLine());

a = ((double)1/2 * (b * h));

Console.WriteLine("--Area of triangle: " );
Console.WriteLine("a = ",  a);
Console.WriteLine("b = ",  b);
Console.WriteLine("Area = " + a.ToString("0.00"));

//-------------------------------------------------------------


double r = 0;
double p = Math.PI;
double c = 0;

Console.WriteLine("Please enter a value for 'r': ");
r = Convert.ToInt32(Console.ReadLine());

c = ((double)2 * p * r);

Console.WriteLine("--Circumference of a circle: ");
Console.WriteLine("r = ",  r);
Console.WriteLine("Circumference: " + c.ToString("0.00"));

//-------------------------------------------------------------

double a_2 = 0;
double b_2 = 0;
double c_2 = 0;

Console.WriteLine("Please enter a value for 'a': ");
a_2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter a value for 'b': ");
b_2 = Convert.ToInt32(Console.ReadLine());

c = Math.Sqrt((double)Math.Pow(a_2, 2) + Math.Pow(b_2, 2));
Console.WriteLine("--Pythagorean Theorem: ");
Console.WriteLine("a = ",  a_2);
Console.WriteLine("b = ",  b_2);
Console.WriteLine("C =  " + c_2.ToString("0.00"));