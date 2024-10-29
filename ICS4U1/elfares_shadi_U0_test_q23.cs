int num;

try
{
    Console.Write("Enter an integer between 1 and 10: ");
    num = int.Parse(Console.ReadLine());
    
    if (num >= 1 && num <= 10 && num % 2 != 0)
    {
        Console.WriteLine($"{num} is an odd number between 1 and 10.");
    }
    else
    {
        Console.WriteLine($"{num} is not an odd number between 1 and 10.");
    }
}
catch
{
    Console.WriteLine("Invalid input. Please enter an integer.");
}
