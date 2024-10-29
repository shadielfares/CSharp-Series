int BinarySearch(double[] arr, double x)
{
    int left = 0, mid = 0, right = arr.Length - 1;

    while (left <= right) 
    {
        mid = left + (right - left) / 2;

        if (arr[mid] == x)
            return mid;

        else  if (arr[mid] < x)
            left = mid + 1;

        else
            right = mid - 1;
    }
    return -1;
}

void PrintIntArray(double[] nums)
{
    for(int x = 0; x < nums.Length; x++)
    {
        Console.Write(nums[x] + " ");
    }
    Console.WriteLine();
}

double[] nums = { 2.7, 3.3, 4.8, 5.1, 15.3, 19.6, 26.9, 27.3, 36.4, 38.8, 44.7, 46.2, 47.5, 48.6, 50.7 };
PrintIntArray(nums);
Console.WriteLine("Value '19.6' is at index " + BinarySearch(nums, 19.6));