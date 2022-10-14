Console.Clear();
Console.Write("Укажите числа M и N через пробел: ");
int[] mn = Console.ReadLine()!.Split(' ').Select(e => Convert.ToInt32(e)).ToArray();

int m = SwitchNumbers(mn)[0];
int n = SwitchNumbers(mn)[1];
ShowNumbers(m, n);

int[] SwitchNumbers(int[] mn)
{
    if (mn[0] > mn[1])
    {
        int temp = mn[0];
        mn[0] = mn[1];
        mn[1] = temp;
    }
    return mn;
}

bool CheckNumbers(int m, int n)
{
    if ((m < 0) || (n < 0))
    {
        return false;
    }
    else
    {
        return true;
    }
}

void ShowNumbers(int m, int n)
{
    if (CheckNumbers(m, n))
    {
        if (n >= m)
        {
            Console.Write($"{m}");
            if (m + 1 <= n) Console.Write(", ");
            ShowNumbers(++m, n);
        }
    }
}