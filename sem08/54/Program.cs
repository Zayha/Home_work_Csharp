Console.Write("Укажите размерность матрицы через пробел m n: ");
int[] matrixSize = Console.ReadLine()!.Split(' ').Select(e => Convert.ToInt32(e)).ToArray();

int[,] matrix = CreatMatrix(matrixSize); 
ShowMatrix(matrix);
SortMatrix(matrix);
Console.WriteLine();
ShowMatrix(matrix);



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
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"| {array[i, j]} |");
        }
        Console.WriteLine();
    }
}

int[,] SortMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {   
        int min = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - j - 1; k++)
            {
                if(array[i, k + 1] > array[i, k])
                {
                    min = array[i, k + 1];
                    array[i, k + 1] = array[i,k];
                    array[i, k] = min;
                }
            }            
        }
    }
    return array;
}