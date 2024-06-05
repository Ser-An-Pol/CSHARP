// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива.

Main();

void Main()
{
    int rowSize = ReadInt("Enter count of row...");
    int colSize = ReadInt("Enter count of column...");

    int[,] array = CreateAndFill2dArray(rowSize, colSize, 0, 99);
    Print2dArray(array);
    Print1dArray(TransformArray2dTo1d(array));

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

double[] TransformArray2dTo1d(int[,] array)
{
    double[] res = new double[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        res[i] = 0.0;
        for (int j = 0; j < array.GetLength(1); j++)
            res[i] += array[i, j];
        res[i] /= array.GetLength(1);
    }
    return res;
}

void Print1dArray(double[] array)
{
    System.Console.WriteLine("***********");
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
        System.Console.Write($" {array[i]:0.00} ");

    System.Console.WriteLine("]\n***********");
}