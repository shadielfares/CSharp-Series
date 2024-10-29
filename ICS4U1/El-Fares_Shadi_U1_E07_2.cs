// See https://aka.ms/new-console-template for more information
string s = "";
string? index = "";
s = "Led Zeppelin could be considered the greatest band of all time";

Console.WriteLine("Enter an index position from the string: ");
index = Console.ReadLine();
int the_index = s.IndexOf(index);
Console.WriteLine(the_index);