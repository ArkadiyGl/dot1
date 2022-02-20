// 26. Возведите число А в натуральную степень B используя цикл

Console.Clear();

System.Console.WriteLine();

int number = 5;
int exponent = 25;
int count = 1;
int result = number;

while (count < exponent)
{
    result = result * number;
    count++;
}

System.Console.WriteLine($"{number} ^ {exponent} = {result}");
System.Console.WriteLine();