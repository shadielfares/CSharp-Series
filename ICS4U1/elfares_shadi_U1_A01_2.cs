StreamReader sr = new StreamReader("input.txt");
int M = Convert.ToInt32(sr.ReadLine());
int N = Convert.ToInt32(sr.ReadLine());

int[,] grid = new int[N, M];
string[] row = new string[M];
int[] totalCoinsPerPath = new int[grid.Length];
string? line = "";
int counter = 0;

for (int x = 0; x < N; x++)
{
    line = sr.ReadLine();
    row = line.Split(' ');
    for (int y = 0; y < M; y++)
        grid[x, y] = int.Parse(row[y]);
}

int numCoinsCollectedTemp = 0;
for (int x = 0; x < N; x++)
{
    for (int y = 0; y < M; y++)
    {
        numCoinsCollectedTemp = 0;
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                if (i == x && j >= y && j < M - 1)
                {
                    numCoinsCollectedTemp = numCoinsCollectedTemp + int.Parse(grid[i, j].ToString());
                }
                else if (j == M - 1)
                {
                    if (i >= x)
                    {
                        numCoinsCollectedTemp = numCoinsCollectedTemp + int.Parse(grid[i, j].ToString());
                    }
                }
            }
        }
        totalCoinsPerPath[counter] = numCoinsCollectedTemp;
        counter++;
    }
}

sr.Close();

Console.WriteLine($"The largest possible number coins that can be gathered by any valid path is {totalCoinsPerPath.Max()}");