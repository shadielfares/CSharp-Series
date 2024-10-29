// See https://aka.ms/new-console-template for more information
string course1 =  "ICS";
string course2 =  "BTT";
string course3 =  "IDC";
string course4 =  "BTA";

int response = 0;

Console.Write("Please select a course:\n");
Console.Write("-----------------------\n");
Console.Write("1) ICS\n");
Console.Write("2) BTT\n");
Console.Write("3) IDC\n");
Console.Write("4) BTA\n");
Console.Write("-----------------------\n");


    Console.Write("\nPlease enter an integer co-responding to a choice: ");
    response = Convert.ToInt32(Console.ReadLine());

if (response == 1)
   Console.Write("Your choice of course was " + course1);
else if (response == 2)
    Console.Write("Your choice of course was " + course2);
else if (response == 3)
    Console.Write("Your choice of course was " + course3);
else if (response == 4)
    Console.Write("Your choice of course was " + course4);

while((response != 1) || (response != 2) || (response != 3) || (response != 4))
{

if (response > 4)

    Console.Write("\nPlease enter an integer co-responding to a choice: ");
    response = Convert.ToInt32(Console.ReadLine());

if (response == 1)
   Console.Write("Your choice of course was " + course1);
else if (response == 2)
    Console.Write("Your choice of course was " + course2);
else if (response == 3)
    Console.Write("Your choice of course was " + course3);
else if (response == 4)
    Console.Write("Your choice of course was " + course4);
}



