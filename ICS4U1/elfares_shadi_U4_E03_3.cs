using System;

char[,] my2DArray = new char[5,5];
Random rnd = new Random();
char randomChar;
bool found = false;

for (int e=0; e<5; e++)
{
   for (int f=0; f<5; f++)
   {
      randomChar = (char)rnd.Next('a','z');

      for (int i=0; i<5; i++)
      {
         for (int j=0; j<5; j++)
         {
            if (Convert.ToChar(my2DArray[i,j]) == randomChar)
            {
               found = true;
            }
         }
      }

      if (found == true)
      {
          f = f-1;
      }  
      else 
      {
         my2DArray[e,f] = randomChar;
      }
      found = false;
   }
}

for (int m=0; m<5; m++)
{
   for (int n=0; n<5; n++)
   {
      Console.Write($"{my2DArray[m,n]} ");
   }
   Console.WriteLine();
}

bool validInputX = false;
bool validInputY = false;
bool validInputLetter = false;
int x = 0;
int y = 0;
char letter = ' ';
bool playAgain = true;

do 
{
   if (!validInputX)
   {
      try 
      {
         Console.WriteLine("Please enter an positive integer from 1 to 5 for x >");
         x = Convert.ToInt16(Console.ReadLine().Trim());
         
         if (x != -1)
         {
            x = x-1;

            if (x > 0 && x < 6)
               validInputX = true;
         }
      }
      catch {}
   }

   if (!validInputY && validInputX)
   {
      try 
      {
         Console.WriteLine("Please enter an positive integer from 1 to 5 for y >");
         y = Convert.ToInt16(Console.ReadLine().Trim());

         if (y != -1)
         {
            y = y-1;

            if (y > 0 && y < 6)
               validInputY = true;
         }
      }
      catch {}
   }

   if (!validInputLetter && validInputY && validInputX)
   {
      try 
      {
         Console.WriteLine("Please enter a letter from the alphabet >");
         letter = Convert.ToChar(Console.ReadLine().Trim());
         validInputLetter = true;

         if (validInputX && validInputY && validInputLetter && playAgain == true)
         {
            for (int i=0; i<5; i++)
            {
               for (int j=0; j<5; j++)
               {
                  if (my2DArray[i,j].ToString().ToLower() == letter.ToString().ToLower())
                  {
                     validInputLetter = false;
                  }
               }
            }
         }

         if (!validInputLetter)
            Console.WriteLine("That letter already exists in the array.");
         else
         {
            my2DArray[x,y] = letter;
            
            for (int i=0; i<5; i++)
            {
               for (int j=0; j<5; j++)
               {
                  Console.Write($"{my2DArray[i,j]} ");
               }
               Console.WriteLine();
            }

            validInputX = false;
            validInputY = false;
            validInputLetter = false;
            playAgain = true;
         }
            
      }
      catch {}
   }

   if (x == -1 || y == -1 || playAgain == false)
   {
      validInputX = true;
      validInputY = true;
      validInputLetter = true;
      playAgain = false;
   }

} while (!validInputX || !validInputY || !validInputLetter || playAgain);

Console.WriteLine("Goodbye!");