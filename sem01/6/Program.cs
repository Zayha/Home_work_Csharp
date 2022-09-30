Console.Write("Please enter number: ");
string string_number =  Console.ReadLine()!;
int number = int.Parse(string_number);

if ((number % 2) == 0) {
    Console.WriteLine("Yes, This number is even!");
}
else {
    Console.WriteLine("No, This number is not even!");
}