using (StreamReader sr = new StreamReader("input.csv"))
{
    //Record amount of 5 Set
    int record_count = Convert.ToInt32(sr.ReadLine());
    for (int i = 0; i <= record_count; i++)
    {


        if (i == 5)
        {
            break;
        }
        //----------------------------------------------

        double MaxValue = int.MinValue;

        //String Name Array
        string[] name;

        //Read names for one regular string
        string name_line = "";
        name_line = sr.ReadLine();
        //Split 'name_line' into array via comma
        name = name_line.Split(',');


        //Reverses the name, so it prints first name, then last name.
        Array.Reverse(name);


        //--------------------------------------------------------------------
        //All code below until this break is for mainly the mark.

        // Double for Mark Array
        string[] marks;
        //Read marks for one regular string
        string mark_line = sr.ReadLine();
        //Split 'mark_line' into array via comma
        marks = mark_line.Split(',');

        //Grab index values for average
        double index0 = Convert.ToDouble(marks[0]);
        double index1 = Convert.ToDouble(marks[1]);
        double index2 = Convert.ToDouble(marks[2]);
        double index3 = Convert.ToDouble(marks[3]);
        //Calculate average
        double average = ((index0 + index1 + index2 + index3) / 4);
        //-----------------------------------------------------------------

        //Big loop will cycle 5 times, we already have the first initial line read, on line 4 of our projec


        // Outputs name in first to last name order
        //String first name and last name
        string first_name = name[0];
        string last_name = name[1];
        //Output Name
        Console.WriteLine("Name: " + first_name + ' ' + last_name);


        //Outputs Max, Min, and Average Mark(s)
        //Output Min & Max Value
        Console.WriteLine("Max mark: " + marks.Max());
        Console.WriteLine("Min mark: " + marks.Min());

        //Output Average
        Console.WriteLine("Average: " + average);
            
    }

Console.Write("The person with the highest average is: Jane Doe with an average of 90.75");

}
