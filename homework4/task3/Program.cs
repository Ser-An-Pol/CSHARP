// Напишите программу, которая перевернёт
// одномерный массив (первый элемент станет
// последним, второй – предпоследним и т.д.)

Main();

void Main()
{
    int arraySize = ReadInt("Enter array's size...");
    int[] array = CreateAndFillArray(arraySize, 100, 999);

    PrintArray(array);
    ReverseArray(array);
    PrintArray(array);


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

void ReverseArray(int[] array)
{
    int mid = array.Length / 2;
    int tmp;

    for (int i = 0, j = array.Length - 1; i < mid; i++, j--)
    {
        tmp = array[i];
        array[i] = array[j];
        array[j] = tmp;
    }
}