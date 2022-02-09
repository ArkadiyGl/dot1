// Даны два числа. Показать большее и меньшее число
// сами вводим числа a and b , если а больше б то печатаем а - самое большое число, ь - самое маленькое число

Console.WriteLine("введите первое число :");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("введите второе число :");
double b = double.Parse(Console.ReadLine());
if (a>b)
{
    Console.WriteLine("Большое число а = " + a );
    Console.WriteLine("Маленькое число b = " + b );
}
else{
   Console.Write("Самое большое число =");
   Console.WriteLine(b);
   Console.Write("Самое маленькое число =");
   Console.WriteLine(a);
}