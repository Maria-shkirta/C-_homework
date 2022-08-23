//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

int numberM=ReadData("Задайте число M");

Console.WriteLine(Sum(numberM));

int ReadData(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine());
}

int Sum(int num)
{
    if (num>0)
    {
    return num%10+Sum(num/10);

    }
    else
    {
        return 0;
    }
}