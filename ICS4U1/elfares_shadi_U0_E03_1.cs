int a = ((7 * 3) + 2) * 6;

double b = (double)3 / 2 / 7;


int r = 2;
double s = (double)5 / r;

int f = 4, g = 7;
double h = (double)f / g;

int w = 4;
double x = 5.3;
double z = w / x;
double e = (double)z / ((double)1 / w);

int i = 7, j = 2;
double k = ((double)i + (3 * 5)) / (double)j + (3 * 6);

Console.WriteLine("Answers: " 
    + "A) " + a
    + ", B) " + Math.Round(b, 2)
    + ", C) " + Math.Round(s, 2)
    + ", D) " + Math.Round(h, 2)
    + ", E) " + Math.Round(e, 2)
    + ", F) " + k);
