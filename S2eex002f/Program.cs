// Напишите программу, которая вводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46 ; 782 -> 72 ; 918 -> 98.

// 1. Генерируем случайное трёхзначное число.
int GenerateRandomNumber()
{
    return new Random().Next(100,1000); //трёхзначное число.
}
// 2. Удаляем вторую цифру этого числа.
int OutSecondDigit(int randomNumber)
{
    Console.WriteLine(randomNumber);
    int firstDigit = randomNumber / 100;
    int secondDigit = (randomNumber - firstDigit*100) / 10;
    int thirdDigit = randomNumber % 10;
    return (firstDigit*10 + thirdDigit);
}
int randomNumber = GenerateRandomNumber();
Console.WriteLine(OutSecondDigit(randomNumber));
