/*
Доп задача(72)
Заданы 2 массива: info и data. В массиве info хранятся двоичные представления нескольких чисел (без разделителя). В массиве data хранится информация о количестве бит, которые занимают числа из массива info. Напишите программу, которая составит массив десятичных представлений чисел массива data с учётом информации из массива info.
входные данные:

data = {0, 1, 1, 1, 1, 0, 0, 0, 1 } 
info = {2, 3, 3, 1 }
выходные данные: 1, 7, 0, 1
*/


int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };
int[] outdata = {1, 7, 0, 1};

Console.Clear();
string[] array = GetArray(data, info);
for (int i = 0; i < info.Length; i++)
{
    Console.Write(BinToDec(array[i]));
    if (i < info.Length - 1)
    {
        Console.Write(", ");
    }
}
TestOutData(data, info, outdata);



void TestOutData(int[] data, int[] info, int[] outdata)
{
    int check = 0;
    for (int i = 0; i < info.Length; i++)
    {
        if(BinToDec(GetArray(data, info)[i]) != outdata[i])
        {
            check +=1;
        }
    }
    if(check > 0) Console.WriteLine("\nПолученные данные НЕ соответствуют проверочным!");
    else Console.WriteLine("\nПолученные данные соответствуют проверочным");
}

int BinToDec(string bin)
{
    char[] charArray = bin.ToCharArray();
    Array.Reverse(charArray);
    int dec = 0;
    for (int i = 0; i < charArray.Length; i++)
    {
        dec = dec + Convert.ToInt32(Math.Pow(2, i)) * int.Parse(charArray[i].ToString());
    }
    return dec;
}

string[] GetArray(int[] data, int[] info)
{
    string[] array = new string[info.Length];
    int step = 0;
    for (int i = 0; i < info.Length; i++)
    {
        for (int j = step; j < info[i] + step; j++)
        {
            array[i] = array[i] + $"{data[j]}";
        }
        step += info[i];
    }
    return array;
}