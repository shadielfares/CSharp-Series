   double[] Array5D = { 3.11, 8.54, 6, 3.2, 12.98 };

        Console.Write("Please input a value for 'v': ");
        double v = Convert.ToDouble(Console.ReadLine());

        Console.Write("Please input an index for 'i': ");
        int i = Convert.ToInt32(Console.ReadLine());

        // Shift elements to the right from index 'i' to the end
        for (int j = Array5D.Length - 1; j > i; j--)
        {
            Array5D[j] = Array5D[j - 1];
        }

        // Replace the value at index 'i' with the input value 'v'
        Array5D[i] = v;

        Console.WriteLine("Array after replacement:");
        for (int x = 0; x < Array5D.Length; x++)
        {
            Console.WriteLine(Array5D[x]);
        }