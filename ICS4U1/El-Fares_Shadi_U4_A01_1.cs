//Read from stread reader
StreamReader sr = new StreamReader("input.txt");
//Read first line to get M and convert to integer
int M = Convert.ToInt32(sr.ReadLine());
//Read second line to get N and convert to integer
int N = Convert.ToInt32(sr.ReadLine());
//Initialize variables
int count = 0, greatest = 0;
int[,] grid = new int[N, M];
string[] row = new string[M];
string? line = "";
//Read through 2d array and convert to integers
for (int x = 0; x < N; x++)
{
    line = sr.ReadLine();
    row = line.Split(' ');
    for (int y = 0; y < M; y++)
    {
        grid[x, y] = Convert.ToInt32(row[y]);
    }
}
//Compare each grid piece in accordance to location of which is bigger / produces the greatest result
for (int x = 0; x < N; x++)
{
    for (int y = 0; y < M; y++)
    {
        count = grid[x, y];
        if (x > 0 && grid[x - 1, y] != '\0')
            count = count + grid[x - 1, y];
        if (x < N - 1 && grid[x + 1, y] != '\0')
            count = count + grid[x + 1, y];
        if (y > 0 && grid[x, y - 1] != '\0')
            count = count + grid[x, y - 1];
        if (y < M - 1 && grid[x, y + 1] != '\0')
            count = count + grid[x, y + 1];
        if (count > greatest)
            greatest = count;
    }
    count = 0;
}
//Close streamreader file
sr.Close();]
//Write the greatest combination
Console.WriteLine(greatest);
