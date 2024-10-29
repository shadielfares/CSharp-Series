int[] arrayA = {1, 2, 3, 4, 5};
int[] arrayB = {6, 7, 8, 9, 10};
int[] arrayC = new int[10];

int lengthA = arrayA.Length;
int lengthB = arrayB.Length;
int lengthC = arrayC.Length;

int element = 5;
for (int i = 0; i < lengthA; i++) 
      arrayC[i] = arrayA[i];

    for (int i = 0; i < lengthB; i++)
    {
      arrayC[element] = arrayB[i];
      element++;
    }

    Console.WriteLine("The values of ArrayC are: ");

    for (int i = 0; i < lengthC; i++) {
        Console.WriteLine(arrayC[i]);
    }