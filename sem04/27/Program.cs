Console.Clear();
Console.Write("Введите число: ");
int number = Math.Abs(int.Parse(Console.ReadLine()!));

int SumDigits(int number)
{
    string line = number.ToString();
    int sum = 0;
    for (int i = 0; i < line.Length; i++)
    {
        sum = sum + int.Parse(line[i].ToString());
    }
    return sum;
}

Console.WriteLine($"{number} -> {SumDigits(number)}");