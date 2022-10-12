Console.Write("Укажите сторону квадратной матрицы: ");

bool result = int.TryParse(Console.ReadLine()!, out int number);
if (result == true)
{
    int[,] matrix = CreatMatrixSquare(number);
    ShowMatrix(matrix);
    Console.WriteLine($"Индекс минимального элемента: [{FindMinimumNumber(matrix)[0]}, {FindMinimumNumber(matrix)[1]}]");
    ShowMatrix(RefactoringMatrix(matrix, FindMinimumNumber(matrix)));

    Console.Write("Отзеркалить по нормали полученную матрицу? 1 - ДА: ");
    int.TryParse(Console.ReadLine()!, out int question);
    if (question == 1)
    {
        ShowMatrix(MatrixNormalMirroring(RefactoringMatrix(matrix, FindMinimumNumber(matrix))));
    }
}
else
    Console.WriteLine("Введено некорректное значение!");



int[,] CreatMatrixSquare(int ms)
{
    int[,] array = new int[ms, ms];
    Random rnd = new Random();
    for (int i = 0; i < ms; i++)
    {
        for (int j = 0; j < ms; j++)
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

int[] FindMinimumNumber(int[,] array)
{
    int min = array[0, 0];
    int[] minIndex = new int[] { 0, 0 };
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                minIndex[0] = i;
                minIndex[1] = j;
            }
        }
    }
    return minIndex;
}

int[,] RefactoringMatrix(int[,] array, int[] index)
{
    int i1, j1;
    int[,] newarray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

    for (int i = 0; i < array.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            if(i >= index[0])
            {
                i1 = i + 1;
            }
            else
            {
                i1 = i;
            }
            if(j >= index[1])
            {
                j1 = j +1;
            }
            else
            {
                j1 = j;
            }
            newarray[i, j] = array[i1, j1];
        }
    } 
    return newarray;
}

int[,] MatrixNormalMirroring(int[,] array)
{
    int k;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 1 + i; j < array.GetLength(1); j++)
        {
            {
                k = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = k;
            }
        }
    }
    return array;
}