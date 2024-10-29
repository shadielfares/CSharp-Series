//Initialzing array and unfilled variable.
int[] array = { 0, 0, 0, 0, 0 };
int var = 0;

for (int i = 0; i < 5; i++)
{
    //Ask for 5 ints then loop placement of those vars into the array
    Console.Write("Please enter 5 numbers (" + (i + 1) + "): ");
    var = Convert.ToInt32(Console.ReadLine());
    array[i] = var;
}

//Array gets sorted, reversed and new written line.
Array.Sort(array);
Array.Reverse(array);
Console.Write("\n");

//Outputs numbers in descending order
for (int x = 0; x < array.Length; x++)
{
    if (x < array.Length - 1)
    {
        Console.Write(array[x] + ", ");
    }
    else
        Console.Write(array[x]);
}