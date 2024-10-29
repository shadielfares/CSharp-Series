string[] fruits = { "apple", "orange", "banana", "kiwi", "watermelon" };
Console.WriteLine("What type of fruit would you like: ");
string response = Console.ReadLine().ToLower();

bool found = false; // Variable to track if the fruit is found in the array

for (int x = 0; x < fruits.Length; x++) // Change condition from <= 5 to < fruits.Length
{
    if (response == fruits[x])
    {
        Console.WriteLine("We have that!");
        found = true; // Set found to true when fruit is found
        break; // Exit the loop when fruit is found
    }
}

if (!found) // Use the found variable to determine if fruit was not found
{
    Console.WriteLine("We do not have that.");
}
