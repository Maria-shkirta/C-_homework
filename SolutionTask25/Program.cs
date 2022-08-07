// принимает два числа А и В, возводит число А в натуральную степень В.

int inputNumberA;
int inputNumberB;
int C;
int i;

void Read()
{
    Console.Write("Введите число А: ");

    inputNumberA = int.Parse(Console.ReadLine());

    Console.Write("Введите число В: ");

    inputNumberB = int.Parse(Console.ReadLine());
}

Read();

void Calculate()
{
    C = 1;
    i = 0;
    while (i < inputNumberB)
    {
        C = C * inputNumberA;
        i++;
    }


}

Calculate();

void Print()
{

    Console.WriteLine(C);
}

Print();