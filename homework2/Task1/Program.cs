System.Console.Write("Enter natural number: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number % 7) == 0 && (number % 23) == 0) System.Console.WriteLine("да");
else System.Console.WriteLine("нет");