//Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали(с индексами (0,0),(1,1) и т д)


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
            Console.Write(inputArray[i, j] + " ");
            j++;
        }
        //Console.Write("\n")
        Console.WriteLine();
        i++;
    }
}

ConsoleColor[] col = new ConsoleColor[] { ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.Cyan, ConsoleColor.DarkBlue, ConsoleColor.DarkCyan, ConsoleColor.DarkGray, ConsoleColor.DarkGreen, ConsoleColor.DarkMagenta, ConsoleColor.DarkRed, ConsoleColor.DarkYellow, ConsoleColor.Gray, ConsoleColor.Green, ConsoleColor.Magenta, ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Yellow };

//метод цветной печати двумерного массива
void PrintColorTwoDimArray(int[,] inputArray)
{
    int i = 0; int j = 0;

    Console.ForegroundColor = ConsoleColor.Yellow;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.ForegroundColor = col[new System.Random().Next(0, 16)];
            Console.Write(inputArray[i, j] + " ");
            Console.ResetColor();

            j++;
        }
        //Console.Write("\n")
        Console.WriteLine();
        i++;
    }
}


//метод решения задачи 51
int CalcDiagTwoDimArray(int[,] inputArray)
{
    int outSumDiaganal = 0;
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        outSumDiaganal+=inputArray[i,i];
        i++;
    }
    return outSumDiaganal;

}


int[,] twoDumArray = FillTwoDemArray(5, 8);
PrintColorTwoDimArray(twoDumArray);
DateTime d = DateTime.Now;
int sum=CalcDiagTwoDimArray(twoDumArray);
Console.WriteLine(DateTime.Now - d);
Console.WriteLine(sum);




