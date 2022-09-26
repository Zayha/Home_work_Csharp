Console.Clear();
Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine()!);


int Power(int a, int b)
{   
    int ch = 1;
    for (int i = 1; i <= b; i++)
    {
        ch = ch * a;
    }
    return ch;
}

Console.Write($"Число {a}, возведенное в степень {b} = {Power(a, b)}");