//принимает число А, выдает сумму чисел от 1 до А
Console.Write("Введите число: ");

int inputNumber=int.Parse(Console.ReadLine());
int t;

void VariantSimple()
{
    int sumOfNumbers=0;
    for (int i=1; i<=inputNumber; i++)
    {
        sumOfNumbers += i;
        //sumOfNumbers=sumOfNumbers+i;

    }
    Console.WriteLine("Сумма чисел от 1 до "+inputNumber+"="+sumOfNumbers);
    Console.WriteLine("Simple time:{0}ms", Environment.TickCount-t);

}

t=Environment.TickCount;

VariantSimple();

void VariantGauss()
{
    int sumOfNumbers=0;

    sumOfNumbers=((inputNumber+1)*inputNumber)/2;

    Console.WriteLine("Сумма чисел от 1 до "+inputNumber+"="+sumOfNumbers);
    Console.WriteLine("Gauss time:{0}ms", Environment.TickCount-t);

}

VariantGauss();