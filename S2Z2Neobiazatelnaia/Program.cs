Console.WriteLine("количество программистов в аудитории.");
Console.WriteLine("Введите число от 1 до 1000: ");
int number = int.Parse(Console.ReadLine()!);

if (number == 0) {
    Console.WriteLine("Программиcтов в аудитории нет");
}

if (number == 1) {
    Console.WriteLine("Программиcт в аудитории " + number);
}

if ((number > 1) && (number < 5)) {
    Console.WriteLine("Программиcтов в аудитории " + number);
}

if ((number > 5) && (number < 1000)) {
    Console.WriteLine("Программиcтов в аудитории " + number);
}

if (number > 1000) {
    Console.WriteLine("Программиcт в аудитории больше 1000");
}

if (number < 0) {
    Console.WriteLine("Совершена ошибка в подсчётах");
}
