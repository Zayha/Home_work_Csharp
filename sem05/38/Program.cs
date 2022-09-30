// Получаем минимальное и максимальное значения
double[] GetMN(double[] array)
{   
    double minar = array[0];
    double maxar = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minar) minar = array[i];
        if (array[i] > maxar) maxar = array[i];
    }
    double[] mn = {minar, maxar};
    return mn;
}

// Строка в массив double
double[] Getdata(string data)
{
    double[] array = data.Split(" ").Select(e => Convert.ToDouble(e)).ToArray();
    return array;
}

Console.Clear();
Console.Write("Введите массив из чисел через пробел: ");
string somestring = Console.ReadLine()!;
somestring = somestring.Replace(".", ",");
Console.Write($" -> {GetMN(Getdata(somestring))[1] - GetMN(Getdata(somestring))[0]}");
