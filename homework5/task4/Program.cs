// Задайте двумерный массив
// из целых чисел. Напишите программу, которая удалит
// строку и столбец, на пересечении которых расположен
// наименьший элемент массива. Под удалением
// понимается создание нового двумерного массива без
// строки и столбца

Main();

void Main()
{
    int rowSize = ReadInt("Enter count of row...");
    int colSize = ReadInt("Enter count of column...");

    int[,] array = CreateAndFill2dArray(rowSize, colSize, 0, 99);
    Print2dArray(array);

    int[,] reduceArr;
    string msg;
    if (Reduce2dArray(array, out reduceArr, out msg))
    {
        System.Console.WriteLine(msg);
        Print2dArray(reduceArr);
    }
    else
        System.Console.WriteLine(msg);

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

int[] GetCoordOfMin(int[,] array)
{
    int[] coord = new int[2];
    coord[0] = coord[1] = 0;
    int min = array[0, 0];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] < min)
            {
                min = array[i, j];
                coord[0] = i;
                coord[1] = j;
            }
    return coord;
}

bool Reduce2dArray(int[,] inArr, out int[,] outArr, out string msg)
{
    if (inArr.GetLength(0) == 1)
    {
        msg = "We can't delete row, because there is only one row in this array";
        outArr = new int[0,0];
        return false;
    }
    else if (inArr.GetLength(1) == 1)
    {
        msg = "We can't delete column, because there is only one column in this array";
        outArr = new int[0,0];
        return false;
    }
    else
    {
        int[] coord = GetCoordOfMin(inArr);
        outArr = new int[inArr.GetLength(0) - 1, inArr.GetLength(1) - 1];
        for (int i_out = 0, i_in = 0; i_out < outArr.GetLength(0); i_out++, i_in++)
        {
            if (i_in == coord[0]) i_in++;
            for (int j_out = 0, j_in = 0; j_out < outArr.GetLength(1); j_out++, j_in++)
            {
                if (j_in == coord[1]) j_in++;
                outArr[i_out, j_out] = inArr[i_in, j_in];
            }
        }
        msg = string.Format("We deleted row with index \"{0}\" and column with index \"{1}\":",
                                                coord[0], coord[1]);
        return true;
    }
}