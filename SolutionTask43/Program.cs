//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)


int b1;
int b2;
int k1;
int k2;
int x;
int y;

void Read()
{
Console.WriteLine("Введите b1: ");
b1=int.Parse(Console.ReadLine());
Console.WriteLine("Введите k1: ");
k1=int.Parse(Console.ReadLine());
Console.WriteLine("Введите b2: ");
b2=int.Parse(Console.ReadLine());
Console.WriteLine("Введите k2: ");
k2=int.Parse(Console.ReadLine());
}

void Calculate(int k1,int k2,int b1,int b2)
{
    x=((b2-b1)/(k1-k2));
    y=(k1*x+b1);

}

void PrintResult(int x,int y)
{
    Console.Write((x,y));
}


Read();
Calculate(k1,k2,b1,b2);
PrintResult(x,y);
