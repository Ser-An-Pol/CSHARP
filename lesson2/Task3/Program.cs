Console.WriteLine("Enter array's length...");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[N];
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next()/10000000;
}

for (int i = 0; i < arr.Length; i++)
{
    if ((arr[i] % 2) == 0) Console.Write($"{arr[i]} ");
}