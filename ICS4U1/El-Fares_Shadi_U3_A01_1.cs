const string inputfile = "input.txt";
const string outputfile = "output.txt";
StreamReader sr = new StreamReader(inputfile);
StreamWriter sw = new StreamWriter(outputfile);

string score, small = "";
double ms1, ms2, ms3, average, average2 = 0;
score = "a";

while (score != null)
{
score = sr.ReadLine();
ms1 = Convert.ToInt32(score);
    score = sr.ReadLine();
    ms2 = Convert.ToInt32(score);
        score = sr.ReadLine();
        ms3 = Convert.ToInt32(score);
            average = (ms1 * 98) + (ms2 * 150) + (ms3 * 114);

    if (average2 == 0)
    {
        average2 = average;
    }
        else if (average > average2)
        {
            small = "Day 1";
            break;
        }
            else if (average < average2)
            {
                small = "Day 2";
                break;
            }
                else if (average == average2)
                {
                    small = "Same";
                    break;
                }
}

sw.WriteLine(small);
Console.Write(small);

sr.Close();
sw.Close();

