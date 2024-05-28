// Задача №2
// • Назовём число «интересным» если его сумма
//   цифр чётная
// • Создать двумерный массив, состоящий из
//   целых чисел. Вывести на экран «интересные»
//   элементы массива

int[,] CreateMatrix(int rowCount, int colCount)
{
    Random rnd = new();

    int[,] table = new int[rowCount, colCount];

    for (int i = 0; i < table.GetLength(0); i++)
        for (int j = 0; j < table.GetLength(1); j++)
            table[i, j] = rnd.Next(100, 999);

    return table;
}

void ShowMatrix(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
            System.Console.Write($"{table[i, j]} ");
        System.Console.WriteLine();
    }
}

int SumDigit(int number)
{
    int sum = 0;
    number = Math.Abs(number);

    while (number > 0)
    {
        sum += (number % 10);
        number /= 10;
    }
    return sum;
}

bool isEven(int number)
{
    if (number % 2 == 0) return true;
    else return false;
}

bool isInteresting(int number)
{
    return isEven(SumDigit(number));
}

int[,] matrix = CreateMatrix(4, 5);
ShowMatrix(matrix);

foreach (int item in matrix)
    if (isInteresting(item)) System.Console.Write($"{item} ");