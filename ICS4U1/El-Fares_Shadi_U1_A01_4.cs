// See https://aka.ms/new-console-template for more information
string? sentence = "";
string first_word = "";
string second_word = "";
string third_word = "";
string fourth_word = "";
string fifth_word = "";
int EndIndex = 0;
int StartIndex = 0;
string reversed = "";

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

reversed = fifth_word + ' ' + fourth_word + ' '  + third_word + ' '  + second_word + ' '  + first_word;

Console.WriteLine("Your reversed sentence is: " + reversed);
