int MFu(int m = -1, int count = 0)
{
    if (m == -1)
    {
        Console.Write("Введите счисло считываний М: ");
        m = Math.Abs(int.Parse(Console.ReadLine()!));
    }
    if (m == 0)
    {
        return count;
    }
    Console.Write("Введите число: ");
    int x = int.Parse(Console.ReadLine()!);
    if (x > 0)
    {
        return MFu(--m, ++count);
    }
    else 
    {
        return MFu(--m, count);
    }
    
}
    
Console.Clear();
Console.WriteLine(MFu());