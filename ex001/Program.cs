﻿// Напишите программу, которая на вход принимает (целое) числои выдвёт на консоль его квадрат.
// Например : 4 -> 16 ; -3 -> 9 ; -7 -> 49 ;

Console.WriteLine("Программа вычисления квадрата числа");
Console.WriteLine("Введите Ваше число");
//1. Ввод числа.
int input = int.Parse(Console.ReadLine()!);
//2. Вычисление квадрата числа.
int result = input * input;
//3. Вывод результата на консоль.
Console.WriteLine("Квадрат числа: " + result);