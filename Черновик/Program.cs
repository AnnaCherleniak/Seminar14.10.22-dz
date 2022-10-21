//Console.WriteLine("Введите число - ");
//int n = int.Parse(Console.ReadLine() ?? "0");
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

Console.WriteLine("Введите число - ");
int n = int.Parse(Console.ReadLine() ?? "0");
Palindrome(n);
