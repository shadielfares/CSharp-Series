// See https://aka.ms/new-console-template for more information
Console.WriteLine("Apples: $0.50 each"); 
Console.WriteLine("Oranges: $.75 each");

string? response = "";
int quantity = 0;
string? word = "";
double price = 0;

Console.Write("Would you like to purchase apples or oranges? Input 'a' for apples & 'o' for oranges: ");
response = Console.ReadLine();
response = response.ToLower();

if (response == "a")
{   
    Console.Write("You did not enter a valid response of 'a' or 'o'.");
    Console.Write("How many apples would you like to buy:");
    quantity = Convert.ToInt32(Console.ReadLine());
    word = "Apples";
    price = 0.50;
}
else

    if (response == "o")
    { 
        Console.WriteLine("How many oranges would you like to buy:");
        quantity = Convert.ToInt32(Console.ReadLine());
        word = "Oranges";
        price = 0.75;
    }
     else
         Console.WriteLine("You did not enter a valid response of 'a' or 'o'." + '\n');

double total = quantity * price;

Console.WriteLine('\t' + "Item" + '\t' + "Qty" + "\t" + "Price" + "\t" + "Total");
Console.WriteLine('\t' + "-----------------------------");
Console.WriteLine('\t' + word + '\t' + quantity + '\t' + price + '\t' + total);

int m_given = 0;

Console.Write("How much money do you have for the payment?: ");
m_given = Convert.ToInt32(Console.ReadLine());

if (m_given > 100)
{
    Console.Write("There is not enough change for that amount.");
    Console.Write("We cannot follow through with this transaction further, thank you for shopping with us today.");
}

else
    Console.Write("Amount tendered: $" + m_given);
    double change = 0;
    change = m_given - total;
    Console.Write("Change: " + change);
    Console.Write('\n' + "Thank you for shopping with ICS!");




//-------------------


// int mark1 = 0;
// Console.Write("Please enter an integer mark (%) between 0 and 100: ");
// mark1 = Convert.ToInt32(Console.ReadLine());

// if (mark1 < 0 || mark1 > 100)
//     Console.Write("\nYou did not enter an integer mark between 0 and 100!");
// else
// {
//     int mark2 = 0;
//     Console.Write("Please enter an integer mark (%) between 0 and 100: ");
//     mark2 = Convert.ToInt32(Console.ReadLine());
//     if (mark2 < 0 || mark2 > 100)
//         Console.Write("\nYou did not enter an integer mark between 0 and 100!");
//     else
//     {
//         int mark3 = 0;
//         Console.Write("Please enter an integer mark (%) between 0 and 100: ");
//         mark3 = Convert.ToInt32(Console.ReadLine());
//         if (mark3 < 0 || mark3 > 100)
//             Console.Write("\nYou did not enter an integer mark between 0 and 100!");
//         else
//         {
//             int mark4 = 0;
//             Console.Write("Please enter an integer mark (%) between 0 and 100: ");
//             mark4 = Convert.ToInt32(Console.ReadLine());
//             if (mark4 < 0 || mark4 > 100)
//             Console.Write("\nYou did not enter an integer mark between 0 and 100!");
//             else
//             {
//                 double average = (mark1 + mark2 + mark3 + mark4) / 4.0;
//                 char grade = '\0';
//                 if (average < 50)
//                     grade = 'D';
//                 else if (average < 70)
//                     grade = 'C';
//                 else if (average < 80)
//                     grade = 'B';
//                 else
//                     grade = 'A';
//                 Console.Write("\nYour grade letter is: " + grade);
//             }
//         }
//     }
// }