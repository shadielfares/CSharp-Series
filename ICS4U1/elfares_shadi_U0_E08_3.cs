        Console.Write("Enter a string: ");
        string s = Console.ReadLine();

        char p = '\0'; // initialize previous character to null character
        int c = 0;

        for (int i = 0; i < s.Length; i++)
        {
            char x = s[i];

            if (char.IsLetter(x))
            {
                char l = char.ToLower(x);
                char m = char.ToLower(p);

                if (l == m)
                {
                    c++;
                }
            }

            p = x;
        }

        Console.WriteLine("Number of side-by-side letters: " + c);