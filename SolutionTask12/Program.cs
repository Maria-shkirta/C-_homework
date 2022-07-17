//решение Николая
string? inputNumber1= Console.ReadLine();
string? inputNumber2= Console.ReadLine();

if (inputNumber1 != null && inputNumber2 != null)
{
    int inputNumberOne=int.Parse(inputNumber1);
    int inputNumberTwo=int.Parse(inputNumber2);

    int div= inputNumberTwo%inputNumberOne;

    if (div==0)
    {
        Console.WriteLine("yes");
    }
    else
    {
        Console.WriteLine("no"+div);
    }
}