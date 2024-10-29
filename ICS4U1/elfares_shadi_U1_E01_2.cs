string[] fruits = { "apple", "orange", "banana", "kiwi", "watermelon" };
Console.WriteLine("What type of fruit would you like: ");
string response = Console.ReadLine().ToLower();

int index = Array.IndexOf(fruits, response); // Get the index of the fruit in the array

if (index != -1) // If the fruit is found
{
    Console.WriteLine("We have that!");
}
else
{
    Console.WriteLine("We do not have that.");
}
