Console.Clear();
Console.Write("Сколько N строк треугольника Паскаля необходимо вывести? : ");
int n = int.Parse(Console.ReadLine()!);

ShowPascalTriangle(GetData(n));

int CalculationNewtonsBinomialCoefficient(int k, int m)
{
    return (GetFactorial(m) / (GetFactorial(k) * GetFactorial(m - k)));
}

int GetFactorial(int n)
{
    int factorial = 1;
    for (int i = 1; i <= n; i++)
    {
        factorial = factorial * i;
    }
    return factorial;
}

// Доработать вывод треугольника!
void ShowPascalTriangle(int[] array)
{   

    for(int i = 0; i < array.Length; i++)
    {   


        if (i == 0)
        {
            Console.Write(array[0] + "\n");
            continue;
        }
        Console.Write($"{array[i]} ");
        if(array[i + 1] == 1)
        {
            Console.Write($"{array[i+1]} ");
            Console.WriteLine();
            i++;
        }
    }
}

int[] GetData(int n)
{   
    int positions = 0;
    for(int i = 1; i <= n; i++)
    {
        positions +=i;
    }
    int[] array = new int[positions];
    int step = 0;
    int counter = 0;
    for(int i = 0; i < n; i++)
    {           
        for(int j = 0; j <= step; j++)
        { 
            array[counter] = CalculationNewtonsBinomialCoefficient(j, i);
            counter++;
        }
        step++;
    }
    return array;
}