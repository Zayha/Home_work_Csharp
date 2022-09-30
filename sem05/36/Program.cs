int[] Getdata(string data)
{
    int[] array = new int[data.Length];
    array = data.Split(" ").Select(e => Convert.ToInt32(e)).ToArray();
    return array;
}

//Подсчет суммы значений элементов с нечетыми индексами
int ArrSum(string array)
{
    int[] datar = Getdata(array);
    int sum = 0;
    for (int i = 1; i < datar.Length; i = i + 2)
    {
        sum = sum + datar[i];
    }
    return sum;
}

Console.Clear();
Console.Write("Введите массив из чисел через пробел: ");
string somestring = Console.ReadLine()!;
Console.Write($" - > {ArrSum(somestring)}");
