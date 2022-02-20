// Задача 34: Написать программу для замены элементов массива на противоположные.
// задаем любое количество чисел
// int n = new Random().Next(-100, 101);

Console.Clear();

int n = 50;

int[] CreateArray(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
    return array;
}

int[] GetOppositArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * (-1);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
    System.Console.WriteLine();
}

int[] array = CreateArray(n);
PrintArray(array);
PrintArray(GetOppositArray(array));