// Задача 10: Показать вторую цифру трёхзначного числа.

int d3;

Console.WriteLine("Введите трехзначное число ");
d3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вторая цифра трехзначного числа = " + d3 / 10 % 10);

Console.ReadKey();

