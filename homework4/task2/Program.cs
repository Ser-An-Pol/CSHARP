// Задайте массив заполненный случайными
// трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в
// массиве.

Main();

void Main()
{
    int arraySize = ReadInt("Enter array's size...");
    int[] array = CreateAndFillArray(arraySize, 100, 999);

    PrintArray(array);

    System.Console.WriteLine($"There are {CountEvenNumbers(array)} even numbers in this array.");
}

int ReadInt(string msg)
{
    System.Console.WriteLine(msg);
    int num;
    while (!int.TryParse(Console.ReadLine(), out num) || !(num > 0))
    {
        System.Console.WriteLine("It's not suitable number. Enter number again...");
    }
    return num;
}

int[] CreateAndFillArray(int arraySize, int minRange, int maxRange)
{
    int[] array = new int[arraySize];
    Random rnd = new Random();

    for (int i = 0; i < arraySize; i++)
    {
        array[i] = rnd.Next(minRange, maxRange + 1);
    }

    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    foreach (int item in array) System.Console.Write($" {item} ");
    System.Console.WriteLine("]");
}

int CountEvenNumbers(int[] array)
{
    int count = 0;

    foreach (int item in array)
        if (int.IsEvenInteger(item)) count++;
        // if (item % 2 == 0) count++;
    return count;
}