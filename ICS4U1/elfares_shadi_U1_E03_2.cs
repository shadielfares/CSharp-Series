static void Options()
{
    Console.WriteLine("Choose a method:");
    Console.WriteLine("1. Date and time.");
    Console.WriteLine("2. Hello, world.");
    Console.WriteLine("3. Goodbye.");
}

Options();
Console.WriteLine("Enter a # (1-3): ");
int choice = int.Parse(Console.ReadLine());

static void ChooseOption( int choice)
{
    if (choice == 1)
    {
        Console.WriteLine(DateTime.Now);
        ;
    }
    else if(choice == 2){
        Console.WriteLine("Hello, world!");
        ;
    }
    else if(choice == 3){
        Console.WriteLine("Goodbye!");
    }
    else
    {
        Console.WriteLine("Invalid choice!"); ;
    }
}

ChooseOption(choice);