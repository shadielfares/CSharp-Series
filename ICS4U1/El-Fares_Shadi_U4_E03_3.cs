//Initalized Vars
Random rnd = new Random();
char randomChar = (char)rnd.Next('a', 'z');
char[,] arr = new char[5, 5];
bool booleanvar = false;
//Check for chars existence
for (int x = 0; x < 5; x++)
{
    for (int y = 0; y < 5; y++)
    {
        arr[x, y] = randomChar;
        for (int z = 0; z < 5; z++)
        {
            for (int w = 0; w < 5; w++)
            {
                while (arr.Cast<char>().Contains(randomChar))
                {
                    randomChar = (char)rnd.Next('a', 'z');

                    if (arr[4, 4] != '\0')
                    {
                        break;
                    }
                }
            }
        }
    }
}
int b = 0, c = 0;
char d = '\0';
//Write if not exited
while (b != -1 || c != -1)
{
    for (int x = 0; x < 5; x++)
    {
        for (int y = 0; y < 5; y++)
        {
            Console.Write(arr[x, y]);
        }
        Console.Write("\n");
    }
    Console.Write("\n");
//Ask for vars
    try
    {
        Console.Write("If you wish to exit, enter: -1.\n");
        Console.Write("X-Coordinate between(0-4): ");
        b = Convert.ToInt32(Console.ReadLine());

        if (b == -1)
        {
            break;
        }

        Console.Write("\n");

        Console.Write("If you wish to exit, enter: -1.\n");
        Console.Write("Y-Coordinate between (0-4): ");
        b = Convert.ToInt32(Console.ReadLine());

        if (c == -1)
        {
            break;
        }

        Console.Write("\n");

        Console.Write("Please enter a letter to replace the letter at your co-ordinates: ");
        d = Convert.ToChar(Console.ReadLine());
    }
    catch
    //Check for a value
    {
        Console.WriteLine("Enter an acceptable value.");
    }
    for (int x = 0; x < 5; x++)
    {
        for (int y = 0; y < 5; y++)
        {
            if (arr[x, y] == d)
            {
                booleanvar = true;
            }
        }
    }
    if (booleanvar == true)
    {
        Console.WriteLine("This letter already exists in the array.");
        booleanvar = false;
    }
    else if (booleanvar == false)
    {
        arr[b, c] = d;
        Console.WriteLine("Your letter has replaced the letter at (" + b + "," + c + "\n");
    }
}