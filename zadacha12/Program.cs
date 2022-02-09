// Задача 12: Удалить вторую цифру трёхзначного числа.
//  

string s;
int n, d1, d2, d3;
Console.WriteLine("Введите трехзначное число ");
s = Console.ReadLine();
n = Convert.ToInt32(s);
d1 = n / 100;
d3 = n % 10;
Console.WriteLine("Трехзначное число без cредней цифры : " + (d1, d3));
Console.ReadKey();

