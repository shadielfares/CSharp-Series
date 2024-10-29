//Initialize variables
char[,] board = new char[3, 3];
char h = '\0', piece = 'X';
bool Win = false, TiePos = false, Rep = false;
int q = 0;
string Player = "Player 1";
Random rnd = new Random();
int a = 0, b = 0, c = 0, d = 0, e = 0, f = 0, g = 0, j = 0, Count = 0, TabCheck = 0;
//Drawing Board
void DrawBoard()
{
        Console.WriteLine("   {0}  |  {1}  |  {2}   ", board[0, 0], board[0, 1], board[0, 2]);
        Console.WriteLine("------------------");
        Console.WriteLine("   {0}  |  {1}  |  {2}   ", board[1,0], board[1, 1], board[1, 2]);
        Console.WriteLine("------------------");
        Console.WriteLine("   {0}  |  {1}  |  {2}   ", board[2, 0], board[2, 1], board[2, 2]);
    
}
//Resetting Board
void ResetBoard()
{
    for (int x = 0; x < 3; x++)
    {
        for (int y = 0; y < 3; y++)
        {
            board[x, y] = '\0';
        }
    }
}
//Check for win
void CheckWin()
{
    h = piece;
    for (int x = 0; x < 3; x++)
    {
        for (int y = 0; y < 3; y++)
        {
            Count = 0;

            if (board[x, y] == h)
            {
                Count++;
                if (x > 0 && board[x - 1, y] == h)
                    Count++;
                if (x < 3 - 1 && board[x + 1, y] == h)
                    Count++;
                if (Count >= 3)
                {
                    Win = true;
                }
            }
            Count = 0;
            if (board[x, y] == h)
            {
                Count++;
                if (y > 0 && board[x, y - 1] == h)
                    Count++;
                if (y < 3 - 1 && board[x, y + 1] == h)
                    Count++;
                if (Count >= 3)
                {
                    Win = true;
                }
            }
            Count = 0;
            if (board[x, y] == h)
            {
                Count++;
                if (x == 1 && y == 1 && board[x + 1, y + 1] == h)
                    Count++;
                if (x == 1 && y == 1 && board[x - 1, y - 1] == h)
                    Count++;
                if (Count >= 3)
                {
                    Win = true;
                }
            }
            Count = 0;
            if (board[x, y] == h)
            {
                Count++;
                if (x == 1 && y == 1 && board[x - 1, y + 1] == h)
                    Count++;
                if (x == 1 && y == 1 && board[x + 1, y - 1] == h)
                    Count++;
                if (Count >= 3)
                {
                    Win = true;
                }
            }
        }
    }
}
//Turns system
void Moves()
{
    while (d != 1)
    {
        DrawBoard();
        Console.Write("\nEnter -1 to exit.\n");

        try
        {
            Console.Write(Player + " enter an x-coordinate: ");
            a = Convert.ToInt32(Console.ReadLine());

            if (a == -1)
            {
                Console.Write("Exiting.");
                Environment.Exit(0);
            }

            Console.Write(Player + ", enter a y-coordinate: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (b == -1)
            {
                Console.Write("Exiting.");
                Environment.Exit(0);
            }
        }
        catch
        {
            Console.WriteLine("Make a valid entry!");
            Thread.Sleep(1250);
            c = 1;
        }

        if (a >= 0 && a <= 2 && b >= 0 && b <= 2 && c != 1)
        {
            f = 1;
        }
        else if (c != 1)
        {
            Console.WriteLine("Make a valid entry!");
            Thread.Sleep(1250);
            c = 0;
        }
        else if (c == 1)
            c = 0;

        if (f == 1)
        {
            if (board[a, b] != '\0')
            {
                Console.WriteLine("\nThis spot is taken, make a valid entry!");
                Thread.Sleep(1250);
                f = 0;
            }
            else
            {
                board[a, b] = piece;
                f = 0;
                d = 1;
            }

        }
        Console.Clear();
    }

}
//Check for a draw
void CheckDraw()
{
    TabCheck = 0;
    for (int x = 0; x < 3; x++)
    {
        for (int y = 0; y < 3; y++)
        {
            if (board[x, y] == 'X' || board[x, y] == 'O')
                TabCheck++;
            if (TabCheck == 9)
                TiePos = true;
        }
    }
}
//2 Player Tic-Tac-Toe
void DuoPlay()
{
    Console.Clear();
    Console.Write("Player 1 = 'X'\nPlayer 2 = 'O'");
    Thread.Sleep(1000);
    Console.Clear();

    while (a != -1 || b != -1)
    {
        d = 0;
        piece = 'X';
        Player = "Player 1";
        Moves();
        CheckWin();
        if (Win == true)
        {
            d = 0;
            e = 0;
            DrawBoard();
            Console.WriteLine("Player 1 is Victorious!");
            Thread.Sleep(2000);
            Win = false;
            break;
        }
        CheckDraw();
        if (TiePos == true)
        {
            d = 0;
            e = 0;
            DrawBoard();
            Console.WriteLine("Its a Draw!");
            Thread.Sleep(2000);
            TiePos = false;
            break;
        }
        d = 0;
        piece = 'O';
        Player = "Player 2";
        Moves();
        CheckWin();
        if (Win == true)
        {
            d = 0;
            e = 0;
            DrawBoard();
            Console.WriteLine("Player 2 is Victorious!");
            Win = false;
            Thread.Sleep(2000);
            break;
        }
        CheckDraw();
        if (TiePos == true)
        {
            d = 0;
            e = 0;
            DrawBoard();
            Console.WriteLine("Its a Draw!");
            Thread.Sleep(2000);
            TiePos = false;
            break;
        }
    }
}
//One Player Tic-Tac-Toe
void SinglePlay()
{
    Console.Clear();
    Console.Write("Player 1 = 'X'\nComputer = 'O'");
    Thread.Sleep(1000);
    Console.Clear();

    while (true)
    {
        piece = 'X';
        Player = "Player 1";
        Moves();
        CheckWin();
        if (Win == true)
        {
            d = 0;
            e = 0;
            DrawBoard();
            Console.WriteLine("Player 1 Is Victorious!");
            Thread.Sleep(2000);
            Win = false;
            break;
        }
        CheckDraw();
        if (TiePos == true)
        {
            d = 0;
            e = 0;
            DrawBoard();
            Console.WriteLine("Its a Draw!");
            Thread.Sleep(2000);
            TiePos = false;
            break;
        }
        while (e != 1)
        {
            a = (int)rnd.Next(0, 3);
            b = (int)rnd.Next(0, 3);

            if (board[a, b] != '\0')
                e = 0;
            else
            {
                board[a, b] = 'O';
                f = 0;
                e = 1;
            }
        }
        CheckWin();
        if (Win == true)
        {
            d = 0;
            e = 0;
            DrawBoard();
            Console.WriteLine("The Computer Wins!");
            Win = false;
            Thread.Sleep(2000);
            break;
        }
        CheckDraw();
        if (TiePos == true)
        {
            d = 0;
            e = 0;
            DrawBoard();
            Console.WriteLine("Its a Tie!");
            Thread.Sleep(2000);
            TiePos = false;
            break;
        }
        if (e == 1 && d == 1)
        {
            d = 0;
            e = 0;
        }
    }
}
//Enter Players
void Enter()
{
    Console.Clear();
    Console.Write("            Tic Tac Toe\n----------------------------------\n 1)    Single Player (1 Player)\n 2)    Dual play (2 Player)\n----------------------------------\n");
    Console.Write("\nWhat gamemode would you like? (1 or 2): ");
    try
    {
        g = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
        Rep = false;
        g = 3;
    }

    if (g == 2)
    {
        Rep = true;
        DuoPlay();
    }
    else if (g == 1)
    {
        Rep = true;
        SinglePlay();
    }
    else if (g == 3 || g != 1 || g != 2)
    {
        Rep = false;
        Console.WriteLine("Enter either 1 or 2");
        Thread.Sleep(1250);
    }
}
while (true)
{
    if (Rep == true)
    {
        Console.Write("To play again enter 1 otherwise enter -1'): ");
        q = Convert.ToInt32(Console.ReadLine());
       

        if (q == 1)
        {
            Rep = false;
            ResetBoard();
            Enter();
        }
        else if (q == -1)
        {
            Console.WriteLine("Now exiting.");
            Environment.Exit(0);
        }
    }
    else if (j == 0)
        Enter();
}