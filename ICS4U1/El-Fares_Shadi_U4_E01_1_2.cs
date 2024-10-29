string[] class= { "ICS3UE", "MCR3U1", "LUNCH", "TTJ3C1", "TEJ3E1" };
double[] num = { 74, 88, 0, 89, 79 };
int position = 0;

Console.Write("What period would you like to know on?: ");
position = Convert.ToInt32(Console.ReadLine());
position = position - 1;

while(true)
{
if (position == 2)
    {
        Console.WriteLine("Course: " + courses[position]);
        Console.WriteLine("Mark: N/A");
        break;
    }
        else if (position >= 0 && position <= 4)
        {
            Console.WriteLine("Course: " + courses[position]);
            Console.WriteLine("Mark: " + num[position]);
            break;
        }
            else if (position < 0 || position > 4)
            {
                Console.Write("Enter a Period (1-5): ");
                position = Convert.ToInt32(Console.ReadLine());
                position = position - 1;
            }
}
