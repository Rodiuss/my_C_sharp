Console.Write("Введите день недели (от 1 до 7): ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 6 || number == 7) Console.WriteLine("Да");
else if (number >= 1 && number <= 5) Console.WriteLine("Нет");
else Console.WriteLine("Такого дня недели нет!");
