﻿// замена элеиентов массива. положительные заменить на отрицательные и наборот.

int[] FillingArray()
{
    int[] outArray = new int[12];
    int i = 0;
    System.Random numberSintezator = new System.Random();
    while (i < 12)
    {
        outArray[i] = numberSintezator.Next(-9, 10);

        i++;
        

    }
    return outArray;
}
 
// метод инвертирует элементы массива тильда
int[] InvertArrayTilda(int[] inputArray)
{
    //буферная переменная
    int i=0;

    while (i<inputArray.Length)
    {
        //инвертируем элемент
    inputArray[i]=(~inputArray[i])+1;
    //увеличиваем инкремент
    i++;
    }
    //выводим массив

    return inputArray;
}

int[] ColculateTask(int[] inputArray)
{
    int[] outputArray=new int[12];
    int i=0;
    while (i<12)
    {
        outputArray[i]=inputArray[i]*(-1);
        i++;
    }
    return outputArray;

}

void PrintIntArray(int[] outArray)
{
    int i=0;
     
     while (i<(outArray.Length-1))
     {
        Console.Write(outArray[i]+", ");
        i++;

     }
}

int[] bufferArray=FillingArray();
PrintIntArray(bufferArray);
int[] resultArray=ColculateTask(bufferArray);
Console.WriteLine();
PrintIntArray(resultArray);
Console.WriteLine();
resultArray=InvertArrayTilda(bufferArray);
PrintIntArray(resultArray);
