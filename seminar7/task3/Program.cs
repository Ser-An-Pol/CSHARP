// Считать строку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки.
// Указание
// Использовать рекурсию. Не использовать цикл.

string Consonants = "BbCcDdFfGgHhJjKkLlMmNnPpQqRrSsTtVvWwXxZz";

Main();

void Main()
{
    System.Console.WriteLine("Enter string...");
    string? str = Console.ReadLine();
    printIfConsonant(str!, str!.Length-1);
}

void printIfConsonant(string? str, int ind)
{
    if (ind >= str!.Length)
    {
        System.Console.WriteLine("Error...");
        return;
    }

    if (ind < 0) return;
    printIfConsonant(str!, ind-1);

    if (Consonants.Contains(str![ind])) 
        System.Console.Write($"{str![ind]} ");
}