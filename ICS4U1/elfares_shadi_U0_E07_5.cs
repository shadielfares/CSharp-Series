// for (int x = 0; x < 3;){
// for (int i = 0; i < 6; i++){
//     Console.Write(i);
// }
// Console.WriteLine();
// x++;
// }
// 

//---

// int x = 0, y = 0, z = 6, a = 1;;
// for (;x < 3; x++)
// {
//     y = 0;
// {
//     for (;y < z; y++)
//     {     
//     Console.Write(x + y + " ");
//     }
// }
   
//     Console.WriteLine();
// }

//---


// for (int x = 0; x < 5; x++)
// {
//     for (int y = 4; y >= 0; y--)
//     {
//         if (y > x)
//             Console.Write(' ');
//         else
//             Console.Write('*');
//     }
//     for (int y = 0; y <= x - 1; y++)
//     {
//         Console.Write('*');
//     }

//     Console.WriteLine();
// }

//---

// for (int x = 0; x <=5; x++)
// {
//     for (int y = 5; y > 1; y--)
//     {
//         if (y > x)
//             Console.Write(' ');
//         else
//             Console.Write(x);
//     }
//     for (int y = 0; y < x; y++)
//     {
//         Console.Write(x);
//     }
//     Console.WriteLine();
// }

//----------------------

// int a = 5, b, c;
// int e = 1;
// String d;

// for (b = 1; b <= a; b++)
// {
//      for(c = 1; c < b+1; c++)
//      {
// 		d = e > 9 ? (e + "") : (e + " ");	
//             Console.Write(d + " ");
//                 e++;
//     }
//     Console.WriteLine(); 
// }

//----------------------

for (int x = 0; x <= 5; x++)
{
    for (int y = 5; y > 1; y--)
    {
        if (y > x)
            
            Console.Write(' ');
        else
            Console.Write(y);
    }
    for (int y = 1; y <= x; y++)
    {
        Console.Write(y);
    }
    Console.WriteLine();
}