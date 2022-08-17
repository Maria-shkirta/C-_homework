 //Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
            outArray[i, j] = numberSyntezator.Next(-100, 100);
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

//Вычисление среднего арифметического
double[] CalculateTwoDimArray(int[,] inputArray)
{
    double[] D=new double[inputArray.GetLength(1)];
     int i = 0; int j = 0;
    
     
    while (i < inputArray.GetLength(0))
    {
        while (j < inputArray.GetLength(1))
        {
            D[j]+=inputArray[i,j];
            j++;
            
        }
        i++;
    }
    double[] Cont(double[] D,int S)
    {
        int i=0;
        while (i<D.Length)
        {
            D[i]=D[i]/S;
        }
        return D;
    }
    return Cont(D,inputArray.GetLength(0));

}

//Печать результата
void PrintResult(double[] D,int L)
{
    int i=0;
    while (i<L)
    {
        Console.WriteLine(D[i]);
    }
    
}

int[,] twoDumArray = FillTwoDemArray(3,4);
int L=twoDumArray.Length;
PrintTwoDimArray(twoDumArray);
double[] Result=CalculateTwoDimArray(twoDumArray);
PrintResult(Result,L);


