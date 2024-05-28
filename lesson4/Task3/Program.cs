// Задача №3

// Считать с консоли строку, состоящую из
// цифр и латинских букв.

// Сформировать новую строку, состоящую из
// букв исходной строки

// bool isLetter(char ch)
// {
//     if (ch >= 'A' && ch <= 'z') 
//         return true;
//     else
//         return false; 
// }

string? str = System.Console.ReadLine();

string res = "";

foreach (char ch in str)
    if (char.IsAsciiLetter(ch)) res += ch;

System.Console.WriteLine(res);