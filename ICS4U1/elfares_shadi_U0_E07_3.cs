//Write a program that asks the user for a sentence and then calculates and outputs how many
// vowels are in that sentence. Hint: Use a for-loop to iterate through each character of the string and
// then use a separate counter variable inside the for-loop to increment by ‘1’ whenever a vowel is
// found. Make sure to test for both upper-case and lower-case vowels.

Console.WriteLine("Enter a sentence: ");
        string sentence = Console.ReadLine();

Console.WriteLine("Enter a character: ");
char character = Convert.ToChar(Console.ReadLine());
int charCnt = 0;

        for (int i = 0; i < sentence.Length; i++) {
            char ch = Char.ToLower(sentence[i]);
            if (ch == character) {
                charCnt++;
            }
        }

        Console.WriteLine("The number of times " + character + " is in the sentence is: " + charCnt);