// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 0, 7, 8, -2, -2 -> 2

int[] Read(int m)
{
    int[] newArray=new int[m];
    int i=0;
    while (i<m)
    {
        newArray[i]=int.Parse(Console.ReadLine());
    }
    return newArray;
}

int Calculate (int[] newArray, int m)
{
    int Count=0;
    int i=0;
    while (i<m)
    {
        if (newArray[i]>0)
        {
            Count++;
        }
        i++;
    }
    return Count;
}

void PrintResult(int Count)
{
    Console.WriteLine(Count);
}

Console.WriteLine("Введите количество чисел: ");
int m=int.Parse(Console.ReadLine());
Console.WriteLine("Введите числа: ");
int[] num=new int[m];
Read(m);
int result = Calculate(num,m);
PrintResult(result);
