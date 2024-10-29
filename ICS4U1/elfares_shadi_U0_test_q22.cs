Console.WriteLine("Enter your string: ");
string stringgiv = Console.ReadLine();

int firstIndex = stringgiv.IndexOf("programming");
int lastIndex = stringgiv.LastIndexOf("programming");

string result = "";
int x = 0;

while (x < stringgiv.Length)
{
    if (x == firstIndex || x == lastIndex)
    {
        result += stringgiv.Substring(x, 11).ToUpper();
        x += 11;
    }
    else
    {
        result += stringgiv[x];
        x++;
    }
}

Console.WriteLine(result);
