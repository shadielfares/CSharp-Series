int[] num = new int [5];

for (int x = 0; x < num.Length; x++)
{
    Console.WriteLine("Enter an integer for position {0}:", x + 1);
    num[x] = Convert.ToInt32(Console.ReadLine());
}

int high = num[0];
int low = num[0];
int sum = num[0];

for (int x = 1; x < num.Length; x++)
{
    if (num[x] > high)
        high = num[x];

    if (num[x] < low)
        low = num[x];

    sum += num[x];
}

double average = (double) sum / num.Length;

Console.WriteLine("This is the highest: {0}", high);
Console.WriteLine("This is the lowest: {0}", low);
Console.WriteLine("This is the average: {0}", average);
