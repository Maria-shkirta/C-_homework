//задать одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]

//метод заполняет массив
int[] FillingArray()
{
    int[] outArray = new int[123];
    int i = 0;
    System.Random numberSintezator = new System.Random();
    while (i < 123)
    {
        outArray[i] = numberSintezator.Next(-1000,1000);

        i++;


    }
    return outArray;
}

//метод решения задачи 35
int ColculateTask(int[] inputArray, int downBorder, int upBorder)
{
    int resultCount = 0;
    int i = 0;
    while (i < inputArray.Length)
    {
        if (inputArray[i]>=downBorder&&inputArray[i]<=upBorder)
        {
            Console.Write(inputArray[i]+" ");
            resultCount++;
        }
        i++;
    }
    return resultCount;

}

//метод печатает массив
void PrintIntArray(int[] outArray)
{
    int i = 0;

    while (i < (outArray.Length - 1))
    {
        Console.Write(outArray[i] + ", ");
        i++;

    }
}

int[] buferArray=FillingArray();
PrintIntArray(buferArray);
Console.WriteLine();
Console.WriteLine(ColculateTask(buferArray,10,99));
