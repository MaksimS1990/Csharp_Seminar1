//Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда; 5 -> Пятница;

Console.WriteLine("Программа выдает дни недели по заданному номеру");
Console.WriteLine("Введите число от 1 до 7: ");
int number = int.Parse(Console.ReadLine()!);

if ((number < 8)&&(number > 0) ){
    if(number == 1) Console.WriteLine("Monday");
    if(number == 2) Console.WriteLine("Tuesday");
    if(number == 3) Console.WriteLine("Wednesday");
    if(number == 4) Console.WriteLine("Thursday");
    if(number == 5) Console.WriteLine("Friday");
    if(number == 6) Console.WriteLine("Saturday");
    if(number == 7) Console.WriteLine("Sunday");
}
else {
    Console.WriteLine("Произошла ошибка");
    }