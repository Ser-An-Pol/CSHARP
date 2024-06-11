// Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.

Main();

void Main()
{
    int M = inputInt("Enter first integer number...");
    int N = inputInt("Enter second integer number...");

    printAllBetweenNumbers(M, N);
}

int inputInt(string msg)
{
    System.Console.WriteLine(msg);
    int num;

    while (!int.TryParse(Console.ReadLine(), out num))
        System.Console.WriteLine("Enter correct integer number...");

    return num;
}

void printAllBetweenNumbers(int begin, int end)
{
    if (begin > end)
    {
        int tmp = begin;
        begin = end;
        end = tmp;
    }

    if (begin == end)
    {
        System.Console.WriteLine(begin);
        return;
    }

    System.Console.Write($"{begin}, ");
    printAllBetweenNumbers(begin+1, end);
}

