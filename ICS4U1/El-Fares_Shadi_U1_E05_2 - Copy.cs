// See https://aka.ms/new-console-template for more information
int apples = 0;
double Papples = 0;
double tax_percent = 0;

Console.Write("How many apples would you like today?: ");
apples = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the price per apple?: ");
Papples = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the tax rate in `0.00` form?: ");
tax_percent = Convert.ToDouble(Console.ReadLine());

double subtotal = apples * Papples;
double tax = subtotal * tax_percent;
double total = subtotal + tax;

Console.Write("\nYour subtotal is: " + (subtotal).ToString("0.00"));
Console.Write("\nYour tax portion is: " + ((double)tax).ToString("0.00"));
Console.Write("\nYour total is: " + (total).ToString("0.00"));
