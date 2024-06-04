// Напишите программу, которая бесконечно
// запрашивает целые числа с консоли. Программа
// завершается при вводе символа ‘q’ или при вводе
// числа, сумма цифр которого четная.

Main();

void Main()
{
    while (StringAnalysis(Read("Enter symbols..."))) ;
}

string Read(String msg)
{
    System.Console.WriteLine(msg);
    return Console.ReadLine();
}

bool StringAnalysis(string str)
{
    int num;
    if (int.TryParse(str, out num))
    {
        if (int.IsEvenInteger(GetDigitsSum(num))) return false; // или (GetDigitsSum(num) % 2 == 0)
        else return true;
    }
    else return !isQ(str);
}

int GetDigitsSum(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

bool isQ(string str)
{
    return str.Equals("q");
}