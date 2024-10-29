Console.WriteLine("What is your gender (Male or Female): ");
string gender = Console.ReadLine().ToLower();

Console.WriteLine("What is your hole length: ");
int hlength = Convert.ToInt32(Console.ReadLine());

if(gender == "male" && hlength <= 250 || gender == "female" && hlength <= 210){
Console.WriteLine("The hole is a par 3");
} else if (gender == "male" && hlength >= 251  && hlength <= 470 || gender == "female" && hlength>= 211 && hlength <= 400){
Console.WriteLine("The hole is a par 4");
} else if (gender == "male" && hlength >= 471  && hlength <= 690 || gender == "female" && hlength>= 401 && hlength <= 575){
Console.WriteLine("The hole is a par 5");
} else if (gender == "male" && hlength >= 691 || gender == "female" && hlength>= 576){
Console.WriteLine("The hole is a par 6");
}