// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.

Main();

void Main()
{
    System.Console.WriteLine("Enter string...");
    string? str = Console.ReadLine();

    System.Console.WriteLine(CountVowels(str));
    System.Console.WriteLine(str);
}

bool isVowel(char c)
{
    return "aeiouy".Contains(c);
}

int CountVowels(string? inStr)
{
    int count = 0;

    string temp = inStr.ToLower();
    foreach (char letter in temp)
        if (isVowel(letter)) count++;
    
    return count;
}