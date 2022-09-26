
int[] CreateArray(int l = 8)
{
    int[] array = new int[l];
    var random = new Random();
    for (int i = 0; i < l; i++)
    {
        array[i] = random.Next();
    }
    return array;
}

void ShowArray(int[] array)
{   Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

Console.Clear();
ShowArray(CreateArray());