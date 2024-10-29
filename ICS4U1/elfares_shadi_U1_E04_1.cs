Console.WriteLine("What would you like the length to be:");
double len = double.Parse(Console.ReadLine());

Console.WriteLine("What would you like the width to be:");
double wid = double.Parse(Console.ReadLine());

void CalculateArea(double length, double width)
{
    double area = length * width;
    Console.WriteLine("Area is {0}", area);
}

CalculateArea(len, wid);