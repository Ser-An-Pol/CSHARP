// Задайте двумерный массив символов (тип char
// [,]). Создать строку из символов этого массива. 

using System.Text;

Main();

void Main()
{
    char[,] arrChar = {{'a','b','c'},{'d','e','f'}};

    System.Console.WriteLine(Convert2dArrayToString(arrChar));
}

string Convert2dArrayToString(char[,] chars)
{
    StringBuilder stringBuilder = new();

    foreach (var item in chars)
        stringBuilder.Append(item);

    return stringBuilder.ToString();
}
