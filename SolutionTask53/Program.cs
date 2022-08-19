//Зажайте двумерный массив. Задайте программу, которая поменяет местами первую и последнюю строки массива.


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
            Console.Write(inputArray[i, j] + " "+"\t");
            j++;
        }
        //Console.Write("\n")
        Console.WriteLine();
        i++;
    }
}

//метод меняет местами первую и последнюю строчку
//принимает двумерный массив
//возвращает модифицированный входной массив
int[,] RotateRowFirstLast(int[,] inputArray)
{
    int bufferElement = 0;
    int i = 0; int j = 0;

    while (j < inputArray.GetLength(1))
    {
        //блок ротации элементов в столбце
        bufferElement = inputArray[0, j];
        inputArray[0, j] = inputArray[inputArray.GetLength(0) - 1, j];
        inputArray[inputArray.GetLength(0) - 1, j] = bufferElement;
        j++;
    }
    return inputArray;

}


int[,] twoDumArray = FillTwoDemArray(3, 4);
PrintTwoDimArray(twoDumArray);
Console.WriteLine();
PrintTwoDimArray(RotateRowFirstLast(twoDumArray));




