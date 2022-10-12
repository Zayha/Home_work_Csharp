Console.Write("Укажите размерность 2d массива через пробел a b: ");
int[] matrixSize = Console.ReadLine()!.Split(' ').Select(e => Convert.ToInt32(e)).ToArray();

ShowMatrix(FillingSnail(matrixSize));

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

int[,] FillingSnail(int[] ms)
{   
    int[,] array = new int[ms[0], ms[1]];
    int i = 1;
    int x = 0;
    int y = -1;
    int goRow = 0; // дельта смещения координаты по рядам
    int goColumn = 1; // дельта смещения координаты по строкам

    while (i <= ms[0] * ms[1])
    {
        //проверяем, можно ли шагнуть вперед и свободна ли ячейка
        if ((x + goRow >= 0) && (x + goRow < ms[0]) && (y + goColumn >= 0) && (y + goColumn < ms[1]) && (array[x + goRow, y + goColumn] == 0))
        {
            x += goRow;
            y += goColumn;
            array[x, y] = i;
            i++;
        }
        else
        {   
            if (goColumn == 1) // поворот вниз
            {
                goColumn = 0;
                goRow = 1;
            }
            else if (goRow == 1) // поворот влево
            {
                goRow = 0;
                goColumn = -1;
            }
            else if (goColumn == -1) // поворот вверх
            {
                goColumn = 0;
                goRow = -1;
            }
            else if (goRow == -1) // поворот вправо
            {
                goRow = 0;
                goColumn = 1;
            }

        }
    }
    return array;
}