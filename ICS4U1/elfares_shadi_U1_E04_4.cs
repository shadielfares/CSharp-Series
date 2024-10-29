Console.WriteLine("Please enter a sentence: ");
string uSent = Console.ReadLine();
string ulowSent = uSent.ToLower();

Console.WriteLine("Please enter a word you would like to remove from this sentence: ");
string uRemove = Console.ReadLine();
string lowRemove = uRemove.ToLower();

Console.WriteLine("Please enter a word you would like to replace the removed word with: ");
string uReplace = Console.ReadLine();

string result = ulowSent.Replace(lowRemove, uReplace);

Console.WriteLine(result);

