// Console.Write("Сколько N строк треугольника Паскаля необходимо вывести? : ");
// int n = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{CalculationNewtonsBinomialCoefficient(1,2)}");

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

// void ShowPascalTriangle(int n)
// {
//     int positions = 0;
//     for(int i = 1; i <= n; i++)
//     {
//         positions +=i;
//     }

// }

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
    for(int i = 0; i < positions; i++)
    {           
        for(int j = 0; j <= step; j++)
        {   
            array[counter] = CalculationNewtonsBinomialCoefficient(i, j);
            counter++;
        }
        step++;
    }
}