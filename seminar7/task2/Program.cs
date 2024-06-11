// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.

Main();

void Main()
{
    int number = inputInt("Enter positive integer number...");

    printAllToN(number);
}

int inputInt(string msg)
{
    System.Console.WriteLine(msg);
    int num;

    while (!int.TryParse(Console.ReadLine(), out num) || num <= 1)
        System.Console.WriteLine("Enter correct positive integer number...");

    return num;
}

void printAllToN(int n)
{
    if (n == 0) return;

    printAllToN(n - 1);
    System.Console.Write($"{n} ");

}