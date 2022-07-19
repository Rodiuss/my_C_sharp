Console.Write("Введите число: ");
string? number = Convert.ToString(Console.ReadLine());
if (number!.Length >= 3) Console.WriteLine("Третья цифра: " + number[2]);
else Console.WriteLine("Третьей цифры нет");
