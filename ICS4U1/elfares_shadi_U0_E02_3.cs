Console.WriteLine("Hello World!\n");

Console.WriteLine("Countdown from 5");

for (int i = 4; i > 0; i--)
{
    Console.WriteLine("{0}", i);
    if (i == 1)
    Console.WriteLine("\nBlast Off!");
}

Console.WriteLine();


double x = 5.2;
double y = 6.3;
int w = 5;

double answerA = x + y;
int answerB = w + w;
int answerC = answerB * answerB;

Console.WriteLine("5.2 + 6.3 = " + answerA);
Console.WriteLine("five plus five is " + answerB);
Console.WriteLine("10 * 10 = " + answerC + ", Goodbye!");
