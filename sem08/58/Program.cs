Console.Write("Укажите размерность матрицы через пробел m n: ");
int[] matrixSize1 = Console.ReadLine()!.Split(' ').Select(e => Convert.ToInt32(e)).ToArray();

Console.Write("Укажите размерность матрицы 2 через пробел m n: ");
int[] matrixSize2 = Console.ReadLine()!.Split(' ').Select(e => Convert.ToInt32(e)).ToArray();

int[,] matrix1 = CreatMatrix(matrixSize1);
int[,] matrix2 = CreatMatrix(matrixSize2);
Console.WriteLine("Матрица 1:");
ShowMatrix(matrix1);
Console.WriteLine("Матрица 2:");
ShowMatrix(matrix2);
Console.WriteLine("----------------------------");
Console.WriteLine("Произведение матриц:");
ShowMatrix(MatrixMultiplication(matrix1, matrix2));

int[,] CreatMatrix(int[] ms)
{
    int[,] array = new int[ms[0], ms[1]];
    Random rnd = new Random();
    for (int i = 0; i < ms[0]; i++)
    {
        for (int j = 0; j < ms[1]; j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}

void ShowMatrix(int[,] array)
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

int[,] MatrixMultiplication(int[,] a, int[,] b)
{
    if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Невозможно перемножить матрицы!");
    int[,] result = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                result[i, j] += a[i, k] * b[k, j];
            }
        }
    }
    return result;
}
