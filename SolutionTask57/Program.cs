//Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

//метод заполнения двумерного массива
int[,] FillTwoDemArray(int countRow, int countColumn)
{

    System.Random numberSyntezator = new System.Random();
    int i = 0; int j = 0;

    int[,] outArray = new int[countRow, countColumn];

    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)
        {
            outArray[i, j] = numberSyntezator.Next(0, 101);
            j++;
        }
        i++;
    }
    return outArray;

}

//Метод для печати двумерного массива
void PrintTwoDimArray(int[,] inputArray)
{
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.Write(inputArray[i, j] + " " + "\t");
            j++;
        }
        //Console.Write("\n")
        Console.WriteLine();
        i++;
    }
}


//создает массив со счетчиком элементов
int[] ResultArray(int[,] inputArray)
{
    int[] resultArray = new int[inputArray.GetLength(0)];
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(0))
        {
            //собираем частоту появления элементов
            resultArray[inputArray[i, j]]++;
            j++;
        }
        i++;
    }
    return resultArray;

}

//метод печатает массив
void PrintIntArray(int[] resultArray)
{
    int i = 0;

    while (i < (resultArray.Length - 1))
    {
        Console.Write(resultArray[i] + ", ");
        i++;

    }
    Console.Write(resultArray[i]);
}



int[,] twoDumArray = FillTwoDemArray(4, 4);
PrintTwoDimArray(twoDumArray);
Console.WriteLine();
int[] outArray = ResultArray(twoDumArray);
PrintIntArray(outArray);







