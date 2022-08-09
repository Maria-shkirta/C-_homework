// массив из 12 элементов, заполненный случайными числами из промежутка (-9,9). найти сумму отрицательных и положительных элементов массива.
int posetivSum = 0;
int negativSum = 0;

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

//метод подсчета положительных и отрицательных чисел
void ColculateTask(int[] outArray)
{
    int i=0;
    while (i<12)
    {
        if (outArray[i]>0)
        {
            posetivSum+=outArray[i];
        }
        else
        {
            negativSum+=outArray[i];
        }
        i++;
    }
    

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


void PrintResult()
{
    Console.WriteLine(posetivSum);
    Console.WriteLine(negativSum);

}

void VariantNaive()
{
    int[] bufferArray = FillingArray();
    ColculateTask(bufferArray);
    PrintIntArray(bufferArray);
    PrintResult();
}

VariantNaive();



