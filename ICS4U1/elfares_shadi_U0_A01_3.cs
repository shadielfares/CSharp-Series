string inputFile = "input.txt";
string outputFile = "output.txt";

StreamReader reader = new StreamReader(inputFile);
StreamWriter writer = new StreamWriter(outputFile);

int numstudents = Convert.ToInt32(reader.ReadLine());

for (int x = 0; x < numstudents; x++)
{
    string? fname = reader.ReadLine();
    string? lname = reader.ReadLine();
    string? studentnum = reader.ReadLine();

    string login;

    if (lname.Length >= 7)
    {
        login = lname.Substring(0, 7);
    }
    else
    {
        login = lname;
    }

    login += fname.Substring(0, 2) + studentnum.Substring(studentnum.Length - 3);

    writer.WriteLine(login);
}

reader.Close();
writer.Close();
