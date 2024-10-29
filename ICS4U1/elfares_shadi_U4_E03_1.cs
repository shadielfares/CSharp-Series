
int rowCount = File.ReadAllLines("input.csv").Length - 1;

string[,] dataArr = new string[rowCount, 5];

using (StreamReader reader = new StreamReader("input.csv"))
{
    reader.ReadLine();

    string line;
    int row = 0;
    while ((line = reader.ReadLine()) != null)
    {
        string[] values = line.Split(',');
        for (int col = 0; col < 5; col++)
        {
            dataArr[row, col] = values[col];
        }
        row++;
    }
}

Console.WriteLine("ID   Last Name   First Name   Phone Number   Mins");
Console.WriteLine("----------------------------------------------------");
int minMins = int.MaxValue;
int maxMins = int.MinValue;
int totalMins = 0;

for (int row = 0; row < rowCount; row++)
{
    for (int col = 0; col < 5; col++)
    {
        string value = dataArr[row, col];
        if (col == 4)
        {
            int mins = int.Parse(value);
            minMins = Math.Min(minMins, mins);
            maxMins = Math.Max(maxMins, mins);
            totalMins += mins;
            Console.Write(mins.ToString().PadRight(8));
        }
        else
        {
            Console.Write(value.PadRight(15));
        }
    }
    Console.WriteLine();
}

double avgMins = (double)totalMins / rowCount;
Console.WriteLine("----------------------------------------------------");
Console.WriteLine($"Minimum: {dataArr[1, 2]} {dataArr[1, 1]} {minMins}");
Console.WriteLine($"Maximum: {dataArr[3, 2]} {dataArr[3, 1]} {maxMins}");
Console.WriteLine($"Average: {avgMins.ToString("0.00")}");

