// Задайте двумерный массив. Напишите
// программу, которая поменяет местами первую и
// последнюю строку массива.

Main();

void Main()
{
    int rowSize = ReadInt("Enter count of row...");
    int colSize = ReadInt("Enter count of column...");

    int[,] array = CreateAndFill2dArray(rowSize, colSize, 0, 99);
    Print2dArray(array);
    ChangeRows(array);
    Print2dArray(array);
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

int[,] CreateAndFill2dArray(int rowSize, int colSize, int minRange, int maxRange)
{
    int[,] array = new int[rowSize, colSize];
    Random rnd = new Random();

    for (int i = 0; i < rowSize; i++)
        for (int j = 0; j < colSize; j++)
            array[i, j] = rnd.Next(minRange, maxRange + 1);

    return array;
}

void Print2dArray(int[,] array)
{
    System.Console.WriteLine("***********");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write($" {array[i, j],4} ");
        System.Console.WriteLine("]");
    }
    System.Console.WriteLine("***********");
}

void ChangeRows(int[,] array)
{
    int firstRow = 0;
    int lastRow = array.GetLength(0) - 1;
    int tmp;

    for (int i = 0; i < array.GetLength(1); i++)
    {
        tmp = array[firstRow, i];
        array[firstRow, i] = array[lastRow, i];
        array[lastRow, i] = tmp;
    }
}
