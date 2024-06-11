// Задайте произвольную строку. Выясните,
// является ли она палиндромом.

using System.Text;

Main();

void Main()
{
    System.Console.WriteLine("Enter string...");
    string? str = Console.ReadLine();

    System.Console.WriteLine(isPolindrom(str!));
}

bool isPolindrom(string? str)
{
    if (str!.Equals(Reverse(str))) 
        return true;
    else
        return false;
}

string Reverse(string? str)
{
    StringBuilder sb = new();

    for (int i = str!.Length-1; i >= 0; i--)
        sb.Append(str[i]);
    
    return sb.ToString();
}