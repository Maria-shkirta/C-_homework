//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

//метод заполнения двумерного массива
double[,] FillTwoDemArray(int countRow, int countColumn)
{

    System.Random numberSyntezator = new System.Random();
    int i = 0; int j = 0;

    double[,] outArray = new double[countRow, countColumn];

    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)
        {
            outArray[i, j] = numberSyntezator.Next(-100, 100);
            j++;
        }
        i++;
    }
    return outArray;

}

//Метод для печати двумерного массива
void PrintTwoDimArray(double[,] inputArray)
{
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.Write(inputArray[i, j] + " ");
            j++;
        }
        //Console.Write("\n")
        Console.WriteLine();
        i++;
    }


}

double[,] UpdateTwoDimArray(double[,] inputArray)
{
     int i = 0; int j = 0;
    double[,] newArray=new double[inputArray.GetLength(0),inputArray.GetLength(1)];
    Random rand=new Random();
     
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            newArray[i,j]=rand.NextDouble();
            j++;
        }
        i++;
    }
    return newArray;

}


double[,] twoDumArray = FillTwoDemArray(3, 4);
PrintTwoDimArray(twoDumArray);
UpdateTwoDimArray(twoDumArray);
PrintTwoDimArray(twoDumArray);

