//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


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
            outArray[i, j] = numberSyntezator.Next(0, 101);
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
            Console.Write(inputArray[i, j] + " " + "\t");
            j++;
        }
        //Console.Write("\n")
        Console.WriteLine();
        i++;
    }
}

int FindRow(int[,] inputArray)
{
    int i = 0; int j = 0;
    int minElement=int.MaxValue;
    int minIndex=0;

    while (i < inputArray.GetLength(0))
    {
        j=0;
        int b=0;
        while (j < inputArray.GetLength(1))
        {
            b+=inputArray[i,j];
            
            j++;
        }

        if (b< minElement)
            {
                b=minElement;
                minIndex=i;
            }
            i++;

    }
    return minIndex;

}

int[,] twoDumArray = FillTwoDemArray(4, 4);
PrintTwoDimArray(twoDumArray);
Console.WriteLine();
int index=FindRow(twoDumArray);
Console.WriteLine(index);