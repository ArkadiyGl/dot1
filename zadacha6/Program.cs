// Задача 6: Выяснить является ли число чётным
// если делится на 2 - то тогда да. 


Console.Clear();
System.Console.WriteLine();
System.Console.Write("Введите число:    ");
string writeNumber = Console.ReadLine();
int number = Convert.ToInt32(writeNumber);
string result = $"Число {number} является чётным";

if (number % 2 != 0) result = result.Replace("является", "не является");

System.Console.WriteLine(result);
System.Console.WriteLine();
