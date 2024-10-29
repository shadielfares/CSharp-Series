Console.WriteLine("Please enter the number electricity units used:");
int usedunits = Convert.ToInt32(Console.ReadLine());

double bill = 0;

if (usedunits <= 50)
{
    bill = usedunits * 0.5;
}
else if (usedunits <= 150)
{
    bill = 50 * 0.5 + (usedunits - 50) * 0.75;
}
else if (usedunits <= 250)
{
    bill = 50 * 0.5 + 100 * 0.75 + (usedunits - 150) * 1.20;
}
else
{
    bill = 50 * 0.5 + 100 * 0.75 + 100 * 1.20 + (usedunits - 250) * 1.50;
}

double surcharge = bill * 0.2;
double totalbill = bill + surcharge;

Console.WriteLine("Your electricity bill is: $" + totalbill.ToString("0.00"));