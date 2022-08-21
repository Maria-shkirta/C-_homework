//Задайте двумерный массив из целых чисел. Напиишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.


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

//Метод поиска наименьшего элемента
int[] FindMinElement(int[,] matrix)
{
    int[] array = new int[] { 0, 0 };
    int minElement = int.MaxValue;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < minElement)
            {
                minElement = matrix[i, j];
                array[0] = i;
                array[1] = j;
            }
        }
    }
    return array;
}

//метод удаляет строку и столбец с наименьшим элементом массива
int[,] UpdateTwoDimArray(int[,] inputArray, int row, int column)
{
    int[,] outArray = new int[inputArray.GetLength(0) - 1, inputArray.GetLength(1) - 1];
    int i = 0; int j = 0;
    int k = 0; int m = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            if (i != row && j != column)
            {
                outArray[k, m] = inputArray[i, j];
            }
            if (j != column) m++;
            j++;
        }
        if (i != row) k++;
        i++;
    }
    return outArray;

}



int[,] twoDumArray = FillTwoDemArray(4, 4);
PrintTwoDimArray(twoDumArray);
Console.WriteLine();
int[] indexes = FindMinElement(twoDumArray);
Console.WriteLine(indexes[0] + " " + indexes[1]);

int[,] buferTwoDimArray = UpdateTwoDimArray(twoDumArray, indexes[0], indexes[1]);
PrintTwoDimArray(buferTwoDimArray);







