void PrintSquares(int limit)
{
    int i = 0;
    while (i <= limit)
    {
        Console.Write($"{i * i} ");
        i++;
    }
    Console.WriteLine();
}

PrintSquares(5);
PrintSquares(10);
PrintSquares(15);