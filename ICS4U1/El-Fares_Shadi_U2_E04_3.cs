// See https://aka.ms/new-console-template for more information
double var = 0;

Console.Write("Please enter a positive even number: ");
var = Convert.ToDouble(Console.ReadLine());

double? dec = var - (int)var;

int even_indicator = (int)var % 2;

//if even indicator equals 1 then its odd
//if dec is greater than zero it means that after being subtracted by its integer, the difference is a decimal.
//if var is greater than zero it means its positive

if (var > 0 && even_indicator == 0  && dec > 0)
    Console.WriteLine("You entered a positive, even decimal number.");
else if (var > 0 && even_indicator == 0 && dec == 0)
    Console.WriteLine("You entered a positive, even integer number.");
else if (var < 0 && even_indicator == 0 && dec == 0)
    Console.WriteLine("You did not enter a positive, even number.");
else if (var < 0 && even_indicator == 0 && dec > 0)
    Console.WriteLine("You did not enter a positive, even number.");