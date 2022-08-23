//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120

int numberM = ReadData("Задайте число M");
int numberN = ReadData("Задайте число N");
int sum=0;

if (numberM < numberN)
{
    NaturalNumberPrinter(numberM, numberN);
}
else
{
    NaturalNumberPrinter(numberN, numberM);
}

int ReadData(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine());
}


void NaturalNumberPrinter(int m, int n)
{
    if (m - 1 == n) return;
    sum=sum+m;
    Console.WriteLine(sum);
    NaturalNumberPrinter(m + 1, n);
}
