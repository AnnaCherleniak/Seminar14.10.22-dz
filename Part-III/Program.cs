// I. Функции для работы с массивами.

void GenerateArrayElements(int[]array, int min, int max)
{
    Random random = new Random();
    for(int i = 0; i < array.Length; i++)
        array[i] = random.Next(min, max);
}

//1. Поиск минимума
int MinElementArray(int[]array)
{
    int min = array[0];
    for(int i = 0; i < array.Length; i++)
        if (array[i] < min)
            min = array[i];
    return min;
}
//2. Поиск максимума
int MaxElementArray(int[]array)
{
    int max = array[0];
    for(int i = 0; i < array.Length; i++)
        if(array[i] > max)
            max = array[i];
    return max;
}
//3. Поиск суммы элементов массива
int SummElementsArray(int[]array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
        sum+=array[i];
    return sum;
}
//4. Поиск произведения элементов массива
int MultElementsArray(int[]array)
{
    int mult = 1;
    for(int i = 0; i < array.Length; i++)
        mult = mult * array[i];
    return mult;
}
//5. Поиск индекса заданного элемента в массиве, если такого элемента в массиве нет то возвращать -1
int FindIndexElementArray(int[]array, int find)
{
    int position = -1;
    for(int i = 0; i < array.Length; i++)
        if(array[i] == find)
        {
            position = i;
            break;
        }
    return position;
}
//6. Проверка наличия элемента в массиве. Возвращает true, если элемент в массиве есть, false – нет.
bool PresenceElementsArray(int[]array, int find)
{
    for(int i = 0; i < array.Length; i++)
        if(array[i] == find)
            return true;
    return false;
}

//7. Печать массива на экран
void PrintArray(int[]array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}
//8. Среднее арифметическое элеметов массива
int AverageArray(int[]array)
{
    int aver = 0;
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        sum+=array[i];
        aver = sum / array.Length;
    }
    return aver;
}
//9. Подсчёт количества отрицательных элементов массива
int CountNegativeElementsArray(int[]array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] < 0)
            count++;
    return count;
}
//10. Подсчёт количества вхождений элемента в массив
int CountFindElementsArray(int[]array, int find)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] == find)
            count++;
    return count;
}
//11. Подсчёт количества чётных элементов в массив
int CountEvenNumber(int[]array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0) 
            count++;
    return count;
}
//12. Подсчёт количества положительных элементов в массиве
int CountPositiveElementsArray(int[]array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] > 0)
            count++;
    return count;
}
// 13. Подсчёт количества нечётных элементов в массиве
int CountOddNumbers(int[]array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 != 0)
            count++;
    return count;
}
// 14. Проверка является ли массив отсортированным по возрастанию. 
// Если массив отсортирован, то возвращать true, иначе - false.
bool SortedArray(int[]array)
{
    for(int i = 0; i < array.Length - 1; i++)
        if(array[i] > array[i+1])
            return false;
    return true;
}

//II. Реализовать след функции:
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
        Console.WriteLine("Число Не является палиндромом");
    else
    {
        Console.WriteLine("Число является Палиндромом");
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
        for(int x = 2; x < n; x++)
            if(n % x == 0)
                return false;
    return true;
}

// 7. Функцию, определяющую является ли число чётным, 
//то есть возвращающую true, если число чётное, иначе - false
bool Check(int n)
{
    if(n % 2 != 0)
        return false;
    return true;
}


Console.WriteLine("Введите длину массива - ");
int length = int.Parse(Console.ReadLine() ?? "0");
int[]array = new int[length];

GenerateArrayElements(array, 1, 10);
Console.WriteLine("Ваш массив - ");
PrintArray(array);


Console.WriteLine($"Минимальное значение в массиве = {MinElementArray(array)}");
Console.WriteLine($"Максимальное значение в массиве = {MaxElementArray(array)}");
Console.WriteLine($"Сумма элементов массива = {SummElementsArray(array)}");
Console.WriteLine($"Произведение элементов массива = {MultElementsArray(array)}");

Console.WriteLine("Введите число, индекс которого нужно найти");
int find = int.Parse(Console.ReadLine() ?? "0");
int index = FindIndexElementArray(array, find);
Console.WriteLine($"Индекс заданного числа = {index}");

Console.WriteLine("Введите число, наличие которого нужно проверить - ");
find = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Наличие данного элемента в массиве - {PresenceElementsArray(array, find)}");

Console.WriteLine("Ваш массив - ");
PrintArray(array);

Console.WriteLine($"Среднее арифметическое элеметов массива = {AverageArray(array)}");
Console.WriteLine($"Количество отрицательных элементов массива - {CountNegativeElementsArray(array)}");

Console.WriteLine("Введите число, которое найти в массиве - ");
find = int.Parse(Console.ReadLine() ?? "0");
int c = CountFindElementsArray(array, find);
Console.WriteLine($"Число встречается {c} раз");

Console.WriteLine($"Количество четных элементов массива - {CountEvenNumber(array)}");
Console.WriteLine($"Количество положительных элементов массива - {CountPositiveElementsArray(array)}");
Console.WriteLine($"Количество нечетных элементов массива - {CountOddNumbers(array)}");

Console.WriteLine($"Отсортирован ли наш массив - {SortedArray(array)}");

Console.WriteLine("Вторая часть задания");

Console.WriteLine("Введите число (a) - ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите степень (n), в которую возвести число - ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Число *a* в степени *n* = {PowerNumber(a, n)}");

Console.WriteLine("Введите число - ");
n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Факториал числа = {FactorialNumber(n)}");

Console.WriteLine($"Сумма цифр числа = {SummDigits(n)}");

Console.WriteLine("Введите число, которое проверить на палиндром - ");
n = int.Parse(Console.ReadLine() ?? "0");
Palindrome(n);

Console.WriteLine("Введите первое число - ");
a = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите второе число - ");
int b = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Сумма двух чисел = {SummNumbers(a, b)}");

Console.WriteLine("Введите число - ");
n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Является ли число простым - {PrimeNumber(n)}");

Console.WriteLine($"Является ли число четным - {Check(n)}");