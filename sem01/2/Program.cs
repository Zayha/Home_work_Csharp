Console.Write("Please enter the first number: ");
string first_string_number =  Console.ReadLine();
Console.Write("Please enter the second number: ");
string second_string_number =  Console.ReadLine();

int number_first = int.Parse(first_string_number);
int number_second = int.Parse(second_string_number);

if (number_first == number_second) {
    Console.WriteLine("The numbers are equal");
}
else {
    if (number_first > number_second) {
        Console.WriteLine($"max = {number_first}, min = {number_second}");
    }
    else {
        Console.WriteLine($"max = {number_second}, min = {number_first}");
    }
}