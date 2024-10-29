//Initialize .cvs read file
const string inputfile = "input.csv";
StreamReader sr = new StreamReader(inputfile);

//Initialize variables and arrays
int m = 0, n = 0, p = 0, minimum = 0, maximum = 0, average = 0, total = 0, q = 0;
string[] header, info;
string[,] info1 = new string[5, 5];
string[] minfirstn = new string[6], minlastn = new string[6], maxfirstn = new string[6], maxlastn = new string[6];
string? line = "";

//Read first line
line = sr.ReadLine();
header = line.Split(',');

//Output headers
for (int x = 0; x < 5; x++)
{
    Console.Write(header[x] + " ");
}
//First dashed line
Console.WriteLine("------------------------------------------------------------");

//Read for 2D Array
for (int i = 0; i < 5; i++)
{
    line = sr.ReadLine();
    info = line.Split(',');
    for (int j = 0; j < 5; j++)
    {
        info1[i, j] = info[j];
    }
}

//Write for 2D Array
for (int k = 0; k < 5; k++)
{
    for (int l = 0; l < 5; l++)
    {
        Console.Write(info1[k, l] + ", ");
    }

    //Compare for maximum amount of minutes
    Console.WriteLine(" ");
    if (m < Convert.ToInt32(info1[k, 4]))
    {
        m = Convert.ToInt32(info1[k, 4]);
        maximum = m;
    }

    //Get minimum value
    if (n == 0)
    {
        n = Convert.ToInt32(info1[k, 4]);
    }

    else if (n > Convert.ToInt32(info1[k, 4]))
    {
        minimum = Convert.ToInt32(info1[k, 4]);
        n = Convert.ToInt32(info1[k, 4]);
    }

    //Calculate total
    total = (total + Convert.ToInt32(info1[k, 4]));

}

//Second dashed line
Console.WriteLine("------------------------------------------------------------");

//Get minimum names
for (int r = 0; r < 5; r++)
{
    if (minimum == Convert.ToInt32(info1[r, 4]))
    {
        minfirstn[q] = info1[r, 2];
        minlastn[q] = info1[r, 1];
        q++;
    }

    //Get maximum names
    else if (maximum == Convert.ToInt32(info1[r, 4]))
    {
        maxfirstn[p] = info1[r, 2];
        maxlastn[p] = info1[r, 1];
        p++;
    }
}

//Output minimum names
Console.Write("Minimum: ");
for (int t = 0; t < minfirstn.Length; t++)
{
    if (minfirstn[t] == null)
    {
        Console.Write(minimum + "\n");
        break;
    }
    else
        Console.Write(minfirstn[t] + " " + minlastn[t] + ", ");
}

//Output maximum names
Console.Write("Maximum: ");
for (int u = 0; u < minfirstn.Length; u++)
{
    if (maxfirstn[u] == null)
    {
        Console.Write(maximum + "\n");
        break;
    }
    else
        Console.Write(maxfirstn[u] + " " + maxlastn[u] + ", ");
}

//Cacluate average
average = (total / 5);

//Output average
Console.WriteLine("Average: " + average);