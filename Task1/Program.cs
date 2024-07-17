//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы. 

void Main()
{
    int m = 4;
    int n = 8;
    Console.Write($"m = {m}; n = {n} ->  ");
    Console.Write(NaturalNumbers(m, n));
}

string NaturalNumbers(int m, int n)
{
    if (m == n) return Convert.ToString(n);
    return m + "," + NaturalNumbers(m + 1, n);
}
Main();
