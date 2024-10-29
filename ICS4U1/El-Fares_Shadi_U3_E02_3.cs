// See https://aka.ms/new-console-template for more information\



for (int variable = 0; variable < 21; variable++)
{   

if (variable % 4 == 0 && variable % 3 == 0)
Console.WriteLine(variable + " * " + " $ " + " @");
    else if (variable % 4 == 0)
    Console.WriteLine(variable + " * " + " $");
        else if (variable % 3 == 0 && variable % 2 == 0)
        Console.WriteLine(variable + " * " +" @");
            else if (variable % 3 == 0)
            Console.WriteLine(variable +" @");
                else if (variable % 2 == 0)
                Console.WriteLine(variable + " *");
                    else
                     Console.WriteLine(variable + " !");
}

