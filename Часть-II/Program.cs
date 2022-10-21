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
void Palindrome( int n)
{
    int N = n;
    int length = 0;
    while(N > 0)
    {
        N/=10;
        length++;
    }
    int[] digits = new int[length];
    int i = length - 1;
    while(n > 0)
    {
        digits[i] = n % 10;
        n = n/10;
        i = i-1;
    }
    i = 0;
    int j = length - 1;
    int count = 0;
    while(i < j)
    {
        if(digits[i]!= digits[length - i - 1])
            count++;
        i++;
        j--;
    }
    if(count > 0)
        Console.WriteLine("Не палиндром");
    else
    {
        Console.WriteLine("Палиндром");
    }
}


// 5. Функцию, складывающую два целых числа

int SummNumbers(int a, int b)
{
    int sum = a + b;
    return sum;
}

// 6. Функцию, определяющую является ли число простым, 
//то есть возвращающую true, если число простое, иначе - false
bool PrimeNumber(int n)
{
    if(n > 1)
    {
        for(int x = 2; x < n; x++)
            if(n % x != 0)
                return true;
            else
                return false;
    }
    return true;
}
// 7. Функцию, определяющую является ли число чётным, 
//то есть возвращающую true, если число чётное, иначе - false

bool Check(int n)
{
    if(n % 2 == 0)
        return true;
    else
        return false;
    return true;
}

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

//4.
//Console.WriteLine("Введите число - ");
//int n = int.Parse(Console.ReadLine() ?? "0");
//Palindrome(n);


//5.
//Console.WriteLine("Введите первое число - ");
//int a = int.Parse(Console.ReadLine() ?? "0");
//Console.WriteLine("Введите второе число - ");
//int b = int.Parse(Console.ReadLine() ?? "0");
//Console.WriteLine($"Сумма двух чисел = {SummNumbers(a, b)}");


//6.
Console.WriteLine("Введите число - ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine(PrimeNumber(n));

//7.
//Console.WriteLine("Введите число - ");
//int n = int.Parse(Console.ReadLine() ?? "0");
//Console.WriteLine(Check(n));