// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом
// массиве.
// Примеры
// [1 3 4 19 3] => 2
// [4 3 4 1 9 5 21 13] => 3
using System.Data;

Main();

void Main()
{
    int arraySize = ReadInt("Enter array's size");
    int[] array = CreateAndFillArray(arraySize, 1, 100);
    PrintArray(array);
    System.Console.WriteLine(CountPrime(array) + " - count of prime number in array");
}

int CountPrime(int[] array)
{
    int count = 0;

    foreach (int item in array)
        if (isPrime(item)) count++;
    
    return count;
}

bool isPrime(int num)
{
    if (num < 2) return false;
    if (num == 2) return true;

    for (int i = 2; i <= Math.Sqrt(num); i++)
        if (num % i == 0) return false;

    return true;
}

int ReadInt(String msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateAndFillArray(int arraySize, int bound1, int bound2)
{
    int[] array = new int[arraySize];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
        array[i] = rand.Next(bound1, bound2);

    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}