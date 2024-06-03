// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3]
// => 2

void Main()
{
    int arraySize = ReadInt("Enter array's length");
    int[] array = CreateAndFillArray(arraySize, 19, 25);
    PrintArray(array);
    System.Console.WriteLine(CountItemsDivided7Ends1(array) +
                                    " items divided into 7 and ends in 1");
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
    // foreach (var item in array)
    //     System.Console.Write(item + " ");

    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int CountItemsDivided7Ends1(int[] array)
{
    int count = 0;
    foreach (int item in array)
        if (item % 7 == 0 && item % 10 == 1) count++;

    return count;
}




Main();