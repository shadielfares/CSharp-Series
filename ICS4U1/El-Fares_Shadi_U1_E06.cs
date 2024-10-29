// See https://aka.ms/new-console-template for more information
string? First_Name = "";
string? Last_Name = "";
string? Student_Number = "";
string? Address = "";
string? City = "";
string? Province = "";
string? Postal_Code = "";
string? Phone = "";
string? Period_1_Course_Code = "";
string? Period_2_Course_Code = "";
string? Period_3_Course_Code = "";
string? Period_4_Course_Code = "";
string? Period_5_Course_Code = "";
int Period_1_Mark = 0;
int Period_2_Mark = 0;
int Period_3_Mark = 0;
int Period_4_Mark = 0;
int Period_5_Mark = 0;
int numCourses = 0;
double average = 0;
 

Console.Write("Please enter your First name: ");
First_Name = Console.ReadLine();

Console.Write("Please enter your Last name: ");
Last_Name = Console.ReadLine();

Console.Write("Please enter Student Number: ");
Student_Number = Console.ReadLine();

Console.Write("Please enter your Address: ");
Address  = Console.ReadLine();

Console.Write("Please enter your City: ");
City  = Console.ReadLine();

Console.Write("Please enter your Province: ");
Province  = Console.ReadLine();

Console.Write("Please enter your Postal Code: ");
Postal_Code = Console.ReadLine();

Console.Write("Please enter your Phone: ");
Phone  = Console.ReadLine();

Console.Write("Please enter your Period 1 Course Code: ");
Period_1_Course_Code = Console.ReadLine();

Console.Write("Please enter your Period 2 Course Code: ");
Period_2_Course_Code = Console.ReadLine();


Console.Write("Please enter your Period 3 Course Code: ");
Period_3_Course_Code = Console.ReadLine();

Console.Write("Please enter your Period 4 Course Code: ");
Period_4_Course_Code = Console.ReadLine();

Console.Write("Please enter your Period 5 Course Code: ");
Period_5_Course_Code = Console.ReadLine();

Console.Write("Please enter your Period 1 Mark: ");
Period_1_Mark = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your Period 2 Mark: ");
Period_2_Mark = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your Period 3 Mark: ");
Period_3_Mark = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your Period 4 Mark: ");
Period_4_Mark = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your Period 5 Mark: ");
Period_5_Mark = Convert.ToInt32(Console.ReadLine());

Console.Write("How many courses did you take: ");
numCourses = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Name: " +  First_Name + Last_Name, '\n');
Console.WriteLine("Street Number: "+ Student_Number, '\n');
Console.WriteLine("City: " + City, '\n');
Console.WriteLine("Province: " + Province, '\n');
Console.WriteLine("Postal Code:  " + Postal_Code, '\n');
Console.WriteLine("Phone:  " + Phone, '\n');

Console.WriteLine("Period 1","\t","Period 2","\t","Period 3","\t","Period 4","\t","Period 5", '\n');
Console.WriteLine("--------","\t","--------","\t","--------","\t","--------","\t","--------", '\n');
Console.WriteLine('\n');
Console.WriteLine(Period_1_Course_Code + '\t' + Period_2_Course_Code + '\t' + Period_3_Course_Code + '\t', Period_4_Course_Code + '\t' + Period_5_Course_Code);
Console.WriteLine('\n');
Console.WriteLine((Period_1_Mark + '\t' + Period_2_Mark + '\t', Period_3_Mark + '\t' + Period_4_Mark + '\t' + Period_5_Mark));

average = (((Period_1_Mark + Period_2_Mark + Period_3_Mark + Period_4_Mark + Period_5_Mark) / numCourses));

Console.WriteLine( "Your average is: " + average);