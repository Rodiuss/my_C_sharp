Console.Write("Введите день недели (от 1 до 7): ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 6 || number == 7) Console.WriteLine("Выходной");
else if (number >= 1 && number <= 5) Console.WriteLine("Будни");
else Console.WriteLine("Такого дня недели нет!");
