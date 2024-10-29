// constant variables
const string INPUT_FILE = "input.txt";
const string OUTPUT_FILE = "output.txt";
// open the input file
StreamReader sr = new StreamReader(INPUT_FILE);
// open an output file
StreamWriter sw = new StreamWriter(OUTPUT_FILE);

int iterations = Convert.ToInt32(sr.ReadLine());
double average, overall = 0,overallavg ;
for (int i = 0; i < iterations; i++)
{
    double total = 0;
    int studentnum = Convert.ToInt32(sr.ReadLine());
    sw.WriteLine(studentnum);
    for (int x = 0; x <= 3; x++)
    {
        int mark = Convert.ToInt32(sr.ReadLine());
        total = total + mark;
    }
     average = total / 4;
    sw.WriteLine(average);
    overall = overall + average;
    overallavg = overall / 3;
    if (i == iterations - 1)
    {
        sw.WriteLine(overallavg.ToString("0.00"));

    }
}

sr.Close();
sw.Close();