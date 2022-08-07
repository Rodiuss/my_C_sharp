Console.Write("Введите число: ");
string? number = Console.ReadLine();

int length = number!.Length;

int result = 0;

for (int i = 0; i < length; i++) result += number[i] - '0';

Console.WriteLine(result);