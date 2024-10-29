// See https://aka.ms/new-console-template for more information

Pattern 1
int iterations = 0;
int number = 0;

while (iterations < 5)
{
     number = number + 1;
    Console.Write(number);
    Console.Write('\n');
    iterations++;
}

Pattern 2
int iterations1 = 0;
int number1 = 0;

while (iterations1 < 5)
{
     number1 = number1 + 2;
    Console.Write(number1);
    Console.Write('\n');
    iterations1++;
}

Pattern 3

int iterations1 = 0;
string letter = "";



while (iterations1 < 6)
{
if (iterations1 == 1)
    letter = "A";
else if (iterations1 == 2)
    letter = "B";
else if (iterations1 == 3)
    letter = "C";
else if (iterations1 == 4)
    letter = "D";
else if (iterations1 == 5)
    letter = "E";

    Console.Write(letter);
    Console.Write('\n');
    iterations1++;
}

