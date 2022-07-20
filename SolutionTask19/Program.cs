//принимает 5значное число, проверяет явлется ли палиндромом.

string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);

    int input1 = inputNumber / 10000;
    int input2 = (inputNumber / 1000) % 10;
    int input3 = (inputNumber / 100) % 10;
    int input4 = (inputNumber / 10) % 10;
    int input5 = inputNumber % 10;

    if ((input1 == input5)&&(input2 == input4))
    {
        Console.WriteLine("да");
    }
    else Console.WriteLine("нет");
}