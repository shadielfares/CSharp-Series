Console.WriteLine("Enter a string: ");
string s = Console.ReadLine();
string stolow = s.ToLower();
//Logic
bool palindrome(string stolow)
{
    if (stolow.Length <= 1)
        return true;
    else if (stolow[0] != stolow[stolow.Length - 1])
    {
        return false;
    }
    else
    {
        return palindrome(stolow.Substring(1, stolow.Length - 2));
        //This line is to return a substring starting from the 2nd character and ends at the second last, checking each character.
    }
}

bool check = palindrome(stolow);

if (check == true)
{
    Console.WriteLine("{0}, is a palindromee.", s);
}
else
{
    Console.WriteLine("{0}, is a not palindromee.", s);
}