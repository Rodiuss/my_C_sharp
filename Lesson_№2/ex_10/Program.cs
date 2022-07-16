Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 999) Console.WriteLine("Результат " + number % 10 % 10);
else Console.WriteLine("Вы ввели не трёхзначное число!");
