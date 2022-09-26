Console.Write("Please enter number: ");
string string_number =  Console.ReadLine();
int number = int.Parse(string_number);

if (number == 1) {
    Console.WriteLine("Sorry, we don't have any even number =)");
}
else {
    int i = 1;
    if (number > i) {       
        while (i <= number) {
            if ((i % 2) == 0) {
                Console.Write(i);
                if (i < number-1) {Console.Write(", ");}
            }
            i++;
        }
    }
    else {
        while (i >= number) {
            if ((i % 2) == 0) {
                Console.Write(i);
                if (i > number) {Console.Write(", ");}
            }
        i--;
        }
    }
}
