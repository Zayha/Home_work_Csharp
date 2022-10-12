Console.Write("Укажите размерность матрицы через пробел m n: ");
int[] matrixSize = Console.ReadLine()!.Split(' ').Select(e => Convert.ToInt32(e)).ToArray();

int[,] matrix = CreatMatrix(matrixSize);
ShowMatrix(matrix);
Console.WriteLine();
Console.WriteLine($"Минимальное значение суммы в строке с индексом {MinimumSummaryValueInRow(matrix)[0]} сумма в строке = {MinimumSummaryValueInRow(matrix)[1]}");

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

int[] MinimumSummaryValueInRow(int[,] array)
{
    int sum = 0;
    int minindex = 0;
    int minsum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (i == 0) minsum = sum;
        if (sum < minsum) 
        {
            minindex = i;
            minsum = sum;  
        }
        sum = 0;
    }
    int[] outdata = new int[] {minindex, minsum};
    return outdata;
}