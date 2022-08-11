//задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом.

//метод заполняет массив
int[] FillingArray()
{
    int[] outArray = new int[4];
    int i = 0;
    System.Random numberSintezator = new System.Random();
    while (i < 4)
    {
        outArray[i] = numberSintezator.Next(1, 10);
        i++;
    }
    return outArray;
}


//метод печатает массив
void PrintIntArray(int[] outArray)
{
    int i = 0;

    while (i < (outArray.Length))
    {
        Console.Write(outArray[i] + ", ");
        i++;

    }
}


//метод решения задачи 38
int ColculateTask(int[] outArray)
{
    int minNumber = 0;
    int maxNumber = int.MaxValue;
    int i = 0;

    while (i < outArray.Length)
    {

        if (outArray[i] > maxNumber)
        {
            maxNumber = outArray[i];

        }

        if (outArray[i] < minNumber)
        {
            minNumber = outArray[i];
            
        }
        i++;
        
        
    }

    return (maxNumber-minNumber);
}


int[] buferArray = FillingArray();
PrintIntArray(buferArray);
Console.WriteLine();
int result = ColculateTask(buferArray);
Console.Write(result);
