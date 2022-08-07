// принимает два числа А и В, возводит число А в натуральную степень В.

Console.Write("Введите число А: ");

int inputNumberA=int.Parse(Console.ReadLine());

Console.Write("Введите число В: ");

int inputNumberB=int.Parse(Console.ReadLine());

void Calculate()
{
    int C=1;
    int i=0;
    while (i<inputNumberB)
    {
        C=C*inputNumberA;
        i++;
    }
    Console.WriteLine(C);

}

Calculate();