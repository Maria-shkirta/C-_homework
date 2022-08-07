// принимает число, выдает сумму цифр в числе. 82=>10

int inputNumber = int.Parse(Console.ReadLine());
int B = 0;

void Calculate()
{
    while (inputNumber > 0)
    {
        B = B + inputNumber % 10;
        inputNumber = inputNumber / 10;
    }

}

Calculate();

Console.WriteLine(B);