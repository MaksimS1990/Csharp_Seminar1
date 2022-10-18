// Напишите программу, которая будет принимать на вход два числа и выводить ,является ли второе число кратным первому. Если число 2 не кратно числу 1,
// то программа выводит остаток от деления.
// 35, 5 -> не кратно, остаток 4.
// 16, 4 -> кратно.

// Вводим два числа.
Console.WriteLine("Программа Проверяет, является ли второе число, квадратом первого");
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);

// Проверяем кратность.
void res(int a, int b)
{
    int result = a % b;
    if (result == 0)
    {
    Console.WriteLine("Кратно");
    }
    else
    {
    Console.WriteLine("Не кратно");
    Console.WriteLine("Остаток составляет: " + result);
    }
}
res(a, b);