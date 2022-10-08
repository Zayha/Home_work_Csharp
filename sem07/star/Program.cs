Console.Clear();
Selectfunction(GetNumber());

int GetNumber()
{
    Console.Write("Введите число N: ");
    int n = int.Parse(Console.ReadLine()!);
    return n;
}


// Рекурсия использована для выбора метода вычисления, в вычислении рекурсия не используется!
void Selectfunction(int n)
{
    Console.WriteLine("[1] - вычисление циклом, по определению Fn = Fn-1+ Fn-2");
    Console.WriteLine("[2] - вычисление по формуле Бине(золотое сечение)");
    Console.WriteLine("[3] - изменить число N");
    Console.WriteLine("[4] - передумал и ничего не хочу");
    Console.Write("\nВыберите действие: ");
    int select = int.Parse(Console.ReadLine()!);
    switch (select)
    {
        case 1:
            ShowFibonacciNumbersFor(n);
            break;
        case 2:
            ShowFibonacciNumbersBine(n);
            break;
        case 4:
            Console.WriteLine("bye bye see you soon =)");
            break;
        case 3:
            Selectfunction(GetNumber());
            break;
        default:
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine($"Что-то пошло не так, {select} - недопустимый номер метода вычисления! Попробуйте снова!\n");
            Selectfunction(n);
            break;
    }
}



void ShowFibonacciNumbersFor(int n, int fibnum1 = 0, int fibnum2 = 1)
{   if (n > 47) Console.WriteLine($"Корректные вычисления возможны до 47 числа!");
    Console.Write($"{n} -> {fibnum1}, {fibnum2}, ");
    for (int i = 3; i <= n; i++)
    {
        int f = fibnum1 + fibnum2;
        fibnum1 = fibnum2;
        fibnum2 = f;
        Console.Write($"{f}");
        if(i < n) Console.Write(", ");
    }
}


void ShowFibonacciNumbersBine(int n, double goldensection = 1.618034)
{
    Console.Write($"{n} -> ");
    for (int i = 0; i < n; i++)
    {
        double f = (Math.Pow(goldensection, i) - Math.Pow(1 - goldensection, i)) / Math.Sqrt(5);
        Console.Write($"{f.ToString("0.")}");
        if(i < n - 1) Console.Write(", ");
    }


}