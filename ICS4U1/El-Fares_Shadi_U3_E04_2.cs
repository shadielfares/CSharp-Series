// See https://aka.ms/new-console-template for more information\


// open input file
StreamReader sr = new StreamReader("input.txt");
// initialize variables
int num = 0;
char c = '\0';
//pasing num value to another for use
int pass = num;
// loop through file

while(true)
{
// break out of while-loop if 'num' equals '0'
if(num == 0)
    {
    break;  
    }
// get number of characters to output
num = Convert.ToInt32(sr.ReadLine());
// get character to output
c = Convert.ToChar(sr.ReadLine());
// output 'c' for 'num' times

for(int x = 0; num > x; num--)
{
Console.WriteLine(c);
}
Console.WriteLine();
}
// close input file
sr.Close();
