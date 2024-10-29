double[] empty_array = { 0, 0, 0, 0, 0 };
double placeholders = 0, total = 0;
for (int counter = 0; counter < 5; counter++)
{
Console.Write("Please enter 5 integers (" + (counter + 1) + "): ");
    placeholders = Convert.ToInt32(Console.ReadLine());
        empty_array[counter] = placeholders;
            total = total + placeholders;
}
double highest = empty_array.Max(), lowest = empty_array.Min();
Console.WriteLine("\nThe highest number in your array was: " + highest + "\nThe lowest number in your array was: " + lowest + "\nThe average of all your numbers is: " + (total / 5));