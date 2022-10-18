// Случайное число из отрезка целых чисел [10, 99] и показать наибольшую цифру числа.

int GenerateRandomNumber()
{
    return new Random().Next(10, 100);
}

int GetMaxDigitForTwoDigitsNumber(int randomNumber)
{
    int firstDigit = randomNumber / 10;
    int secondDigit = randomNumber % 10;
    Console.WriteLine("Сгенерировать число в диапазоне [10, 99]: " + randomNumber);
    
    // 2.2. Показать наибольшую цифру числа.
    int max = firstDigit;

    if(secondDigit > firstDigit)
        max = secondDigit;
    return max;
}

// 1. Сгенерировать случайное число на отрезке.
int randomNumber = GenerateRandomNumber();

// 2. Найти наибольшую цифру числа.
int max = GetMaxDigitForTwoDigitsNumber(randomNumber);

// 3. Показать результат.
Console.WriteLine("Наибольшая цифра числа: " + max);