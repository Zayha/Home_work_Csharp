double Armean(int c = 0, int sum = 0)
{    
    Console.Write("Введите положительное число, для прекращения ввода введите \"-1\": ");
    int num = int.Parse(Console.ReadLine()!);
    if(num != -1)
    {
        return Armean(++c, sum += num);
    }
    else 
    {
        double arm = Convert.ToDouble(sum) / c;
        return arm;
    }
}

Console.Write($"Среднее арифметическое {Armean()}");