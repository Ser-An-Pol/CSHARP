System.Console.WriteLine("Enter two-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9 && number < 100)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    if (firstDigit > secondDigit) System.Console.WriteLine(firstDigit);
    else System.Console.WriteLine(secondDigit);
}
else
{
    System.Console.WriteLine("Incorrect number!!!");
}