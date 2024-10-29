// See https://aka.ms/new-console-template for more information

// int count = 0;
// Console.Write("How many numbers would you like to add: ");
// count = Convert.ToInt32(Console.ReadLine());

// int iterations = 0;
// int integer = 0, total = 0;
// int maxInt = Int32.MinValue;
// int minInt = Int32.MaxValue;


// while (iterations != count)
// {

//     Console.Write("What integer would you like to add: ");
//     integer = Convert.ToInt32(Console.ReadLine());
//     total = total + integer;

//     if (integer < minInt)
//         minInt = integer;
    
//     if (integer > maxInt)
//         maxInt = integer;

// iterations++;
// }

// Console.Write(minInt);

// double avg = total / count;
// Console.Write("Your total is: " + total + '\n');
// Console.Write("Your average is: " + avg);
// Console.Write("\nYour largest possible integer is: " + maxInt);
// Console.Write("\nYour smallest possible integer is: " + minInt);

// double count = 0, userInt = 0, total = 0, counter = 0, largest = 0, smallest = 0;
// double average = 0;

// Console.Write("Please enter how many integers you wish to input: ");
// count = Convert.ToInt32(Console.ReadLine());
// counter = count;

// Console.Write("Please enter an integer: ");
// userInt  = Convert.ToInt32(Console.ReadLine());
// count--;

// largest = userInt;
// smallest = userInt;
// total = userInt + total;

// while(count > 0)
// {
//     Console.Write("Please enter an integer: ");
//     userInt  = Convert.ToInt32(Console.ReadLine());
//     total = userInt + total;

//     if (userInt > largest)
//         largest = userInt;
//     else if (userInt < smallest)
//         smallest = userInt;
    
//     count--;
// }

// average = total / counter;

// Console.WriteLine("The total of these integers is " + total + ". The average of these integers is " + average.ToString("0.00") + ".");
// Console.WriteLine("The largest integer you entered is " + largest + ". The smallest intger you entered is " + smallest + ". ");

int a2 = 0;
int var2_1 = 1;
int b = 0;
int c = 0;
int formula = 0;


Console.WriteLine("Please enter a value for variable 1: ");
a2 =  Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter a value for variable 2: ");
b =  Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter a value for variable 3: ");
c =  Convert.ToInt32(Console.ReadLine());

// double formula_1 = (double)formula;

int work = 0;

float work1 = (float)work;

work1 = (a2 / b) + (var2_1 / c);

Console.Write(work1);

// formula_1 = Math.Sqrt(work1);

// string formula_1s = work1.ToString("0.0000000");

// Console.WriteLine("The answer is: " + formula_1s);

