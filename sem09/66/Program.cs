Console.Clear();
Console.Write("Укажите числа M и N через пробел: ");
int[] mn = Console.ReadLine()!.Split(' ').Select(e => Convert.ToInt32(e)).ToArray();

mn = SwitchNumbers(mn);
int m = mn[0];
int n = mn[1];

Console.WriteLine($"Сумма чисел в ряду от {m} до {n} = {ShowNumbersSum(m,n)}");

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

int ShowNumbersSum(int m, int n, int sum = 0, int flag = 0)
{   
    if(flag == 0)
    {
        if (CheckNumbers(m, n))
        {
            flag = 1;
        }
        else
        {
            Console.WriteLine("Введены некорректные исходные параметры!");
        }

    }
    if ((n >= m) && flag == 1)
    {
        sum = sum + m;
        return ShowNumbersSum(++m, n, sum, 1);
    }
    return sum;
}

