Console.Clear();
Console.Write("Please enter some number: ");
int number =  int.Parse(Console.ReadLine()!);
string numIndex = number.ToString();

if (numIndex.Length > 2) {
    Console.WriteLine($"The third digit in the number = {numIndex[2]}");
}
else {
    Console.WriteLine("The third digit is missing...");
}