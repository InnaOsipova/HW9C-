//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumNumbers ( int m, int n)
{
    if (m == n) return n;
    return m + SumNumbers (m+1, n);
}

Console.WriteLine (SumNumbers(2, 4));