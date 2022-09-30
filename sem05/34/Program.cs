// Из стринга в массив с элементиами int
int[] Getdata(string data)
{
    int[] array = new int[data.Length];
    array = data.Split(" ").Select(e => Convert.ToInt32(e)).ToArray();
    return array;
}

// Проверка массива, что числа трехзначные и положительные.
bool CheckArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] < 100) || (array[i] > 999))
        {
            return false;
        }           
    }
    return true;
}

// Подсчет четных чисел
int ParityCheck(int[] array)
{   
    int pc = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            pc++;
        }
    }
    return pc;
}

Console.Clear();

Start:    
    Console.Write("Введите массив из 3-х значных чисел через пробел: ");
    string somestring = Console.ReadLine()!;
    if (CheckArray(Getdata(somestring)) == false)
    {
        Console.Write("Массив введен некорректно... Попробуйте снова!\n");
        goto Start;
    }
    Console.Write($" -> {ParityCheck(Getdata(somestring))}");