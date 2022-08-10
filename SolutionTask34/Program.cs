//задайте массив положительными трехзначными числами. П показывает количество четных чисел в массиве.

//метод заполняет массив
int[] FillingArray()
{
    int[] outArray = new int[12];
    int i = 0;
    System.Random numberSintezator = new System.Random();
    while (i < 12)
    {
        outArray[i] = numberSintezator.Next(100, 1000);
        i++;
    }
    return outArray;
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


//метод решения задачи 34
int ColculateTask(int[] inputArray)
{
    int resultNumber = 0;

    int i = 0;
    while (i < inputArray.Length)
    {
        if (inputArray[i] % 2 == 0)
        {
            resultNumber++;
        }
        i++;

    }
    return resultNumber;


}


int[] buferArray = FillingArray();
PrintIntArray(buferArray);
Console.WriteLine();
int result = ColculateTask(buferArray);
Console.Write(result);



