Console.WriteLine("Введите номер дня недели от 1 до 7: ");
string? a1 = Console.ReadLine();
int b1;

if (int.TryParse(a1, out b1))
{
if (b1 == 0) Console.WriteLine("Ошибка ввода! Введите число от 1 до 7!");
if (b1 < 6)  Console.WriteLine("Будни");
else if (b1 == 6 || b1 == 7) Console.WriteLine("Выходной");
else Console.WriteLine("Ошибка ввода! Введите число от 1 до 7!");
}
else Console.WriteLine("Ошибка ввода! Повторите ввод!");