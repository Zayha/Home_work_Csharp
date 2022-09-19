Console.Clear();
Console.Write("Please enter a three-digit number: ");
int number =  int.Parse(Console.ReadLine()!);

if (99 < number && number < 1000) {
    string numIndex = number.ToString();
    Console.WriteLine($"{numIndex[1]}");
} 
else {
    Console.WriteLine($"Number {number} not three-digit!");
}