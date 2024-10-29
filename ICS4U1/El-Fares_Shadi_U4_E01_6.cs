double[] array = { 5.43, 8.95, 4.71, 3.69, 4.27 }, array2 = { 5.43, 8.95, 4.71, 3.69, 4.27 }; 
double variable = 0;
int i = 0;

Console.Write("Please input any number: ");
variable = Convert.ToDouble(Console.ReadLine());
Console.Write("\n--------------------------------------------------------\n|");

for (int x = 0; x < 5; x++)
{
    Console.Write("   " + array[x] + "   |");
}

Console.Write("\n--------------------------------------------------------\n");
Console.Write("     1          2          3          4          5");

Console.Write("\n\nPlease input an index to replace: ");
i = Convert.ToInt32(Console.ReadLine());

while (true)
{
    if (i == 1)
    {
        for (int y = 1; y < 4; y++)
        {
            array[y+1] = array2[y];
            array[1] = variable;
        }
        break;
    }
        else if (i == 2)
        {
            for (int y = 2; y < 4; y++)
            {
                array[y+1] = array2[y];
                array[2] = variable;
            }
            break;
        }
            else if (i == 3)
            {
                for (int y = 3; y < 4; y++)
                {
                    array[y+1] = array2[y];
                    array[3] = variable;
                }
                break;
            }
                else if (i == 4)
                {
                    for (int y = 4; y < 4; y++)
                    {
                        array[y+1] = array2[y];
                        array[4] = variable;
                    }
                    break;
                }
                    else if (i == 5)
                    {
                        array[5] = variable;
                    break;
                    }
                        else if (i < 0 || i > 5)
                        {
                            Console.Write("Enter a proper index (1-5): ");
                            i = Convert.ToInt32(Console.ReadLine());
                        }
}
Console.Write("\nHere is your new array: ");
Console.Write("\n--------------------------------------------------------\n|");

for (int x = 0; x < 5; x++)
{
    Console.Write("   " + array[x] + "   |");
}

Console.Write("\n--------------------------------------------------------\n");