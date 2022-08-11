// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечетных позициях. 3,7,23,12- 19

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


//метод решения задачи 34
int ColculateTask(int[] outArray)
{
    int resultNumber = 0;

    int i = 1;
    while (i < outArray.Length)
    {
        resultNumber = resultNumber + outArray[i];
        i += 2;

    }
    return resultNumber;


}


int[] buferArray = FillingArray();
PrintIntArray(buferArray);
Console.WriteLine();
int result = ColculateTask(buferArray);
Console.Write(result);