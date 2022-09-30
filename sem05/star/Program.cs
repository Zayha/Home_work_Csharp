Console.Clear();
Console.Write("Введите массив из чисел через пробел: ");
string somestring = Console.ReadLine()!;
// string somestring = "123 321 444 r4444t";
string[] arr = somestring.Split(" ");

int index_ch = 0;
int index  = 0;
int temp_counter = 0;
int counter = -1;
string elem = String.Empty;

for (int i = 0; i < arr.Length; i++)
{
    for (int j = 0; j < arr[i].Length - 1; j++)
    {   
        if (arr[i].Length <= 1) continue;
        if (arr[i][j] == arr[i][j + 1])
        {   
            temp_counter++;
        }
        else
        {
            temp_counter = 0;
        }
        
        if (temp_counter > 0) 
        {
            if (temp_counter > counter)
            {   
                elem = Char.ToString(arr[i][j]);
                counter = temp_counter;
                index = i;
                index_ch = j +1 - counter;
                
            }
        }            
        
    }
}

Console.WriteLine($"Элемент массива в котором имеется самая длинная последоватиельность повторяющихся элементов {arr[index]}, она состоит из {arr[index].Length} элементов,");
Console.WriteLine($"последовательность повторяющихся элементов состоит из {counter + 1} повтояющихся подряд элементов \"{elem}\",");
Console.WriteLine($"Индекс начала последовательности повторяющихся элементов {index_ch}");