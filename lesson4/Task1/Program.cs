// Задача №1
// • Создать двумерный массив с размерами
//    3 x 5, состоящий из целых чисел
// • Вывести его элементы на экран



int[,] CreateMatrix(int rowCount, int colCount)
{
    int[,] table = new int[rowCount, colCount];
    Random rnd = new Random();

    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = rnd.Next(1, 11);
        }
    }
    return table;
}

void ShowMatrix(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            System.Console.Write($"{table[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(4, 5);
ShowMatrix(matrix);