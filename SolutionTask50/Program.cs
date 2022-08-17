//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//17 -> такого числа в массиве нет


//метод заполнения двумерного массива
int[,] FillTwoDemArray(int countRow, int countColumn)
{

    System.Random numberSyntezator = new System.Random();
    int i = 0; int j = 0;

    int[,] outArray = new int[countRow, countColumn];

    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)
        {
            outArray[i, j] = numberSyntezator.Next(-100, 100);
            j++;
        }
        i++;
    }
    return outArray;

}

//Метод для печати двумерного массива
void PrintTwoDimArray(int[,] inputArray)
{
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.Write(inputArray[i, j] + " ");
            j++;
        }
        //Console.Write("\n")
        Console.WriteLine();
        i++;
    }


}

bool SearchEbmTwoDimArray(int[,] inputArray, int e)
{
     int i = 0; int j = 0;
     bool result=false;
     
    while (i < inputArray.GetLength(0))
    {
        while (j < inputArray.GetLength(1))
        {
            if (inputArray[i,j]==e)
            {
            result=true;
            }
            j++;
            
        }
        i++;
    }
    return result;

}

void PrintResult(bool Res)
{
    if (Res=false)
    {
        Console.WriteLine("Такого элемента нет");
    }
    else
    {
        Console.WriteLine("Такой элемент есть");
    }
}

int[,] twoDumArray = FillTwoDemArray(3,4);
PrintTwoDimArray(twoDumArray);
Console.WriteLine("Введите число: ");
int e=int.Parse(Console.ReadLine());
bool Res=SearchEbmTwoDimArray(twoDumArray,e);
PrintResult(Res);

