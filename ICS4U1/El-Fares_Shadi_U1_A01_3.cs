// See https://aka.ms/new-console-template for more information
string? sentence = "";
string first_word = "";
string second_word = "";
string third_word = "";
string fourth_word = "";
string fifth_word = "";
int EndIndex = 0;
int StartIndex = 0;
char first_initial = '\0';
char second_initial = '\0';
char third_initial = '\0';
char fourth_initial = '\0';
char fifth_initial = '\0';

Console.WriteLine("Please enter a 5-word sentence: ");
sentence = Console.ReadLine();

EndIndex = sentence.IndexOf(' ');
first_word = sentence.Substring(StartIndex, EndIndex);
StartIndex = EndIndex + 1;

EndIndex = sentence.IndexOf(' ', StartIndex);
second_word = sentence.Substring(StartIndex, EndIndex - StartIndex);
StartIndex = EndIndex + 1;

EndIndex = sentence.IndexOf(' ', StartIndex);
third_word = sentence.Substring(StartIndex, EndIndex - StartIndex);
StartIndex = EndIndex + 1;

EndIndex = sentence.IndexOf(' ', StartIndex);
fourth_word = sentence.Substring(StartIndex, EndIndex - StartIndex);
StartIndex = EndIndex +1;

fifth_word = sentence.Substring(StartIndex);

first_initial = first_word [0];
second_initial = second_word [0];
third_initial = third_word [0];
fourth_initial = fourth_word [0];
fifth_initial = fifth_word [0];

Console.WriteLine("Your first letter initial is: " + first_initial);
Console.WriteLine("Your second letter initial is: " + second_initial);
Console.WriteLine("Your third letter initial is: " + third_initial);
Console.WriteLine("Your fourth letter initial is: " + fourth_initial);
Console.WriteLine("Your fifth letter initial is: " + fifth_initial);