using System.Numerics;
Console.WriteLine("Enter length of array:");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[N];
int i = 0;

while (i < arr.Length)
{
    arr[i] = i + 1;
    //Console.Write(arr[i] + " ");
    Console.Write($"{arr[i]} ");
    i++;
}