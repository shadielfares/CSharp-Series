Console.WriteLine("Please enter variable x: ");
    double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please enter variable y: ");
    double y = Convert.ToDouble(Console.ReadLine());

double temp = x;
x = y; 
y = temp;


Console.WriteLine("Variables have swapped x is now: " + x);
Console.WriteLine("Variables have swapped y is now: " + y);
