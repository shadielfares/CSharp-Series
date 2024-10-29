//a) 
for(int i = 1; i <= 10; i++){
        Console.WriteLine(i);
}

//b
Console.WriteLine("\n\n");
for(int i = 0; i <= 21; i += 3){
        Console.Write(i + " ");
}

//c
Console.WriteLine("\n\n");
for(int i = 50; i >= 40; i -= 4){
        Console.Write(i + " ");
}

//d
Console.WriteLine("\n\n");
Console.WriteLine("Please input a number less than 35!");
int userInp = Convert.ToInt32(Console.ReadLine());
for(int i = userInp; i <= 35; i++){
        Console.Write(i + " ");
}