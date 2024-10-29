Console.Write("Enter a string: ");
string input = Console.ReadLine();
string output = "";
for (int i = 0; i < input.Length; i++)
{
    char letter = input[i];
    if (letter != 'a' && letter != 'e' && letter != 'i' && letter != 'o' && letter != 'u'
        && letter != 'A' && letter != 'E' && letter != 'I' && letter != 'O' && letter != 'U')
    {
        output += letter;
    }
}
Console.WriteLine("String with no vowels: " + output);
