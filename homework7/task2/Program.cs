//  Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 

Main();

void Main()
{
    int n = inputInt("Enter first non-negative integer number...");
    int m = inputInt("Enter second non-negative integer number...");

    System.Console.WriteLine($"Ackermann({n}, {m}) = {Ackermann(n, m)}");
}

int inputInt(string msg)
{
    System.Console.WriteLine(msg);
    int num;

    while (!int.TryParse(Console.ReadLine(), out num) || num < 0)
        System.Console.WriteLine("Enter correct non-negative integer number...");

    return num;
}

long Ackermann(long n, long m)
{
    if (n == 0) return m + 1;
    else if (m == 0) return Ackermann(n - 1, 1);
    else return Ackermann(n - 1, Ackermann(n, m - 1));
}