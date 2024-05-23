void ZeroEvenElements(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) arr[i] = 0;
    }
}

void PrintArray(int[] arr)
{
    foreach (var item in arr)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

void FillArray(int[] arr)
{
    Random rnd = new();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1, 1000);
    }
}

Console.WriteLine("Enter length of array...");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];

FillArray(array);
PrintArray(array);
ZeroEvenElements(array);
PrintArray(array);