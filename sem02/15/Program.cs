Console.Clear();
Console.Write("Please enter day number: ");
int dayNumber =  int.Parse(Console.ReadLine()!);

var days = new Dictionary<int, string>()
{
    {1, "Monday"},
    {2, "Tuesday"},
    {3, "Wednesday"},
    {4, "Thursday"},
    {5, "Friday"},
    {6, "Saturday"},
    {0, "Sunday"}
};

if (dayNumber != 0) {
    Console.Write($"The day {dayNumber} - {days[(dayNumber % 7)]}");
    if (((dayNumber % 7) == 0) || ((dayNumber % 7) == 6)) {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(" and YES this day is a holiday!");
        Console.ForegroundColor = ConsoleColor.White;
        }
    else Console.Write(" and NO this day isn't holiday! =(");
}
else {
    Console.WriteLine("And there was nothing yet on day zero!");
}