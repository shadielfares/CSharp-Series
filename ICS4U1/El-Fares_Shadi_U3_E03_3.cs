// See https://aka.ms/new-console-template for more information\

string s = "";
Console.Write("Please enter a string: ");
s = Console.ReadLine();
s = s.ToLower();

int dlc = 0;
char c = ' ';
char cp = ' ';

for (int x = 0; x < s.Length; x++)
{
if (s[x] == cp)
    dlc++;
if (x % 2 == 0)
    cp = s[x];
}

Console.WriteLine("The number of side-by-side letters in the string is  " + dlc + " times.");

