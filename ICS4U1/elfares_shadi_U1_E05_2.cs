int GenerateRandomNum(int start, int end)
{
    Random rnd = new Random();
    int num = rnd.Next(start, end + 1);
    return num;
}

int CheckNumberGuess(int randNum, int guess, int start, int end)
{
    if (guess == randNum)
    {
        return 1;
    }
    else if (guess < 1 || guess > 10)
    {
        return -1;
    }
    else
    {
        return 0;

    }
}


while (true)
{
    int randNum = GenerateRandomNum(1, 10);

    Console.WriteLine("Guess a number between 1-10");
    int guess = int.Parse(Console.ReadLine());

    int checkval = CheckNumberGuess(randNum, guess, 1, 10);
    if (checkval == 1)
    {
        Console.WriteLine("The answer was correct.");
        break;
    }
    else if (checkval == 0)
    {
        Console.WriteLine("The answer was incorrect.");
    }
    else if (checkval == -1)
    {
        Console.WriteLine("Enter a value within range.");
    }
}