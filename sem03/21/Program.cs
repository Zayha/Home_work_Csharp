Console.Clear();
Console.Write("Введите Координату первой точки через пробел пример - \"1 2 3\" : ");
int[] d1 = Console.ReadLine()!.Split(' ').Select(e => Convert.ToInt32(e)).ToArray();
Console.Write("Введите Координату второй точки через пробел пример - \"1 2 3\" : ");
int[] d2 = Console.ReadLine()!.Split(' ').Select(e => Convert.ToInt32(e)).ToArray();

double dv = Math.Sqrt(Math.Pow(d1[0] - d2[0], 2) + Math.Pow(d1[1] - d2[1], 2) + Math.Pow(d1[2] - d2[2], 2));
Console.WriteLine($"Рассточние между точкой с координатами {d1[0]} {d1[1]} {d1[2]} и точкой {d2[0]} {d2[1]} {d2[2]} составляет {dv.ToString("#.00")}");