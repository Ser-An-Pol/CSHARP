// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231

using System.Runtime.InteropServices;

int ReadInt(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int ReadIntLess8(string msg)
{
    int tmp;
    while (true)
    {
        tmp = ReadInt(msg);
        if (tmp < 1 || tmp > 8)
            System.Console.WriteLine("Incorrect number! It must be in range [1,9]");
        else
            break;
    }
    return tmp;
}

int[] CreateAndFillArray(int arraySize, int bound1, int bound2)
{
    int[] array = new int[arraySize];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
        array[i] = rand.Next(bound1, bound2);

    return array;
}

int[] CreateAndFillArrayByDigits(int arraySize)
{
    return CreateAndFillArray(arraySize, 0, 10);
}

int GenerateNumberFromArray (int[] array)
{
    return Convert.ToInt32(string.Concat(array));
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

void Main()
{
    int arraySize = ReadIntLess8("Enter array's size from range [1, 9]");
    int[] array = CreateAndFillArrayByDigits(arraySize);
    PrintArray(array);
    System.Console.WriteLine(GenerateNumberFromArray(array));
}

Main();