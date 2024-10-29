using (StreamReader sr = new StreamReader("input.csv"))
{
    //Initalized variables
    int m = 0, n = 0, minimum = 0, maximum = 0, average = 0, total = 0;
    string maxfirst = "", maxlast = "", minfirst = "", minlast = "";
    string[] header, info;
    string[,] info1 = new string[5, 5];
    //Read info for one regular string
    string line = sr.ReadLine();
    //Split 'line' into array via comma
    header = line.Split(',');
    //Header titles
    for (int x = 0; x < 5; x++)
    {
        Console.Write(header[x] + " ");
    }
    Console.WriteLine();
    //Dashed line
    Console.WriteLine("------------------------------------------------------------");
    //Outerloop Traverses Rows (For Reading)
    for (int i = 0; i < 5; i++)
    {
        //Reads for full row
        line = sr.ReadLine();
        //Places read line into 1D Array
        info = line.Split(',');
        //Inner loop traverses columns
        for (int j = 0; j < 5; j++)
        {
            //2D Array I, is our x-axis and our J is our Y-Axis
            info1[i, j] = info[j];
        }
    }

    //Outerloop Traverses Rows (For Writing)
    for (int k = 0; k < 5; k++)
    {
        //Inner loop Traverses Columns (For Writing)
        for (int l = 0; l < 5; l++)
        {
            //Output X-Axis and Y Axis co-ordinate for a 5 x 5 2D array
            Console.Write(info1[k, l] + ", ");
        }
        //New entry per record
        Console.WriteLine();

        //Compare each minute's entry to see who has the most amount of minutes
        if (m < Convert.ToInt32(info1[k, 4]))
        {
            m = Convert.ToInt32(info1[k, 4]);
            maximum = m;
            maxfirst = info1[k, 2];
            maxlast = info1[k, 1];
        }
        if (n == 0)
        {
            n = Convert.ToInt32(info1[k, 4]);
        }
        //Compare each minute's entry to see who has the least of minutes
        else if (n > Convert.ToInt32(info1[k, 4]))
        {
            minimum = Convert.ToInt32(info1[k, 4]);
            minfirst = info1[k, 2];
            minlast = info1[k, 1];
            n = Convert.ToInt32(info1[k, 4]);
        }
        //Calculate total amount ofminutes
        total = (total + Convert.ToInt32(info1[k, 4]));

    }
    //Calculate average
    average = (total / 5);

    //Output Maximum, Minimum, and Average amount of minutes
    Console.WriteLine("------------------------------------------------------------");
    Console.WriteLine("Maximum: " + minfirst + " " + minlast + ", " + minimum);
    Console.WriteLine("Minimum: " + maxfirst + " " + maxlast + ", " + maximum);
    Console.WriteLine("Average: " + average);
}
