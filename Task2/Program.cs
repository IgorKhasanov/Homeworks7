// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

void Main()
{
    int m = 2;
    int n = 3;
    Console.WriteLine($"A({m},{n}) = {AkkermanFunction(m, n)}");
}

int AkkermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return AkkermanFunction(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    }
    return (AkkermanFunction(m, n));
}
Main();
