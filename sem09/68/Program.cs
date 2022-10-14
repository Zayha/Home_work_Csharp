// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.Write("Укажите параметры m и n для ф-ции Аккермана через пробел: ");
int[] argument = Console.ReadLine()!.Split(' ').Select(e => Convert.ToInt32(e)).ToArray();

if(argument[0] < 0 || argument[1] < 0)
{
    Console.WriteLine("Параметры m и n должны быть неотрицательными!");
}
else
{
    Console.WriteLine($"\nРезультат вычисления A({argument[0]}, {argument[1]}) = {GetFunctionAckermann(argument[0], argument[1])}");
}



int GetFunctionAckermann(int m, int n)
{
    if(m == 0) return n + 1;
    if(m > 0 && n == 0) return GetFunctionAckermann(m-1, 1);
    if(m > 0 && n > 0) return GetFunctionAckermann(m-1, GetFunctionAckermann(m, n-1));
    return GetFunctionAckermann(m,n);
}

