string[] fruit = { "apple", "orange", "mango", "banana", "watermelon"};
string placeholder = "";
Console.Write("Please enter a fruit: ");
placeholder = Console.ReadLine();
placeholder = placeholder.ToLower();
if (placeholder == fruit[0] || placeholder == fruit[1] || placeholder == fruit[2] || placeholder == fruit[3] || placeholder == fruit[4])
    {
        Console.WriteLine("'" + placeholder + "' was in the array of fruits");
    }   
    else
        {
            Console.WriteLine(placeholder + " was not in the array of fruits");
        }