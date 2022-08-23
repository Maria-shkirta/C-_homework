// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

//M = 1; N = 5. -> ""1, 2, 3, 4, 5""


int numberM=ReadData("Задайте число M");
int numberN=ReadData("Задайте число N");

if (numberM<numberN)
{
    NaturalNumberPrinter(numberM,numberN);
}
else
{
    NaturalNumberPrinter(numberN,numberM);
}

int ReadData(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine());
}

void NaturalNumberPrinter(int m,int n)
{
    if (m-1==n)return;
    Console.WriteLine(m+" ");
    NaturalNumberPrinter(m+1,n);
}


