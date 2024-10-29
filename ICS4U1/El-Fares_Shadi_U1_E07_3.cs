// See https://aka.ms/new-console-template for more information

int name_start = 0;
int name_end = 0;
string first_name = "";
string last_name = "";
string? name = "";
char first_initial = '\0';
char second_initial = '\0';
Console.WriteLine("Please enter in your full name: ");
name = Console.ReadLine();

int name_Len = name.Length;
Console.WriteLine("Your name has a length of " + name_Len);


name_end = name.IndexOf(' ');
first_name = name.Substring(name_start, name_end);
name_start = name_end + 1;
last_name = name.Substring(name_start);

Console.WriteLine("Your first name is: " + first_name);
Console.WriteLine("Your last name is: " + last_name);

first_initial = first_name [0] ;
second_initial = last_name [0];
Console.WriteLine("Your first letter initial is: " + first_initial);
Console.WriteLine("Your second letter initial is: " + second_initial);