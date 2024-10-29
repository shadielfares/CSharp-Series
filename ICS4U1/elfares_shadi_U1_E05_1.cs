double len = 0;
double wid = 0;

Console.WriteLine("Please enter a length: ");
len = double.Parse(Console.ReadLine());

Console.WriteLine("Please enter a width: ");
wid = double.Parse(Console.ReadLine());

double CalculateArea(double length, double width)
{
    double area = len * wid;
    return area;
}

Console.WriteLine("The area is {0} units squared.", CalculateArea(len, wid));