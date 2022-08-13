//п создает копию заданного одномерного массива с помощью поэлементного массива.

int[] CopyArrayStandartTool(int[] inputArray)
{
    int[] buferArray = new int[inputArray.Length];
    inputArray.CopyTo(buferArray, 0);
    return buferArray;
}

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

void PrintIntArray(int[] outArray)
{
    int i = 0;

    while (i < (outArray.Length - 1))
    {
        Console.Write(outArray[i] + ", ");
        i++;

    }
}

int[] testArray=FillingArray();
PrintIntArray(testArray);
int[] outArray=CopyArrayStandartTool(testArray);
PrintIntArray(outArray);

