string[] lines = File.ReadAllLines("input.csv");
int rwCnt = lines.Length - 1;
string[,] dataArr = new string[rwCnt, 5];

for (int i = 1; i < lines.Length; i++)
{
    string[] values = lines[i].Split(',');
    for (int j = 0; j < 5; j++)
    {
        dataArr[i - 1, j] = values[j];
    }
}

Console.WriteLine("ID\tLast Name\tFirst Name\tPhone Number\tMinutes");
Console.WriteLine("------------------------------------------------------------");

int minmins = int.MaxValue;
int maxmins = int.MinValue;
int totalmins = 0;

string minNames = "";
string maxNames = "";

for (int row = 0; row < rwCnt; row++)
{
    int minutes = int.Parse(dataArr[row, 4]);
    if (minutes < minmins)
    {
        minmins = minutes;
        minNames = $"{dataArr[row, 2]} {dataArr[row, 1]} {minutes}";
    }
    else if (minutes == minmins)
    {
        minNames += $", {dataArr[row, 2]} {dataArr[row, 1]} {minutes}";
    }

    if (minutes > maxmins)
    {
        maxmins = minutes;
        maxNames = $"{dataArr[row, 2]} {dataArr[row, 1]} {minutes}";
    }
    else if (minutes == maxmins)
    {
        maxNames += $", {dataArr[row, 2]} {dataArr[row, 1]} {minutes}";
    }

    totalmins += minutes;

    Console.WriteLine($"{dataArr[row, 0]}\t{dataArr[row, 1]}\t{dataArr[row, 2]}\t{dataArr[row, 3]}\t{minutes}");
}

double avgmins = (double)totalmins / rwCnt;

Console.WriteLine("------------------------------------------------------------");
Console.WriteLine($"Minimum: {minNames}");
Console.WriteLine($"Maximum: {maxNames}");
Console.WriteLine($"Average: {avgmins.ToString("F2")}");
