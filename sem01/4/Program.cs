Console.Write("Please enter the first number: ");
string first_string_number =  Console.ReadLine();
Console.Write("Please enter the second number: ");
string second_string_number =  Console.ReadLine();
Console.Write("Please enter the third number: ");
string third_string_number =  Console.ReadLine();

int number_first = int.Parse(first_string_number);
int number_second = int.Parse(second_string_number);
int number_third = int.Parse(third_string_number);

int maximum = Math.Max(number_first, Math.Max(number_second, number_third));

Console.WriteLine($"Maximum = {maximum}");