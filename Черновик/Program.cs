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
//6. Проверка наличия элемента
bool PresenceElementsArray(int[]array, int find)
{
    for(int i = 0; i < array.Length; i++)
        if(array[i] == find)
            return true;
    return false;
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
Console.WriteLine("Ваш массив - ");
GenerateArrayElements(array, 1, 10);
PrintArray(array);

Console.WriteLine("Введите число - ");
int find = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine(PresenceElementsArray(array, find));

Console.WriteLine($"Отсортирован ли наш массив - {SortedArray(array)}");

Console.WriteLine("Введите число - ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Является ли число простым - {PrimeNumber(n)}");


Console.WriteLine($"Является ли число четным - {Check(n)}");