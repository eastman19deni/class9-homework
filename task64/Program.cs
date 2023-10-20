﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using static System.Console;

Write("Enter N =");
int n = int.Parse(ReadLine());
Write($"->" + "");
int count = 2;
NaturalToLow(n, count);
Write(1);

void NaturalToLow(int n, int count)
{
    if (count > n) return;
    NaturalToLow(n, count + 1);
    Console.Write(count + ",");
}

