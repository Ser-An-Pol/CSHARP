using System.Runtime.InteropServices;

System.Console.Write("Enter natural number N: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int count = 0;
int N = number;

while (N > 0)
{
    N /= 10;
    count++;
}

int mult = 1;
for (int i = 1; i < count; i++) mult *= 10;

for (; mult > 1; mult /= 10)
{
    System.Console.Write($"{number/mult}, ");
    number %= mult;
}
System.Console.WriteLine(number);
