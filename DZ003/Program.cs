//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

double AkkermanFunktion (double m,  double n )
{
    if (m == 0) return n+1;
    if (m > 0 && n == 0 ) return AkkermanFunktion(m-1, 1);
    if (m > 0 && n > 0) return AkkermanFunktion (m-1, AkkermanFunktion(m, n-1));
    return AkkermanFunktion(m, n);
}

Console.WriteLine(AkkermanFunktion ( 3, 2));