// Домашнее задание

// Считать с консоли строку, состоящую из цифр и
// латинских букв. Сформировать массив, состоящий
// из цифр этой строки.

// Пример
// abc123def06g => [1, 2, 3, 0, 6]

// Рекомендации
// • Разделить логику алгоритма на функции
// • Память под массив выделять необходимого
// размера (не больше, чем количество элементов)

int CountOfDigits(string str)
{
    int count = 0;
    foreach (char item in str)
        if (char.IsAsciiDigit(item)) count++;
    return count;
}

int[] GetDigitArray(string str)
{
    int length = CountOfDigits(str);
    int[] arr = new int[length];
    int i = 0;

    foreach (char item in str)
        if (char.IsAsciiDigit(item)) arr[i++] = item - '0';
    return arr;
}

void PrintArray(int[] arr)
{
    System.Console.Write("[ ");
    int len = arr.Length-1;
    for (int i = 0; i < len; i++)
        System.Console.Write($"{arr[i]}, ");
    System.Console.WriteLine($"{arr[len]} ]");
}

System.Console.WriteLine("Enter string...");
string? str =  Console.ReadLine();

int[] arr = GetDigitArray(str);
PrintArray(arr);
