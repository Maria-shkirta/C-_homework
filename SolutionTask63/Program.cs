//Задайте значение N. Напишите программу, которая выведетвсе натуральные числа в промежутке от 1 до N.

int RaedData()
{
    Console.WriteLine("Задайте число: ");
    return int.Parse(Console.ReadLine());
}

int NuturalNumberPrinter(int num)
{
    if (num==2) return 1;
    else
    {
        num--;
        Console.WriteLine(num);
        Console.Write(NuturalNumberPrinter(num)+" ");

    }
    return num;
}

int inputNumber=RaedData();
NuturalNumberPrinter(inputNumber+2);