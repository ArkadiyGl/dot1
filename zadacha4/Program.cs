// Задача 4: Найти максимальное из трёх чисел.
// int a,b,c , if a>b = b max, if b>c = b max

int[] Numbers = { 55, 88, 77 };

for (int i = 0; i < 3; i++)
{
    int max = Numbers[0];
    
    if (Numbers[i] > max)
    {
        max = Numbers[i];
        System.Console.WriteLine();
        System.Console.WriteLine($"Максимальное число {max}");
    }
}
System.Console.WriteLine();
