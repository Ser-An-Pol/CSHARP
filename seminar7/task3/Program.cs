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
    printIfConsonant(str!);
}

// 1-sr variant of decision

// void printIfConsonant(string? str, int ind = 0)
// {
//     if (ind == str!.Length) return;

//     if (Consonants.Contains(str![ind])) 
//         System.Console.Write($"{str![ind]} ");

//     printIfConsonant(str!, ind+1);
// }

// 2-nd variant of decision

void printIfConsonant(string? str)
{
    if (str!.Length == 0) return;

    if (Consonants.Contains(str![0])) 
        System.Console.Write($"{str![0]} ");

    printIfConsonant(str![1..]);
}