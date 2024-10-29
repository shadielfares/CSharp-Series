//part a
// int x = 1;
// for (int r = 1; r <= 5; r++)
// {
//     for (int i = 1; i <= r; i++)
//     {
//         Console.Write(x + " ");
//         x++;
//     }
//     Console.WriteLine();
// }

//part b

// for (int a = 1, p = 1; a <= 5; a++)
// {
//     for (int b = 1; b <= a; b++)
//     {
//         Console.Write(p % 2 + " ");
//         p++;
//     }
//     Console.WriteLine();
// }

//part c

Console.WriteLine("How many rows would you like to output of the pattern: ");
int rows = Convert.ToInt32(Console.ReadLine());

for (int x = rows; x >= 1; x--){
    for (int y = 1; y <= x; y++){
        Console.Write("*" + " ");
    }
    Console.WriteLine();
}