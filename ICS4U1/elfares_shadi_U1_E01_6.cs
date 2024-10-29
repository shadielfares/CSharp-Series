
string[] lines = File.ReadAllLines("input.txt");

int n = Convert.ToInt32(lines[0]);
string[] names = new string[n];
double[][] marks = new double[n][];

for (int e = 0; e < n; e++)
{
    string[] nameParts = lines[e * 2 + 1].Split(',');
    string first = nameParts[1].Trim();
    string last = nameParts[0].Trim();
    names[e] = $"{first} {last}";

    string[] markStrings = lines[e * 2 + 2].Split(',');
    marks[e] = new double[4];
    for (int j = 0; j < 4; j++)
    {
        marks[e][j] = Convert.ToDouble(markStrings[j]);
    }
}

for (int e = 0; e < n; e++)
{
    double[] m = marks[e];
    double min = m[0];
    double max = m[0];
    double sum = 0;

    for (int j = 0; j < 4; j++)
    {
        double mark = m[j];
        min = Math.Min(min, mark);
        max = Math.Max(max, mark);
        sum += mark;
    }

    double avg = sum / 4;

    Console.WriteLine($"Student: {names[e]}");
    Console.WriteLine($"Min Mark: {min}");
    Console.WriteLine($"Max Mark: {max}");
    Console.WriteLine($"Average Mark: {avg}");
}

int highestIndex = 0;
double highestAvg = (marks[0][0] + marks[0][1] + marks[0][2] + marks[0][3]) / 4;
for (int e = 1; e < n; e++)
{
    double avg = (marks[e][0] + marks[e][1] + marks[e][2] + marks[e][3]) / 4;
    if (avg > highestAvg)
    {
        highestAvg = avg;
        highestIndex = e;
    }
}

Console.WriteLine($"Highest Average: {names[highestIndex]}, Average Mark: {highestAvg}");

