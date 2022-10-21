// I. Реализовать следующие функции для работы с массивами:
void GenerateArrayElements(int[]array, int min, int max)
{
    Random random = new Random();
    for(int i = 0; i < array.Length; i++)
        array[i] = random.Next(min, max);
}
void PrintArray(int[]array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
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
        else
            return false;
    return true;
}


// Печать массива на экран

// Среднее арифметическое элеметов массива
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
// Подсчёт количества отрицательных элементов массива
int CountNegativeElementsArray(int[]array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] < 0)
            count++;
    return count;
}
// Подсчёт количества вхождений элемента в массив
int CountFindElementsArray(int[]array, int find)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] == find)
            count++;
    return count;
}
// Подсчёт количества чётных элементов в массив
int CountEvenNumber(int[]array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0) 
            count++;
    return count;
}
// Подсчёт количества положительных элементов в массиве
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
    for(int i = 0; i < array.Length; i++)
        if(array[i] < array[i+1])
            return true;
        else
        {
            return false;
        }
    return true;
}


Console.WriteLine("Введите длину массива - ");
int length = int.Parse(Console.ReadLine() ?? "0");
int[]array = new int[length];
Console.WriteLine("Ваш массив - ");
GenerateArrayElements(array, -10, 10);
PrintArray(array);

//Console.WriteLine($"Минимальное значение в массиве = {MinElementArray(array)}");
//Console.WriteLine($"Максимальное значение в массиве = {MaxElementArray(array)}");
//Console.WriteLine($"Сумма элементов массива = {SummElementsArray(array)}");
//Console.WriteLine($"Произведение элементов массива = {MultElementsArray(array)}");

//Console.WriteLine("Введите число, индекс которого нужно найти");
//int find = int.Parse(Console.ReadLine() ?? "0");
//int index = FindIndexElementArray(array, find);
//Console.WriteLine($"Индекс заданного числа = {index}");

//Console.WriteLine($"Среднее арифметическое элеметов массива = {AverageArray(array)}");
//Console.WriteLine($"Количество отрицательных элементов массива - {CountNegativeElementsArray(array)}");

//Console.WriteLine("Введите число - ");
//int find = int.Parse(Console.ReadLine() ?? "0");
//int c = CountFindElementsArray(array, find);
//Console.WriteLine($"Число встречается {c} раз");

//Console.WriteLine($"Количество четных элементов массива - {CountEvenNumber(array)}");
//Console.WriteLine($"Количество положительных элементов массива - {CountPositiveElementsArray(array)}");
//Console.WriteLine($"Количество нечетных элементов массива - {CountOddNumbers(array)}");

//Console.WriteLine(SortedArray(array));

Console.WriteLine(PresenceElementsArray(array, 5));