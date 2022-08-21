//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

int[,] Filtr(int[,] inputArray)
{
    int[] bufferArray = new int[inputArray.GetLength(0)];
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        while (j < inputArray.GetLength(1))
        {
            j = 0;
            bufferArray[i] = inputArray[i, j];
            j++;
        }

        void BubbleSort(int[] bufferArray)
        {
            while (i<bufferArray.Length)
            {
                if (bufferArray[i]<bufferArray[i+1])
                {
                    bufferArray[i+1]=bufferArray[i];
                }
                i++;
            }
        }

        BubbleSort(bufferArray);

        while (j < inputArray.GetLength(1))
        {
            inputArray[i, j] = bufferArray[i];
            j++;
        }
        i++;

    }
    return inputArray;

}

int[,] twoDumArray = FillTwoDemArray(4, 4);
PrintTwoDimArray(twoDumArray);
Console.WriteLine();
PrintTwoDimArray(Filtr(twoDumArray));