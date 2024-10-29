// See https://aka.ms/new-console-template for more information
string var1 = "1) mph" + '\n';
string var2 = "2) kt" + '\n';
string var3 = "3) km/hr" + '\n';

int response = 0;
string category = "";
string unit = "";
int speed = 0;

Console.Write(var1);
Console.Write(var2);
Console.Write(var3);

bool validanswer = true;

try 
{Console.Write("Which hurricane speed do you wish to use?" + '\n');
response = Convert.ToInt32(Console.ReadLine());
}
catch
{
validanswer = false;

if (!validanswer)
    Console.Write("Enter a valid entry.");
else
    Console.Write("Continue.");
}
try
{
if (response == 1)

    unit = "mph";
else if (response == 2)
    unit = "kt";
else if (response == 3)
    unit = "km/hr";
else 
    Console.Write("Please enter a valid option.");
}
catch
{
validanswer = false;

if (!validanswer)
    Console.Write("Enter a valid entry.");
else
    Console.Write("Continue.");
}



if (response > 0 && response < 4)
    Console.Write("How fast is the hurricane " + "(" + unit + ")" + " : " + '\n');
    speed = Convert.ToInt32(Console.ReadLine());

if ((response == 1  && speed >= 74 && speed <= 95) || (response == 2 && speed >= 64 && speed <= 82) || (response == 3 && speed >= 119 && speed <= 153))
    category = "Category 1";
else if ((response == 1  && speed >= 96 && speed <= 110) || (response == 2 && speed >= 83 && speed <= 95) || (response == 3 && speed >= 154 && speed <= 117))
    category = "Category 2";
else if ((response == 1  && speed >= 111 && speed <= 130) || (response == 2 && speed >= 96 && speed <= 113) || (response == 3 && speed >= 178 && speed <= 209))
    category = "Category 3";
else if ((response == 1  && speed >= 131 && speed <= 155) || (response == 2 && speed >= 114 && speed <= 135) || (response == 3 && speed >= 210 && speed <= 249))
    category = "Category 4";
else if ((response == 1  && speed > 155) || (response == 2 && speed > 135) || (response == 3 && speed > 249))
    category = "Category 5";

Console.Write("Your hurricane category is: " + category);
