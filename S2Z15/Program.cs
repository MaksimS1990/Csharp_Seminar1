// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Программа принимает цифру и выдает дни недели по заданному номеру, и проверяет, является ли этот день выходным.");
Console.WriteLine("Введите число от 1 до 7: ");
int number = int.Parse(Console.ReadLine()!);

DaysPerWeek(number);

void DaysPerWeek(int number)
{
if ((number < 6)&&(number > 0) ){
    if(number == 1) Console.WriteLine("Monday");
    if(number == 2) Console.WriteLine("Tuesday");
    if(number == 3) Console.WriteLine("Wednesday");
    if(number == 4) Console.WriteLine("Thursday");
    if(number == 5) Console.WriteLine("Friday");
    Console.WriteLine("Этот день не является выходным!");
    }
else {
    if(number == 6) Console.WriteLine("Saturday");
    if(number == 7) Console.WriteLine("Sunday");
    Console.WriteLine("Этот день является выходным!");
    }
}