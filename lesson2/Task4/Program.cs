Console.WriteLine("Enter length of array...");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[N];
Random rnd = new();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next() / 1000000;
}

int max = arr[0];

for (int i = 0; i < arr.Length; i++)
{
    if (max < arr[i]) max = arr[i];
    Console.Write($"{arr[i]} ");
}

Console.WriteLine();
Console.Write($"max = {max}. Length of array is {arr.Length}.\n");

int max1 = arr[0];

foreach (var ar in arr)
{
    if (max1 < ar) max1 = ar;
    Console.Write($"{ar} ");
}

Console.WriteLine();
Console.Write($"max = {max1}. Length of array is {arr.Length}.\n");