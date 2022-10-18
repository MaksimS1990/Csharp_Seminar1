// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Программа на выходе показывает третью цифру заданного числа");
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);

if (a < 100) 
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
thirdDigit(a);
}
void thirdDigit(int a)
{
  
    while(a >= 1000)
    {
    a = a / 10;
    }
int N = a % 10;
Console.WriteLine("Третья цифра числа: " + N);
}