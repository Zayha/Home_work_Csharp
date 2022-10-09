Console.Clear();
Console.WriteLine("\n\n\n************* S T A R T *************");
double[,] a = new double[2, 2];
a[0, 0] = 1.0;
a[0, 1] = 1.0;
a[1, 0] = 1.0;
a[1, 1] = 0.0;

Console.WriteLine();
ShowMatrix(a);
Console.WriteLine();
MatrixPower(a, 5);

double[,] MatrixPower(double[,] m, int power)
{
    double[,] o = new double[2, 2];
    double[,] n = new double[2, 2];
    o = m;
    if(power == 1) return m;
    for (int i = 2; i <= power; i++)
    {
        n[0, 0] = o[0, 0] * m[0, 0] + o[0, 1] * m[1, 0];
        n[0, 1] = o[0, 0] * m[0, 1] + o[0, 1] * m[1, 1];
        n[1, 0] = o[1, 0] * m[0, 0] + o[1, 1] * m[1, 0];
        n[1, 1] = o[1, 0] * m[0, 1] + o[1, 1] * m[1, 1];
        Console.WriteLine($"-------------------> i: {i}");
        Console.WriteLine("-------------------> m:");
        ShowMatrix(m);
        Console.WriteLine("-------------------> n:");
        ShowMatrix(n);
        Console.WriteLine("-------------------> o:");
        o = n;
        ShowMatrix(o);
    }
    return n;
}

void ShowMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"| {array[i, j]} |");
        }
        Console.WriteLine();
    }
}