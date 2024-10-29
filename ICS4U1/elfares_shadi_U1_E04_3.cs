GetStudentInfo();
void GetStudentInfo()
{
    Console.WriteLine("Please enter your name: ");
    string name = Console.ReadLine();

    Console.WriteLine("Enter your first mark: ");
    double mark1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter your second mark: ");
    double mark2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter your third mark: ");
    double mark3 = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter your fourth mark: ");
    double mark4 = int.Parse(Console.ReadLine());
    OutputTable(name, mark1, mark2, mark3, mark4);
}

void OutputTable(string name, double mark1, double mark2, double mark3, double mark4)
{
    Console.WriteLine("Name: {0}", name);
    Console.WriteLine();
    Console.WriteLine("Mark 1    Mark 2    Mark 3    Mark 4");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("{0}    {1}    {2}    {3}", mark1, mark2, mark3, mark4);
    CalculateAverage(mark1, mark2, mark3, mark4);
}

void CalculateAverage(double mark1, double mark2, double mark3, double  mark4){
    double avg = ((mark1 + mark2 + mark3 + mark4) / 4);
    Console.WriteLine("Your average is: {0}", avg);
}