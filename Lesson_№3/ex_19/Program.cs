Console.Write("Введите число: ");
string number = Console.ReadLine();
if (number.Length > 5 || number.Length < 5) Console.WriteLine("Введите пятизначное число!");
else if (number[0] != number[4] || number[1] != number[3]) Console.WriteLine("Это число не полиндром");
else if (number[0] == number[4] && number[1] == number[3]) Console.WriteLine("Это чило полиндром");
