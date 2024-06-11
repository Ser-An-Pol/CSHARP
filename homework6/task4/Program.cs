// Задайте строку, состоящую
// из слов, разделенных пробелами. Сформировать строку,
// в которой слова расположены в обратном порядке. В
// полученной строке слова должны быть также разделены
// пробелами.

Main();

void Main()
{
    System.Console.WriteLine("Enter string...");
    string? str = Console.ReadLine();

    System.Console.WriteLine(reverseWords(str!));
}

string[] getWords(string? str)
{
    string[] words = str!.Split(" ");

    return words;
}

string[] reverseArray(string[] words)
{
    string[] r_words = new string[words.Length];

    for (int i = words.Length - 1, j = 0; i >= 0; i--, j++)
        r_words[j] = words[i];

    return r_words;
}

string getStringFromArray(string[] words)
{
    return string.Join(" ", words);
}

string reverseWords(string? str)
{
    return getStringFromArray(reverseArray(getWords(str!)));
}
