// See https://aka.ms/new-console-template for more information

string? sentence = "";
int start_index = 0;
int end_index = 0;
string remove_sub = "";


Console.WriteLine("Please enter a sentence: ");
sentence = Console.ReadLine();

Console.WriteLine("Please enter a starting index for removal: ");
start_index = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter an ending index for removal: ");
end_index = Convert.ToInt32(Console.ReadLine());

sentence = sentence.Remove(start_index, end_index);

Console.WriteLine("Your new sentence is: " + sentence);