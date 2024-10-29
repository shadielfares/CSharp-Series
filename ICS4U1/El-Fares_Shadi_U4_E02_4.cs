//Initalize varaibles
double[] array = { 3.11, 8.54, 6, 3.2, 12.98 }, b = { 3.11, 8.54, 6, 3.2, 12.98 };
int index = 0;
//Write first 'straight line'
Console.Write("\n-----------------------------------------------------\n|");
//Output base index
for (int x = 0; x < 5; x++)
{
    Console.Write("   " + array[x] + "   |");
}
//Closing straight line
Console.Write("\n-----------------------------------------------------\n");
//Ouput index position values for user
Console.Write("     0          1         2        3          4");
//Ask for replaced index position value
Console.Write("\n\nPlease input an index to replace: ");
index = Convert.ToInt32(Console.ReadLine());

//Series of manuevering the index positions around the chosen index posiition value
while (true)
{
    if (index == 0)
    {
        for (int y = 0; y < 4; y++)
        {
            array[y] = b[y + 1];
        }
            Array.Sort(array);
            array[4] = 0;
            break;
    }
        else if (index == 1)
        {
            for (int y = 1; y < 4; y++)
            {
                array[y] = b[y + 1];
            }
                Array.Sort(array);
                array[4] = 0;
                break;
        }
            else if (index == 2)
            {
                for (int y = 2; y < 4; y++)
                {
                    array[y] = b[y + 1];
                }
                    Array.Sort(array);
                    array[4] = 0;
                    break;
            }
                else if (index == 3)
                {
                    for (int y = 3; y < 4; y++)
                    {
                        array[y] = b[y + 1];
                    }
                        Array.Sort(array);
                        array[4] = 0;
                        break;
                }
                    else if (index == 4)
                    {
                        {
                            array[4] = b[4];
                        }
                            Array.Sort(array);
                            array[4] = 0;
                            break;
                    }
                        else if (index < 0 || index > 5)
                        {
                            Console.Write("Enter a proper index (0-4): ");
                            index = Convert.ToInt32(Console.ReadLine());
                        }
}
//Output modified array
Console.Write("\nHere is your new array: ");
Console.Write("\n-----------------------------------------------------\n|");

for (int x = 0; x < 5; x++)
{
    Console.Write("   " + array[x] + "   |");
}
Console.Write("\n-----------------------------------------------------\n");



