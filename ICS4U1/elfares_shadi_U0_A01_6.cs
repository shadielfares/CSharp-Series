int factorial = 1;
int var = -1;

while (var < 0)
{
    Console.Write("Enter a non-negative integer: ");
    try
    {
        var = Convert.ToInt32(Console.ReadLine());
        if (var < 0)
        {
            Console.WriteLine("Fix your response and enter a non-negative integer.");
            var = -1;
        }
        else if (var == 0)
        {
            Console.WriteLine("0! = 1");
        }
        else
        {
            for (int x = 1; x <= var; x++)
            {
                factorial *= x;
            }
            Console.WriteLine("{0}! = {1}", var, factorial);
        }
    }
    catch 
    {
        Console.WriteLine("Fix your response and enter a non-negative integer.");
    }
}
