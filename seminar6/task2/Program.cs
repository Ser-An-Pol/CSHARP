// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ] 

Main();

void Main()
{
    System.Console.WriteLine("Enter string...");
    string? str = Console.ReadLine();

    //1-st decision

    // char[] chars = str!.ToCharArray();
    // System.Console.WriteLine(string.Join(", ", chars));

    //2-nd decision

    char[] chars = StringToCharArray(str);
    PrintArray(chars);

}

void PrintArray(char[] chars)
{
    System.Console.WriteLine("[" + string.Join(", ", chars)+"]");
}

char[] StringToCharArray(string inputString)
{
    char[] chars = new char[inputString!.Length];

    for (int i = 0; i < chars.Length; i++)
        chars[i] = inputString[i];
    
    return chars;
}