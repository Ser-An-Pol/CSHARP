// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.

Main();

void Main()
{
    int number = inputInt("Enter positive integer number...");

    System.Console.WriteLine($"Sum of digits in {number} is {SumDigits(number)}");
}

int inputInt(string str)
{
    System.Console.WriteLine(str);
    int num;

    while (!int.TryParse(Console.ReadLine(), out num) || num < 0)
        System.Console.WriteLine("Enter correct positive integer number...");

    return num;
}

int SumDigits(int num)
{
    if (num == 0) return 0;

    return num % 10 + SumDigits(num / 10);
}