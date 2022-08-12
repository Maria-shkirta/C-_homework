//П, которая перевернет одноиерный массив (последний элемент будет первым и тд)

//метод заполняет массив
int[] FillingArray(int arrayLength)
{
    int[] outArray = new int[arrayLength];
    int i = 0;
    System.Random numberSintezator = new System.Random();
    while (i < arrayLength)
    {
        outArray[i] = numberSintezator.Next(-1000, 1000);

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
    Console.Write(outArray[i]);
}

//метод решения задачи 39
int[] ReversNewArray(int[] array)
{
    int length=array.Length;
    int[] newArray=new int[length];

    for (int i=0; i<length; i++)
{
    newArray[length-1-i]=array[i];
}
return newArray;
}

int[] ReverseSwapArray(int[] array)
{
int length=array.Length;
int buf;

for (int i=0; i<length/2; i++)
{
    buf=array[i];
    array[i]=array[length-1-i];
    array[length-1-i]=buf;
}
return array;
}


int[] testArray = FillingArray(13);
PrintIntArray(testArray);
Console.WriteLine();
int[] reservedArray = ReversNewArray(testArray);
PrintIntArray(reservedArray);
Console.WriteLine();
PrintIntArray(ReverseSwapArray(testArray));


