int sum(int start, int end)
{
    if (start == end)
    {
        return start;
    }
    else
    {
        return start + sum(start + 1, end);
    }
}

int sumEven(int start, int end)
{
    if (start > end)
    {
        return 0;
    }
    else
    {
        if (start % 2 == 0)
        {
            return start + sumEven(start + 2, end);
        }
        else
        {
            return sumEven(start + 1, end);
        }
    }
}

int sumOdd(int start, int end)
{
    if (start > end)
    {
        return 0;
    }
    else
    {
        if (start % 2 != 0)
        {
            return start + sumOdd(start + 2, end);
        }
        else
        {
            return sumOdd(start + 1, end);
        }
    }
}

Console.WriteLine("What you would like the start to be: ");
int start = int.Parse(Console.ReadLine());
Console.WriteLine("What you would like the end to be: ");
int end = int.Parse(Console.ReadLine());

Console.WriteLine("Sum of numbers between {0} and {1}: {2}", start, end, sum(start, end));
Console.WriteLine("Sum of even numbers between {0} and {1}: {2}", start, end, sumEven(start, end));
Console.WriteLine("Sum of odd numbers between {0} and {1}: {2}", start, end, sumOdd(start, end));
