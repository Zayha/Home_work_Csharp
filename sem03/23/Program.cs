Console.Clear();
Console.Write("Введите число: ");
int number = Math.Abs(int.Parse(Console.ReadLine()!));

int counter = 1;

Console.Write($"{number} -> ");
while (counter <= number )
{
    Console.Write(Math.Pow(counter, 3));
    if (counter < number)
    {
        Console.Write($", ");
    }
    counter++;
}