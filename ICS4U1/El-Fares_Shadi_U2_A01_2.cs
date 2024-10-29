// See https://aka.ms/new-console-template for more information
int elec_used = 0;
double bill_total = 0;
bool valid_answer = true;
double charge = 0;

try
{
    Console.Write("How much electricity units have you used: " + '\n');
    elec_used = Convert.ToInt32(Console.ReadLine());
}
catch
{
    valid_answer = false;

    if (valid_answer != true)
        Console.Write("Enter a valid answer");
}

{
    {
        if (elec_used >= 0 && elec_used <= 50)
        {
        charge = 0.50;
        bill_total = elec_used * charge;
        }
       
    }

    {
        if (elec_used >= 51 && elec_used <= 150)
        {
        charge = 0.75 ;
        bill_total = elec_used * charge;
        }
       
    }
    
    {
        if (elec_used >= 151 && elec_used <= 250)
        {
        charge = 1.20;
        bill_total = elec_used * charge;  
        }
       
    }

    {
        if (elec_used > 250)
        {
        charge = 1.50;
        bill_total = elec_used * charge;  
        }
        
    }
}

double f_billp = (bill_total  * 0.20);

double f_bill = (bill_total + f_billp);

Console.Write("Your total electricity bill is: " + f_bill);
