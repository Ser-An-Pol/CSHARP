// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с
// наименьшей суммой элементов.

Main();

void Main()
{
    int rowSize = ReadInt("Enter count of row...");
    int colSize = ReadInt("Enter count of column...");

    int[,] array = CreateAndFill2dArray(rowSize, colSize, 0, 99);
    Print2dArray(array);

    System.Console.WriteLine("Sum of elements is minimum in row with index \"{0}\"", 
                                                FindRowWithMinSum(array));

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

int FindRowWithMinSum(int[,] array)
{
    int indMin = 0;
    int min = GetRowSum(array, 0);

    for (int i = 1; i < array.GetLength(0); i++)
    {
        int tmp = GetRowSum(array, i);
        if (tmp < min)
        {
            min = tmp;
            indMin = i;
        }
    }

    return indMin;
}

int GetRowSum(int[,] array, int row)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
        sum += array[row, i];

    return sum;
}