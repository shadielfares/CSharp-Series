const string inputfile = "input.txt";
const string outputfile = "output.txt";
StreamReader sr = new StreamReader(inputfile);
string? score = "";
double n, point3, point2, point1, t, t2 = 0;
int TeamA = 0, TeamB = 0;
score = sr.ReadLine();
n = Convert.ToInt32(score); 

while (score != null)
{
    score = sr.ReadLine();
    point3 = Convert.ToInt32(score);
        score = sr.ReadLine();
        point2 = Convert.ToInt32(score);
            score = sr.ReadLine();
            point1 = Convert.ToInt32(score);
                t = (point3 * 3) + (point2 * 2) + (point1);

    if (t2 == 0)
    {
        t2 = t;
    }
        else if (t2 > t)
        {
            TeamA = TeamA + 1;
            t2 = 0;
            t = 0;
        }
            else if (t2 < t)
            {
                TeamB = TeamB + 1;
                t2 = 0;
                t = 0;
            }
}
 sr.Close();

    if (TeamA > TeamB)
    {
        StreamWriter sw = new StreamWriter(outputfile);
        sw.WriteLine("A");
        sw.Close();
    }

        else if (TeamA < TeamB)
        {
        StreamWriter sw = new StreamWriter(outputfile);
        sw.WriteLine("B");
        sw.Close();
        }