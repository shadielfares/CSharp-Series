//selection sort
int[] array = new int[10] { 56, 1, 99, 67, 89, 23, 44, 12, 78, 34 };
int x = 10;

int small, tempnum;
for (int y = 0; y < x - 1; y++)
{
    small = y;
    for (int j = y + 1; j < x; j++)
    {
        if (array[j] < array[small])
        {
            small = j;
        }
    }
    tempnum = array[small];
    array[small] = array[y];
    array[y] = tempnum;
}

for (int y = 0; y < x; y++)
{
    Console.Write(array[y] + " ");
}