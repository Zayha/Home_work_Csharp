Console.Clear();
Console.WriteLine("*******************************");
Console.Write("Прямая 1: y = k1 * x + b1\n");
Console.Write("Прямая 2: y = k2 * x + b2\n");
Console.WriteLine("*******************************");

Console.Write("Введите значения k1 b1 через пробел, пример - \"5 2\" : ");
double[] param1 = Console.ReadLine()!.Split(' ').Select(e => Convert.ToDouble(e)).ToArray();
Console.Write("Введите значения k2 b2 через пробел, пример - \"9 4\" : ");
double[] param2 = Console.ReadLine()!.Split(' ').Select(e => Convert.ToDouble(e)).ToArray();
Console.WriteLine("*******************************");

if (param1[0] != param2[0])
{
    double x = (param2[1] - param1[1]) / (param1[0] - param2[0]);
    double y = param1[0] * x + param1[1];   
    Console.WriteLine($"Точка пересечения ({x} , {y})");
}
else
{
    Console.WriteLine($"Некорректные параметры k1 и k2, точка пересечения не найдена!");
}
Console.WriteLine("*******************************");
