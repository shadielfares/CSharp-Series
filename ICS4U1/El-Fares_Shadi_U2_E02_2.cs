// See https://aka.ms/new-console-template for more information
int c = 0;
int f = 0;
string? response = "";
double returnVal = 0;

Console.WriteLine("Do you wish to convert from Celsius or Fahrenheit: ");
response = Console.ReadLine().ToUpper();

if (response == "CELSIUS")
{
    Console.WriteLine("What is the value of Celsius you wish to convert to Fahrenheit: ");
    c = Convert.ToInt32(Console.ReadLine());
    returnVal = ((c *1.8000) + 32);
    Console.WriteLine("Your Celsius to Fahrenheit value is: " + returnVal);
}
    

else if (response == "FAHRENHEIT")
{
    Console.WriteLine("What is the value of Fahrenheit you wish to convert to Celsius: ");
    f = Convert.ToInt32(Console.ReadLine());
    returnVal = ((f - 32) / 1.8000);
    Console.WriteLine("Your Fahrenheit to Celsius value is: " + returnVal);
}
    