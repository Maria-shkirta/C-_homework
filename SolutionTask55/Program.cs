//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. Вслучае, если это невозможно, программа должна вывести сообщение для пользователя


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

//метод меняет местами столбцы и строки
//принимает двумерный массив
//возвращает модифицированный входной массив
int[,] RotateToDimArray(int[,] inputArray)
{
    int bufferElement = 0;
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = i;
        while (j < inputArray.GetLength(0))
        {
            //блок ротации элементов
            bufferElement = inputArray[i, j];
            inputArray[i, j] = inputArray[j, i];
            inputArray[j, i] = bufferElement;
            j++;
        }
        i++;
    }
    return inputArray;

}


int[,] twoDumArray = FillTwoDemArray(4, 4);
PrintTwoDimArray(twoDumArray);
Console.WriteLine();
if (twoDumArray.GetLength(0) != twoDumArray.GetLength(1))
{
    Console.WriteLine("Данный массив нельзя перевернуть");
}
else
{
    PrintTwoDimArray(RotateToDimArray(twoDumArray));
}






