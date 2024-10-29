// See https://aka.ms/new-console-template for more information\


const string INPUT_FILE = "input.txt";
const string OUTPUT_FILE = "output.txt";
// open the input file
StreamReader sr = new StreamReader(INPUT_FILE);
// fields used for input file
string? line = "";
string firstName = "", lastName = "";
double mark = 0;
// variables for calculating average
double total = 0, count = 0, avg = 0;

// read the first line of text from the input file
line = sr.ReadLine();
// continue to read until you reach end of file

// for(int x = 0; x < line.Length;)
// {
//     // firstName = line;
//     Console.Write(line[x]);
//     x++;
// }


while (line != null)
{
// get firstName
firstName = line;
// read next line & get last name
line = sr.ReadLine();
Console.Write(line[5]);
// lastName = line;
// // read next line & get mark
// line = sr.ReadLine();
// mark = Convert.ToDouble(line);
// // output record
// Console.WriteLine(firstName + ' ' + lastName + ": " + mark);
// // accumulate 'total' & increment 'count'
// total = total + mark;
count++;
// read the next line
line = sr.ReadLine();
}
// close input file
sr.Close();
// calculate average
avg = total / count;
// output 'avg'
Console.WriteLine("\nClass Average: " + avg);
// open an output file
StreamWriter sw = new StreamWriter(OUTPUT_FILE);
// write 'avg' to output file
sw.WriteLine(avg);
// close output file
sw.Close();
