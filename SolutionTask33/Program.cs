//определяет присутствует ли заданное число в массиве. цифра 4, массив с числами- ответ да или нет

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

//метод решения задачи 33
bool ColculateTask(int[] inputArray, int searchNumber)
{
    bool resultSearch=false;
    int i=0;
    while (i<12)
    {
        if (inputArray[i]==searchNumber)
        {
            resultSearch=true;
            break;
        }
        i++;
    }
    return resultSearch;

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

int[] buferArray=FillingArray();
PrintIntArray(buferArray);
Console.WriteLine("ВВедите число для поиска: ");
int searchNumber=int.Parse(Console.ReadLine());

Console.WriteLine(ColculateTask(buferArray,searchNumber));
