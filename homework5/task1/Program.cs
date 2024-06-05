// Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.

Main();

void Main()
{
    int rowSize = ReadInt("Enter count of row...", false);
    int colSize = ReadInt("Enter count of column...", false);

    int[,] array = CreateAndFill2dArray(rowSize, colSize, 0, 99);
    Print2dArray(array);
    
    int[] coord = GetCoordinate();

    System.Console.WriteLine(ElementAt(array, coord));
}

int ReadInt(string msg, bool isZero) // if isZero = true, value "0" is suitable
{
    System.Console.WriteLine(msg);
    int num;
    while (!int.TryParse(Console.ReadLine(), out num) || 
                                !(num > 0 && !isZero) && !(num >= 0 && isZero))
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

int[] GetCoordinate()
{
    int[] coord = new int[2];

    coord[0] = ReadInt("Enter the row-position...", true);
    coord[1] = ReadInt("Enter the column-position...", true);

    return coord;
}

string ElementAt(int[,] array, int[] coord)
{
    if (coord[0] >= array.GetLength(0) || coord[1] >= array.GetLength(1))
        return string.Format("Coordinates [{0}, {1}] are out of array's bound", 
                                                            coord[0], coord[1]);
    else return string.Format("At coordintaes  [{0}, {1}] is number \"{2}\"",
                                    coord[0], coord[1], array[coord[0], coord[1]]);
}