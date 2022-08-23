//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

//m = 2, n = 3 -> A(m,n) = 9

using System;
class GFG
{
static int ack( int m, int n)
{
if (m == 0)
{
return n + 1;
}
else if ((m > 0) && (n == 0))
{
return ack(m - 1, 1);
}
else if ((m > 0) && (n > 0))
{
return ack(m - 1, ack(m, n - 1));
} else
return n + 1;
}
// Driver code
public static void Main()
{
Console.WriteLine(ack(2, 3));
}
}

