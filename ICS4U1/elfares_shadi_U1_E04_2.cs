int guess = 0;
int rannum = 0;

while (true)
{
    Console.WriteLine("Guess a random number between 1-10: ");
    guess = int.Parse(Console.ReadLine());
    

    if (guess == -1)
    {
        break;
    }
        CheckNumberGuess(guess);

}


void CheckNumberGuess(int guess)
{
    Random ran = new Random();
    rannum = ran.Next(1, 11);

    if (guess == rannum)
    {
        Console.WriteLine("Your guess was correct!");
    }
    else
    {
        Console.WriteLine("Your guess was incorrect!");
    }
}
