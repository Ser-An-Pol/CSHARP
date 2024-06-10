// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива.
// Указание
// Конструктор строки вида string(char []) не использовать.
// Пример
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

Main();

void Main()
{
    char[] chars = {'a', 'b', 'c', 'd'};

    // 1-st decision

    // string str = new string(chars);

    //2-nd decision

    // string str = "";
    // foreach (var letter in chars)
    // {
    //     str += letter;
    // }

    //3-d decision
    
    // string str = string.Join("", chars);

    //4-th decision

    string str = string.Concat(chars);

    System.Console.WriteLine(str);
}