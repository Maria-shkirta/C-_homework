﻿//принимает на вход 3 числа и проверяет, может ли существовать треугольник со сторонами такой длины.

int sideA = 0;
int sideB = 0;
int sideC = 0;

ReadSides();
bool res = TestTriangle(sideA, sideB, sideC);
PrintAnswer(res);

void ReadSides()
{
    Console.Write("Введите число 1: ");
    sideA = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите число 2: ");
    sideB = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите число 3: ");
    sideC = int.Parse(Console.ReadLine() ?? "");
}

bool TestTriangle(int num1, int num2, int num3)
{
    bool answer = ((num1 + num2 > num3)
    && (num2 + num3 > num1)
    && (num1 + num3 > num2)) ? true : false;
    //perem=(условие)?значение1:значение2
    return answer;
}

void PrintAnswer(bool answer)
{
    if (answer)
    {
        Console.WriteLine("Из этих отрезков можно составить треугольник");

    }
    else
    {
        Console.WriteLine("Из этих отрезков нельзя составить треугольник");

    }

}