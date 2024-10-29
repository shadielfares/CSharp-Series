int[] arr =  new int[5];

PopulateArray(arr);
PrintArray(arr);
ClearArray(arr);
PrintArray(arr);

void PopulateArray(int[] arr)
{
    for (int x = 0; x < arr.Length; x++)
    {
        Console.Write("Enter a value for the spot in the array, {0}: ", x);
        arr[x] = int.Parse(Console.ReadLine());
    }
}

void PrintArray(int[] arr)
{
    Console.Write("Array: ");
    for (int x = 0; x < arr.Length; x++)
    {
        Console.Write(arr[x] + " ");
    }
    Console.WriteLine();
}

void ClearArray(int[] arr) {
        for (int x = 0; x < arr.Length; x++) {
            arr[x] = 0;
        }
    }