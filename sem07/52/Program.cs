// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Write("Укажите размерность матрицы через пробел m n: ");
int[] matrixSize = Console.ReadLine()!.Split(' ').Select(e => Convert.ToInt32(e)).ToArray();

int[,] matrix = CreatMatrix(matrixSize); 
ShowMatrix(matrix);
ShowMeans(MatrixArithmeticMeanInColumns(matrix));


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

double[] MatrixArithmeticMeanInColumns(int[,] array)
{   
    
    double[] meanlist = new double[array.GetLength(1)];
    for(int j = 0; j < array.GetLength(1); j++)    
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        meanlist[j] = sum / array.GetLength(0);
    }
    return meanlist;
}

void ShowMeans(double[] meanlist)
{
    for(int k = 0; k < meanlist.Length; k++ )
    {
        Console.Write($"|{meanlist[k].ToString("0.0")}|");
    }
}