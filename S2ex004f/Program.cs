// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. (14, 46, 161).

Console.WriteLine("Программа Проверяет, кратно ли Ваше число одновременно 7 и 23");
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);

if (multiplicity(a))
{
    Console.WriteLine("Кратно");
}
else
{
  Console.WriteLine("Не кратно");  
}

bool multiplicity(int a)
{
    return a % 7 == 0 && a % 23 == 0;
}