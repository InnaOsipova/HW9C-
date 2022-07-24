 //Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

 string SeriesOfNumbers (int a, int n)
{
    if (a == n) 
    {
        return n.ToString(); 
    }
    else 
    {
        return a.ToString() + " " + SeriesOfNumbers(a+1 , n); 
    }
}


Console.Write(SeriesOfNumbers (1, 10));