//Тестирование кода
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
ShowMatrix(MatrixPower(a, 75));

//Возведение матрицы в степень, использует функцию MatrixMultiplication
double[,] MatrixPower(double[,] m, int power)
{   
    double[,] r = m;
    if(power == 1) return m;
    for(int i = 2; i <= power; i++)
    {
        r = MatrixMultiplication(r, m);
    }
    return r;
}

// Умножение матриц
double[,] MatrixMultiplication(double[,] a, double[,] b)
{
    if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Невозможно перемножить");
    double[,] r = new double[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                r[i, j] += a[i, k] * b[k, j];
            }
        }
    }
    return r;
}

//Отображение матрицы
void ShowMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"| {array[i, j].ToString("0.")} |");
        }
        Console.WriteLine();
    }
}