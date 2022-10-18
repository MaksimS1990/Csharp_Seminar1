//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.
//456 -> 5
//782 -> 8
//918 -> 1

// 1. Генерируем случайное трёхзначное число.
int GenerateRandomNumber()
{
    return new Random().Next(100,1000); //трёхзначное число.
}
// 2. Удаляем вторую цифру этого числа.
int FinalDigit(int randomNumber)
{
    Console.WriteLine(randomNumber);
    int firstDigit = randomNumber / 100;
    int secondDigit = (randomNumber - firstDigit*100) / 10;
    return (secondDigit);
}
int randomNumber = GenerateRandomNumber();
Console.WriteLine(FinalDigit(randomNumber));