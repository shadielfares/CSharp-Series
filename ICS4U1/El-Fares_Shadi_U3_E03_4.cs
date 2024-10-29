// See https://aka.ms/new-console-template for more information\

string s = "";
Console.Write("Enter a string: ");
s = Console.ReadLine();
s = s.ToLower();

string newstr = s;
// for (int x = 0; x < s.Length; x++)
// {
//     {
//     if (s[x] == 'b' || s[x] == 'c' || s[x] == 'd' || s[x] == 'f'|| s[x] == 'g'|| s[x] == 'h'|| s[x] == 'j'|| s[x] == 'k'|| s[x] == 'l'|| s[x] == 'm'|| s[x] == 'n'|| s[x] == 'p'|| s[x] == 'q'|| s[x] == 'r'|| s[x] == 's'|| s[x] == 't'|| s[x] == 'v'|| s[x] == 'w'|| s[x] == 'x'|| s[x] == 'y'|| s[x] == 'z')
//         newstr = newstr + s[x];
//     }
// }
for (int x = 0; x < s.Length; x++)
{
    {
    if (s[x] != 'a' || s[x] != 'e' || s[x] != 'i' || s[x] != 'o' || s[x] != 'u')
        newstr = newstr + s[x];
    }
}
Console.WriteLine("String with no vowels: " + newstr);  