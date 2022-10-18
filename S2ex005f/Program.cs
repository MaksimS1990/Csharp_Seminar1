// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом второго.
// 5-> 25; -4-> 16; 25-> 5; 8->9.

Console.WriteLine("Программа Проверяет, является ли первое число, квадратом второго и наоборот");
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);

if (IsSquare(a, b))
{
    Console.WriteLine("Да, кратно");
}
else
{
    Console.WriteLine("Нет, не кратно");
}

bool IsSquare(int a, int b)// функция
{
    return a == b * b || b == a * a;
}