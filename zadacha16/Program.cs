// Задача 16: Дано число обозначающее день недели. 
// Выяснить является номер дня недели выходным
// Если номер будет больше 5, то он станет выходным из семи возможных


//Console.Clear();
System.Console.WriteLine();

int dayNumber = new Random().Next(1, 8);
string[] Days = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
string txtResult = "";

if (dayNumber > 5) txtResult = $". Выходной день!";
else txtResult = $", Рабочий день.";

System.Console.WriteLine();
System.Console.WriteLine($"{dayNumber}-й день недели - это {Days[dayNumber - 1]}{txtResult}");
System.Console.WriteLine();