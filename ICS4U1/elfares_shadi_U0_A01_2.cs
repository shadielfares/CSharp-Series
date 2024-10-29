Console.WriteLine("Johhny how many nickels do you have: ");
double nickels = Convert.ToDouble(Console.ReadLine()) * 0.05;

Console.WriteLine("Johhny how many dimes do you have: ");
double dimes = Convert.ToDouble(Console.ReadLine()) * 0.10;

Console.WriteLine("Johhny how many quarters do you have: ");
double quarters = Convert.ToDouble(Console.ReadLine()) * 0.25;

Console.WriteLine("Johhny how many loonies do you have: ");
double loonies = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Johhny how many toonies do you have: ");
double toonies = Convert.ToDouble(Console.ReadLine()) * 2.00;

Console.WriteLine("Johhny how much is the item: ");
double item = Convert.ToDouble(Console.ReadLine());

double total = nickels + dimes + quarters + loonies + toonies;
double remainder  = total - item;


Console.WriteLine("Your remainder is: " + remainder.ToString("0.00"));
