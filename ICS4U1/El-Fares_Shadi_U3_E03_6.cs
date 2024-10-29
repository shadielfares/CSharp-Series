// See https://aka.ms/new-console-template for more information\
int records = 0;

Console.Write("How many records do you wish to input: ");
records = Convert.ToInt32(Console.ReadLine());

const string OUTPUT_FILE = "output.txt";
StreamWriter sw = new StreamWriter(OUTPUT_FILE);


string? line = "";
string firstName = "", lastName = "";
int phone = 0;
string email = "";

for(int x = 1; x <= records; x++)
{
Console.Write("Enter first name for record " + x + ": ");
firstName = Console.ReadLine();

Console.Write("Enter last name for record " + x + ": ");
lastName = Console.ReadLine();

Console.Write("Enter phone number for record " + x + ": ");
phone = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter email for record " + x + ": ");
email = Console.ReadLine();

sw.WriteLine(lastName + ", " + firstName + ", " + phone + ", " + email);


}

sw.Close();