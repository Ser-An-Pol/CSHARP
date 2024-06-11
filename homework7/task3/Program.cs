// Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

using System.Numerics;

Main();

void Main()
{
    int size = inputInt("Enter array's size");
    int[] array = GenerateArray(size, 10, 99);

    printArray(array);

    printReverse(array);
}

int inputInt(string msg)
{
    System.Console.WriteLine(msg);
    int num;

    while (!int.TryParse(Console.ReadLine(), out num) || num <= 0)
        System.Console.WriteLine("Enter correct positive integer number...");

    return num;
}

int[] GenerateArray(int size, int minRange, int maxRange)
{
    Random rnd = new();
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = rnd.Next(minRange, maxRange + 1);
    return arr;
}

void printReverse(int[] array)
{
    printBack(array, array.Length - 1);
}

void printBack(int[] array, int ind)
{
    if (ind == 0)
    {
        System.Console.WriteLine(array[0]);
        return;
    }
    System.Console.Write($"{array[ind]} ");
    printBack(array, ind - 1);
}

void printArray(int[] array)
{
    System.Console.WriteLine(string.Join(" ", array));
}