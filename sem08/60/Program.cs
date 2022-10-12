Console.Clear();
Console.Write("Укажите размерность 3d массив через пробел a b c: ");
int[] matrixSize = Console.ReadLine()!.Split(' ').Select(e => Convert.ToInt32(e)).ToArray();

Show3DMatrixIndex(Creat3DMatrix(matrixSize));

int[,,] Creat3DMatrix(int[] ms)
{   
    int[] numbers = ListNumberGenerator();
    int[,,] array = new int[ms[0], ms[1], ms[2]];
    for (int i = 0; i < ms[0]; i++)
    {
        for (int j = 0; j < ms[1]; j++)
        {
            for (int k = 0; k < ms[2]; k++)
            {   
                int t = new Random().Next(0, numbers.Length);
                array[i, j, k] = numbers[t];
                numbers = numbers.Where((source, index) =>index != t).ToArray();
            }
        }
    }
    return array;
}

int[] ListNumberGenerator(int start = 10, int stop = 100)
{
    List<int> list = new List<int>();
    for(int i = start; i < stop; i++)
    {
        list.Add(i);
    }
    return list.ToArray();
}

void Show3DMatrixIndex(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}
