double[] arr = { 3.11, 8.54, 6, 3.2, 12.98 };

Console.WriteLine("Array of 5 doubles:");
for (int x = 0; x < arr.Length; x++)
{
    Console.Write(arr[x] + " ");
}
Console.WriteLine();

Console.Write("Enter an index to delete (0-4): ");
int i = Convert.ToInt32(Console.ReadLine());

    for (int j = i; j < arr.Length - 1; j++)
    {
        arr[j] = arr[j + 1];
    }
    arr[arr.Length - 1] = 0;

    Console.WriteLine();

    Array.Sort(arr);

    Console.WriteLine("Sorted Array:");
    for (int k = 0; k < arr.Length; k++)
    {
        Console.Write(arr[k] + " ");
    }