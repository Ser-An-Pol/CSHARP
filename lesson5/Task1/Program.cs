// Задача №1
// • Вычислить факториал от натурального
//   числа N

long factorial(long num) {
    if (num == 1 || num == 0) return 1;
    //else return num*factorial(num-1);
    else
    {
        long f = num*factorial(num-1);
        System.Console.WriteLine($"Возврат: n = {num}, factorial = {f}");
        return f;
    }
}

System.Console.WriteLine(factorial(20));