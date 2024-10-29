Console.WriteLine("Please input the following for A: ");

Console.WriteLine("x1: ");
    double x1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("y1: ");
    double y1 = Convert.ToDouble(Console.ReadLine());
    
Console.WriteLine("Please input the following for B: ");

Console.WriteLine("x2: ");
    double x2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("y2: ");
    double y2 = Convert.ToDouble(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

Console.WriteLine("Answer: " + Math.Round(d, 2));