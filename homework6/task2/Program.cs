// Задайте строку, содержащую латинские буквы
// в обоих регистрах. Сформируйте строку, в которой все
// заглавные буквы заменены на строчные. 


using System.Text;

Main();

void Main()
{
    System.Console.WriteLine("Enter string...");
    string? str = Console.ReadLine();

    System.Console.WriteLine(myStrToLower(str));
}

char myToLower(char c)
{
    // string UP = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    // if (UP.Contains(c)) c = (char)((int)c + 32);
    int c_ascii = (int)c;

    if (c_ascii > 64 && c_ascii < 91) c_ascii += 32;

    return (char)c_ascii;
}

string myStrToLower(string? str)
{
    StringBuilder sb = new();

    for (int i = 0; i < str!.Length; i++)
        sb.Append(myToLower(str[i]));

    return sb.ToString();
}