// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

// Console.Write("Enter first number: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter second number: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// if (firstNumber == secondNumber * secondNumber)
// {
//     Console.WriteLine("a = " + firstNumber + ", b = " + secondNumber + " => Yes");
// }
// else
// {
//     Console.WriteLine($"a = {firstNumber}, b = {secondNumber} => No");
// }

//===========================================================================

// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

// Console.Write("Enter number: ");
// int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

// int i = -number;
// while (i <= number)
// {
//     Console.Write($"{i} ");
//     i++; // i = i + 1; i += 1;
// }
// for (int i = -number; i <= number; i++)
//     System.Console.Write($"{i} ");

//===========================================================================

// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

System.Console.Write("Enter three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

// 100<=number <1000

if (number > 99 && number < 1000)
{
    int firstDigit = number / 100;
    int thirdDigit = number % 10;
    int sum = firstDigit + thirdDigit;
    System.Console.WriteLine(sum);
}
else
{
    System.Console.WriteLine("This is not three-digit number!");
}