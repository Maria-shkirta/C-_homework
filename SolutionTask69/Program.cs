//Напишите программу, которая на вход принимает два числа А и В, и возводит число А в целую степень В с помощью рекурсии.

int numberA=ReadNumber("Задайте число A");
int numberB=ReadNumber("Задайте число B");

Console.Write(PowNumber(numberA,numberB));

int PowNumber(int a,int b)
{
    if (b==1) return a;
    return a*PowNumber(a,--b);
}

int ReadNumber(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine()??"");
}