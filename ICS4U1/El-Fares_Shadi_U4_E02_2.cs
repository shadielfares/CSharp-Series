//Initialize array of colors,  
string[] colors_array = { "red", "blue", "green", "orange", "purple", "yellow", "pink", "black", "white" };
string color_holder = "", l_case_var_holder = "";
int index = 0;

//Ask for color
Console.Write("Please enter a color: ");
color_holder = Convert.ToString(Console.ReadLine());
l_case_var_holder = color_holder.ToLower();

//Check to see if the color was or wasn't in the
index = Array.IndexOf(colors_array, l_case_var_holder);

if (index < 0)
{
    //Ouput if the color wasn't in the array
    Console.WriteLine(color_holder + " wasn't in the array of colors");
}
else if (index >= 0)
{
    //Ouput if the color was in the array
    Console.WriteLine(color_holder + " was in the array of colors");
}