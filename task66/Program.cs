// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using static System.Console;

Write($"Enter M =");
int m = int.Parse(ReadLine());
Write("Enter N =");
int n = int.Parse(ReadLine());
int temp = m;

if(m >n)
{
    m= n; n = temp;
}

PrintSum(m, n, temp = 0);

void PrintSum(int m, int n, int sum)
{
    sum = sum +n;
    if(n <=m)
    {
        Write($"sum of elements = {sum}");
        return;
    }
    PrintSum(m, n - 1, sum);
}
