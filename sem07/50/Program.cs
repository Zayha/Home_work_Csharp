Console.Clear();

Console.Write("Укажите размерность матрицы через пробел m n: ");
int[] matrixSize = Console.ReadLine()!.Split(' ').Select(e => Convert.ToInt32(e)).ToArray();
Console.Write("Укажите через пробел индекс элемента в матрице: ");
int[] matrixIndex = Console.ReadLine()!.Split(' ').Select(e => Convert.ToInt32(e)).ToArray();

CheckAndShowIndex(CreatMatrix(matrixSize), matrixIndex[0], matrixIndex[1]);

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

void CheckAndShowIndex(int[,] array, int x, int y)
{
    if (array.GetLength(0) > x && array.GetLength(1) > y)
    {
        Console.WriteLine($"Элемент с индексом [{x}, {y}] имеет значение = {array[x, y]}");
    }
    else
    {
        Console.WriteLine($"Элемент с индексом [{x}, {y}] отсутствует");
    }
}