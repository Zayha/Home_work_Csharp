Console.Clear();

ShowMatrix(CreatMatrix());

double[,] CreatMatrix()
{   
    Console.Write("Укажите размерность матрицы через пробел m n: ");
    int[] matrixSize = Console.ReadLine()!.Split(' ').Select(e => Convert.ToInt32(e)).ToArray();
    double[,] array = new double[matrixSize[0], matrixSize[1]];
    Random rnd = new Random(); 
    for (int i = 0; i < matrixSize[0]; i++)
    {
        for (int j = 0; j < matrixSize[1]; j++)
        {
            array[i, j] = rnd.NextDouble() * rnd.Next(-9, 9);
        }
    }
    return array;
}

void ShowMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j].ToString("0.00")} ");
        }
    Console.WriteLine();    
    }
}