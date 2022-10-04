//В контексте задачи, отрицательные числа не рассматривались
Console.Clear();
Console.Write("Введите число в десятичной системе исчисления: ");
int m = int.Parse(Console.ReadLine()!);
Dectobin(m);

void Dectobin(int dec, int f = 1, string s = "")
{   
    if (((dec == 1) || (dec == 0)) && (f == 1))
    {
        if(dec == 0) Console.Write($"Число {m} в двоичной системе исчисления -> 0");
        if(dec == 1) Console.Write($"Число {m} в двоичной системе исчисления -> 1");
    }
    else 
    {
        f = 0;
        int d = dec / 2;
        int o = dec % 2;
        s = s + o.ToString();
        // Console.Write(s);
        if (d > 1)
        {
            Dectobin(d, f, s);
        }
        else 
        {
            s = s + "1";
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            Console.Write($"Число {m} в двоичной системе исчисления -> ");
            Console.Write(arr);
        }
    }
}
