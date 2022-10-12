Console.Write("Укажите размерность 2d массива через пробел a b: ");
int[] matrixSize = Console.ReadLine()!.Split(' ').Select(e => Convert.ToInt32(e)).ToArray();

int[,] CreatSpiralMatrix(int[] ms)
{
    int[,] array = new int[ms[0], ms[1]];
    int dotSize = ms[0]*ms[1];
    int counter = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++);
        
    }
}


void ShowMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"| {array[i, j].ToString("000")} |");
        }
        Console.WriteLine();
    }
}
