Console.WriteLine("Please enter the amount of money to convert: ");
double money = double.Parse(Console.ReadLine());

Console.WriteLine("Please enter the code of momey you have: ");
string code = Console.ReadLine();
//The question asks to ask for the current currency code and the currency code to convert to, but I don't think it is actually useful in this particular scenario as you have one or the other.


void ConvertCurrency(ref double money, string code)
{
if(code.ToUpper() == "US"){
money = money * 1.30;
Console.WriteLine("Your {0}, is now {1} CAD.", code, money);
}
else if(code.ToUpper() == "CAD"){
money = money * 0.70;
Console.WriteLine("Your {0}, is now {1} US.", code, money);
}
}
ConvertCurrency(ref money, code);