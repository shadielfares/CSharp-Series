// See https://aka.ms/new-console-template for more information
Random rnd = new Random();
int randNum = rnd.Next(1, 11);
int guess = 0;
int difference = 0;

Console.WriteLine("Guess a number between 1-10: ");
guess = Convert.ToInt32(Console.ReadLine());
 
difference = guess - randNum;


if (guess == randNum)
    Console.WriteLine("Your guessed the right number!");
else if (guess > 10)
    Console.WriteLine("Your number is greater than 10.");
else
    Console.WriteLine("Your number is off by: "  + Math.Abs(difference));

