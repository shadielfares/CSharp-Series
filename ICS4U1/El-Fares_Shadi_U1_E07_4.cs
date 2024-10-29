// See https://aka.ms/new-console-template for more information

string? sentence = "";
string? f_r_word = "";
string? s_r_word = "";
int end_index = 0;
string remove_sub = "";


Console.WriteLine("Please enter a sentence: ");
sentence = Console.ReadLine().ToLower();

Console.WriteLine("Please enter a word from this sentence that you would like to replace:");
f_r_word = Console.ReadLine().ToLower();

Console.WriteLine("Please enter a word to replace " + f_r_word + " with:");
s_r_word = Console.ReadLine().ToLower();

Console.WriteLine(sentence.Replace(f_r_word, s_r_word));


