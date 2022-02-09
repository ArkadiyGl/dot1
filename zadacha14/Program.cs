// Задача 14: Найти третью цифру числа или сообщить, что её нет. (сделаю с рандомом)


Console.Clear();
System.Console.WriteLine();

int Number = new Random().Next(1, 9999);
System.Console.WriteLine();
System.Console.WriteLine($"Дано число: {Number}");

if (Number / 100 > 0) System.Console.WriteLine($"Третьей цифрой числа {Number} будет цифра {Number / 100 % 10}");
else System.Console.WriteLine($"У числа {Number} нет третьей цифры");

System.Console.WriteLine();