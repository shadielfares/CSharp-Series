// See https://aka.ms/new-console-template for more information
string name = "";

string var1 = "1) mph" + '\n';
string var3 = "2) km/hr" + '\n';
string unit = "";

int offences = 0;
int speed_t = 0;
int demerit = 0;
int speed = 0;
int demerits_g = 0;
int fine = 0;
bool valid_answer = true;

try
{
Console.Write("Whats your full name? " + '\n');
name = Console.ReadLine();
}
catch
{
valid_answer = false;

if (valid_answer == false)
    Console.Write("Try again. ");
}


if (valid_answer != false)
try
{
Console.Write("What is the number of offences you have committed?" + '\n');
offences = Convert.ToInt32(Console.ReadLine());
}
catch
{
valid_answer = false;

if (valid_answer == false)
    Console.Write("Try again. ");
}

if (valid_answer != false)
try
{
Console.Write("What is the number of demerit poionts you have incurred?" + '\n');
demerit = Convert.ToInt32(Console.ReadLine());
}
catch
{
valid_answer = false;

if (valid_answer == false)
    Console.Write("Try again. ");
}

if (valid_answer != false)
try
{
Console.Write(var1);
Console.Write(var3);


Console.Write("Which unit of speed do you wish to use?" + '\n');
speed_t = Convert.ToInt32(Console.ReadLine());
}
catch
{
valid_answer = false;

if (valid_answer == false)
    Console.Write("Try again. ");
}


if (speed_t == 1)
    unit = "mph";
else if (speed_t == 2)
    unit = "km/hr";
else 
    Console.Write("Please enter a valid option.");

if (speed_t > 0 && speed_t < 3)
    Console.Write("What was the speed travelled by the offender " + "(" + unit + ")" + " : " + '\n');
    speed = Convert.ToInt32(Console.ReadLine());

if ((speed_t == 1  && speed >= 35 && speed <= 45) || (speed_t == 2 && speed >= 50 && speed <= 60))
{
    demerits_g = 3;
    fine = 60;
}
   
else if ((speed_t == 1  && speed >= 46 && speed <= 65) || (speed_t == 2 && speed >= 61 && speed <= 80))
    {
    demerits_g = 4;
    fine = 180;
    }
   
else if ((speed_t == 1  && speed > 65) || (speed_t == 2 && speed > 80))
        {
        demerits_g = 6;
        fine = 360;
        }

int demerit_t = demerit + demerits_g;

string l_eligibilty = "Your license is eligible.";
int fine_n = 0;

if (offences > 0)
    fine_n = fine * offences;
    
if (demerit == 15 || demerit_t >= 15)
    l_eligibilty = "Your license is suspended.";
    
Console.Write("Name: " + name + '\n');
Console.Write("---------------------------------------------" + '\n');
Console.Write("Previous Offences: " + offences + '\n');
Console.Write("Previous # Of Demerit Points: " + demerit + '\n');
Console.Write('\n' + "Registered Speed: " + speed + unit + '\n');
Console.Write("Fine: $" + fine + " " + "x " + offences + " " + "= $" + fine_n + '\n');
Console.Write('\n' +"Demerit Points Incurred: " + demerits_g + '\n');
Console.Write("Current # of Demerit Points: " + demerit_t + '\n');
Console.Write('\n' + l_eligibilty);