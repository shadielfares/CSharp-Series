// constant variables
const string INPUT_FILE = "input.csv";
const string OUTPUT_FILE = "output.csv";
// open the input file
StreamReader sr = new StreamReader(INPUT_FILE);
// open an output file
StreamWriter sw = new StreamWriter(OUTPUT_FILE);

int numRecords = Convert.ToInt32(sr.ReadLine());

// read remaining lines as records
for (int i = 0; i < numRecords; i++)
{
    string record = sr.ReadLine();

    // separate values in record using substrings
    string[] values = new string[5];
    int startIndex = 0;
    for (int j = 0; j < values.Length; j++)
    {
        int commaIndex = record.IndexOf(',', startIndex);
        if (commaIndex == -1)
        {
            // last value in record
            commaIndex = record.Length;
        }
        values[j] = record.Substring(startIndex, commaIndex - startIndex);
        startIndex = commaIndex + 1;
    }

    // convert values to double and calculate average
    sw.WriteLine(values[0]);
    
    
    double sum = 0;
    for (int j = 1; j < values.Length; j++) // start at index 1 to skip student ID
    {
        sum += double.Parse(values[j]);
    }
    double average = sum / (values.Length - 1);

    // write average to output file with two double places

    sw.WriteLine(average.ToString("0.00"));
}

sr.Close();
sw.Close();