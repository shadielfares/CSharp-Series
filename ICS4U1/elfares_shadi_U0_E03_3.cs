Console.WriteLine("Please enter the number of apples: ");
int apples = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter the price per apple: ");
double applePrice = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please enter the tax (hst): ");
double hst = Convert.ToDouble(Console.ReadLine());
//Calcs
double subtotal = (apples * applePrice);
double tax = (subtotal * hst);
double total = (subtotal + tax);

Console.WriteLine(" "
    + "\nSubtotal:" + '$' + Math.Round(subtotal, 2)
    + "\nHST: " + '$' + Math.Round(tax, 2)
    + "\nTotal: " + '$' + Math.Round(total, 2));
