// 1. Функцию, которая вычисляет число a в степени n
int PowerNumber(int a, int n)
{
    int result = 1;
    while(n > 0)
    {
        result = result * a;
        n--;
    }
    return result;
}
// 2. Функцию, которая вычисляет факториал числа n
int FactorialNumber(int n)
{
    int result = 1;
    for(int i = 1; i <= n; i++)
        result = result * i;
    return result;
}
// 3. Функцию, которая вычисляет сумму цифр произвольного целого числа n
int SummDigits(int n)
{
    int temp = 0;
    int sum = 0;
    while(n > 0)
    {
        temp = n % 10;
        sum = sum + temp;
        n = n/10;
    }
    return sum;
}
// 4. Функцию, которая проверяет является ли заданное число n полиндромом



//1.
//Console.WriteLine("Введите число (a) - ");
//int a = int.Parse(Console.ReadLine() ?? "0");
//Console.WriteLine("Введите степень (n), в которую возвести число - ");
//int n = int.Parse(Console.ReadLine() ?? "0");
//Console.WriteLine($"Число *a* в степени *n* = {PowerNumber(a, n)}");
//2.
//Console.WriteLine("Введите число - ");
//int n = int.Parse(Console.ReadLine() ?? "0");
//Console.WriteLine($"Факториал числа = {FactorialNumber(n)}");
//3.
//Console.WriteLine("Введите число - ");
//int n = int.Parse(Console.ReadLine() ?? "0");
//Console.WriteLine($"Сумма цифр числа = {SummDigits(n)}");