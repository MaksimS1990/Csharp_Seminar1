//  Напишите программу, которая принимает на вход целое число любой разрядности и удаляет вторую цифру слева направо этого числа. 

Console.WriteLine("Программа принимает число и удаляет вторую цифру слева направо.");
Console.WriteLine("Введите любое число: ");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine());

int onlyNumber = 0;
int num2 = 0;
 while (num > 99)
{
    onlyNumber = num % 10;
    num2 = num2 * 10;
    num2 = num2 + onlyNumber;
    num = num / 10;

}
onlyNumber = num / 10;
num2 = num2 * 10;
num2 = num2 + onlyNumber;

Console.WriteLine(num2);