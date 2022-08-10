//найти произведение пар чисел в одномерном массиве. Парой считать первый и последний эдемент, второй и предпоследний. Результат написать в новом массиве. 1 2 3 4 5>=5 8 3

//метод заполняет массив
int[] FillingArray()
{
    int[] outArray = new int[123];
    int i = 0;
    System.Random numberSintezator = new System.Random();
    while (i < 123)
    {
        outArray[i] = numberSintezator.Next(-1000, 1000);

        i++;


    }
    return outArray;
}

//метод решения задачи 37
int[] ColculateTask(int[] inputArray)
{
    int[] resultArray = new int[inputArray.Length / 2 + 1];

    int i = 0;
    while (i < resultArray.Length)
    {
        resultArray[i] = inputArray[i] * inputArray[inputArray.Length - 1 - i];
        i++;

    }
    return resultArray;


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

int[] buferArray = FillingArray();
PrintIntArray(buferArray);
Console.WriteLine();
int[] resultArray = ColculateTask(buferArray);
PrintIntArray(resultArray);

