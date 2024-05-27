System.Console.Write("Enter coordinate X: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter coordinate Y: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x == 0 || y == 0)
    System.Console.WriteLine("Incorrect numbers!");
else
{
    if (x > 0 && y > 0)
        System.Console.WriteLine("1");
    else if (x < 0 && y > 0)
        System.Console.WriteLine("2");
    else if (x < 0 && y < 0)
        System.Console.WriteLine("3");
    else if (x > 0 && y < 0)
        System.Console.WriteLine("4");
}